using GoodsStore.Core.Domain.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoodsStore.Web.Presentation.Components
{
    public class IdentityWidgetViewComponent : ViewComponent
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ISingInManager _manager;

        public IdentityWidgetViewComponent(
            IHttpContextAccessor httpContextAccessor,
            ISingInManager manager)
        {
            _httpContextAccessor = httpContextAccessor;
            _manager = manager;
        }

        public IViewComponentResult Invoke()
        {
            var user = _httpContextAccessor.HttpContext.User;
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