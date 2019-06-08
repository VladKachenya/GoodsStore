using GoodsStore.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace GoodsStore.Web.Presentation.Areas.Account.Controllers
{
    public class ManageController : BaseAccountController
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}