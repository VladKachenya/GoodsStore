using GoodsStore.Core.Domain.Entities.ComparisonBasketAggregate;
using GoodsStore.Core.Domain.Managers;
using GoodsStore.Core.Infrastructure.Services;
using GoodsStore.Web.Framework.Controllers;
using GoodsStore.Web.Framework.Keys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GoodsStore.Web.Presentation.Controllers.ApiControllers
{
    public class ComparisonBasketController : BaseApiController
    {
        private readonly IComparisonBasketSevice _comparisonBasketSevice;
        private readonly ISignInManager _signInManager;

        public ComparisonBasketController(
            IComparisonBasketSevice comparisonBasketSevice,
            ISignInManager signInManager
            )
        {
            _comparisonBasketSevice = comparisonBasketSevice;
            _signInManager = signInManager;
        }

        [HttpPost("{catalogItemId}")]
        public async Task<IActionResult> BasketItem(int catalogItemId, [FromBody] string typeDiscriminator)
        {
            var comparisonBasket = await _comparisonBasketSevice.GetOrCreateBasketForUser(GetOrSetCookieUserName());
            await _comparisonBasketSevice.AddItemToBasket(comparisonBasket.Id, catalogItemId, typeDiscriminator);
            return Ok(comparisonBasket.Items.Count);
        }

        [HttpGet]
        public async Task<IActionResult> ItemsCount()
        {
            var userId = GetOrSetCookieUserName();
            await _comparisonBasketSevice.GetOrCreateBasketForUser(userId);
            var count = await _comparisonBasketSevice.GetBasketItemCount(userId);
            return Ok(count);
        }

        #region Utilities
        


        private string GetOrSetCookieUserName()
        {
            if (_signInManager.IsSignedIn(HttpContext.User))
            {
                return User.Identity.Name;
            }

            if (Request.Cookies.ContainsKey(WebConstants.AnonymousGuestCookieName) && Request.Cookies[WebConstants.AnonymousGuestCookieName] != null)
            {
                return Request.Cookies[WebConstants.AnonymousGuestCookieName];
            }

            var nameAnonymousUser = Guid.NewGuid().ToString();
            var cookieOptions = new CookieOptions { Expires = DateTime.Today.AddDays(10) };
            Response.Cookies.Append(WebConstants.AnonymousGuestCookieName, nameAnonymousUser, cookieOptions);
            return nameAnonymousUser;
        }
        #endregion

    }
}