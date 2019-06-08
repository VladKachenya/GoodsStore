using GoodsStore.Core.Domain.Managers;
using GoodsStore.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace GoodsStore.Web.Presentation.Areas.Account.Controllers
{
    public class HomeController : BaseAccountController
    {
        private readonly ISingInManager _singInManager;

        public HomeController(ISingInManager singInManager)
        {
            _singInManager = singInManager;
        }
        // GET
        public IActionResult Index()
        {
            if (_singInManager.IsSignedIn(User))
            {

            }

            return Redirect("~/Account/Manage");
        }
    }
}