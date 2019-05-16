using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Entities;
using GoodsStore.Core.Interfaces.Repositories;
using GoodsStore.Web.ViewModel.Interfaces.Factories;
using GoodsStore.Web.ViewModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoodsStore.Web.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryModelFactory _categoryModelFactory;
        private readonly ICatalogRepository _categoryRepository;

        #region Ctor
        public HomeController(
            ICategoryModelFactory categoryModelFactory,
            ICatalogRepository categoryRepository)
        {
            _categoryModelFactory = categoryModelFactory;
            _categoryRepository = categoryRepository;
        }
        #endregion

        public async Task<IActionResult> Index()
        {
            var res = new List<CategoryModel>();
            foreach (var category in await _categoryRepository.ListAllIncludesCatalogItemsAsync())
            {
                res.Add(_categoryModelFactory.GetCategoryModel(category));
            }
            return View(res);
        }
    }
}