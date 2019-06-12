using System.Threading.Tasks;
using GoodsStore.Core.Infrastructure.Services;
using GoodsStore.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace GoodsStore.Web.Presentation.Controllers.ApiControllers
{
    public class ComparisonBasketController : BaseApiController
    {
        private readonly IComparisonBasketSevice _comparisonBasketSevice;

        public ComparisonBasketController(
            IComparisonBasketSevice comparisonBasketSevice
            )
        {
            _comparisonBasketSevice = comparisonBasketSevice;
        }

        [HttpPost("{catalogItemId}")]
        public async Task<IActionResult> BasketItem( int catalogItemId, [FromBody] string typeDiscriminator)
        {
            var comparisonBasket = await _comparisonBasketSevice.GetOrCreateBasketForUser(User.Identity.Name);
            await _comparisonBasketSevice.AddItemToBasket(comparisonBasket.Id, catalogItemId, typeDiscriminator);
            return Ok(comparisonBasket.Items.Count);
        }

        [HttpGet]
        public async Task<IActionResult> ItemsCount()
        {
            var count = await _comparisonBasketSevice.GetBasketItemCount(User.Identity.Name);
            return Ok(count);
        }

    }
}