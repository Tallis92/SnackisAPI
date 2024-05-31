using Microsoft.AspNetCore.Mvc;
using SnackisAPI.DAL;

namespace SnackisAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CategoriesController : Controller
    {
        private readonly CategoryManager _categoryManager;
        public CategoriesController(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet]
        public async Task<IEnumerable<Models.Category>> GetCategoriesAsync()
        {
            return await _categoryManager.GetCategories();
        }
    }
}
