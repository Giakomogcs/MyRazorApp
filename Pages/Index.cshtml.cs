using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages;

public class Index : PageModel{
    public List<Category> Categories { get; set; } = new();
    public async Task OnGet()
    {
        for (var i = 0; i <= 100; i++)
        {
            Categories.Add(
                item:new Category(i, 
                    Title:$"Categoria {i}", 
                    Price:i * 18.95M));
        }
        
    }
}

public record Category(int Id, string Title, decimal Price);