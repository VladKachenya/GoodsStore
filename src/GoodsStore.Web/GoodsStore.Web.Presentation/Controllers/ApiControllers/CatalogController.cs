using GoodsStore.Web.Framework.Controllers;
using GoodsStore.Web.ViewModel.Models.CompositModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GoodsStore.Web.Presentation.Controllers.ApiControllers
{
    public class CatalogController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> GetCatalogItems([FromBody]CatalogItemModelFilter queryViewModel)
        {
            return Ok();
        }
    }
}