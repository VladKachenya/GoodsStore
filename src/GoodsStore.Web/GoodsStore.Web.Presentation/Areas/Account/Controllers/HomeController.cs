using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Managers;
using GoodsStore.Web.Framework.Controllers;
using GoodsStore.Web.ViewModel.Models.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoodsStore.Web.Presentation.Areas.Account.Controllers
{
    public class HomeController : BaseAccountController
    {
        private readonly ISingInManager _signInManager;
        private readonly IUserManager _userManager;

        public HomeController(
            ISingInManager signInManager,
            IUserManager userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
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
                return RedirectToRoute("default", new { controller = "Home", action = "Index"});
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

        #endregion
    }
}