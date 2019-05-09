using System;
using GoodsStore.Core.Entities.Base;
using GoodsStore.Core.Interfaces.Specifications;
using GoodsStore.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GoodsStore.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(Func<ISpecification<CatalogItem>> refrigerator)
        {

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
