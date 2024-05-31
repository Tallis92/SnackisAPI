using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace SnackisAPI.DAL
{
    public class CategoryData
    {
        //public  List<Models.Category> Categories { get; set; }
        //private readonly DAL.DbContextAPI _context;
        //public CategoryData(DbContextAPI context)
        //{

        //    _context = context;

        //}

        //public async Task<List<Models.Category>> GetCategoriesAsync()
        //{
        //    List<Models.Category> categories = new List<Models.Category>();

        //    Categories = await _context.Categories.ToListAsync();
          
        //    return categories;

        //}
    }
}
//using (var client = new HttpClient())
//{
//    client.BaseAddress = new Uri("https://tabletoptalk.azurewebsites.net/");

//    HttpResponseMessage response = await client.GetAsync("api/Categories");//Möjligtvis fråga Micke om vad som ska stå här?
//    if (response.IsSuccessStatusCode)
//    {
//        string responseString = await response.Content.ReadAsStringAsync();
//        categories = JsonSerializer.Deserialize<List<Models.Category>>(responseString);
//    }


//}
