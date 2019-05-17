using GoodsStore.Core.Interfaces.Repositories;
using GoodsStore.Web.ViewModel.Interfaces.Factories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
            var viewModel =
                _categoryModelFactory.GetCategoryModels(await _categoryRepository.ListAllIncludesCatalogItemsAsync());
            return View(viewModel);
        }
    }
}