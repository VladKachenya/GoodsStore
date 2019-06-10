using GoodsStore.Core.Domain.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoodsStore.Web.Presentation.Components
{
    public class IdentityWidgetViewComponent : ViewComponent
    {
        private readonly ISingInManager _manager;

        public IdentityWidgetViewComponent(
            ISingInManager manager
            )
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke()
        {
            var user = HttpContext.User;
            var isSignIn = _manager.IsSignedIn(user);
            (bool, string) res;
            if (isSignIn)
            {
                res = (isSignIn, user.Identity.Name);
            }
            else
            {
                res = (isSignIn, string.Empty);
            }

            return View(res);
        }
    }
}