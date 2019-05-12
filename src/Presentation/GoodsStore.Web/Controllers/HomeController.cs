using GoodsStore.Core.Entities;
using GoodsStore.Core.Interfaces.Specifications;
using GoodsStore.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GoodsStore.Core.Interfaces.Repositories;

namespace GoodsStore.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAsyncRepository<Category> _categoryRepository;


        public HomeController(IAsyncRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryRepository.ListAllAsync();
            var categoryNames = categories.Select(c => c.CategoryName).ToList();
            return View(categoryNames);
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
