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
        public async Task<ActionResult> BasketItem(int catalogItemId, [FromBody]string typeDiscriminator)
        {
            //await _comparisonBasketSevice.AddItemToBasket(User.Identities.)

            return Ok();
        }

    }
}