using Microsoft.EntityFrameworkCore;

namespace SnackisAPI.DAL
{
    public class CategoryManager
    {
        private readonly DbContextAPI _context;
        public CategoryManager(DbContextAPI context)
        {
            _context = context;
        }

        public async Task<List<Models.Category>> GetCategories()
        {
            List<Models.Category> categories = await _context.Categories.ToListAsync();

            Console.WriteLine("Nu är " + categories.Count + " kategorier hämtade.");

            return categories;
        }

    }
}
