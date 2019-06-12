using GoodsStore.Core.Domain.Managers;
using GoodsStore.Core.Infrastructure.Services;
using GoodsStore.Web.Framework.Controllers;
using GoodsStore.Web.Framework.Keys;
using GoodsStore.Web.ViewModel.Models.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoodsStore.Web.Presentation.Areas.Account.Controllers
{
    public class HomeController : BaseAccountController
    {
        private readonly ISignInManager _signInManager;
        private readonly IUserManager _userManager;
        private readonly IComparisonBasketSevice _comparisonBasketSevice;

        public HomeController(
            ISignInManager signInManager,
            IUserManager userManager,
            IComparisonBasketSevice comparisonBasketSevice
            )
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _comparisonBasketSevice = comparisonBasketSevice;
        }
        // GET
        public IActionResult Index()
        {
            if (_signInManager.IsSignedIn(User))
            {
                return Redirect("~/Account/Manage");
            }

            return Redirect("~/Account/Login");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login()
        {
            await _signInManager.SignOut();
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginModel);
            }
            var result = await _signInManager.PasswordSignIn(loginModel.Email, loginModel.Password, loginModel.RememberMe, false);

            if (!result.IsSucceed)
            {
                AddError("Invalid login attempt.");
                AddErrors(result.ErrorList);
                return View(loginModel);
            }

            await ClearGuestData();
            return RedirectToLocal(null);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            if (!ModelState.IsValid)
            {
                return View(registerModel);
            }

            var res = await _userManager.Create(registerModel.Email, registerModel.Email, registerModel.Password);
            if (res.IsSucceed)
            {
                await _signInManager.SignIn(res.Item, isPersistent: false);
                return RedirectToLocal(null);
            }
            AddErrors(res.ErrorList);
            return View();
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            ViewData["User"] = User.Identity.Name;
            await _signInManager.SignOut();
            return View();
        }

        #region Utilities
        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToRoute("default", new { controller = "Home", action = "Index" });
            }
        }

        private void AddErrors(IEnumerable<string> errors)
        {
            foreach (var error in errors)
            {
                AddError(error);
            }
        }

        private void AddError(string error)
        {
            ModelState.AddModelError("", error);
        }

        private async Task ClearGuestData()
        {
            if (Request.Cookies.ContainsKey(WebConstants.AnonymousGuestCookieName) && Request.Cookies[WebConstants.AnonymousGuestCookieName] != null)
            {
                await _comparisonBasketSevice.DeleteBasket(Request.Cookies[WebConstants.AnonymousGuestCookieName]);
                Response.Cookies.Delete(WebConstants.AnonymousGuestCookieName);
            }
        }

        #endregion
    }
}