using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesTutorial.Pages;

public class NewSearch : PageModel
{
    public void OnGet()
    {
        
    }

    public IActionResult OnPost()
    {
        return RedirectToPage("/Index");
    }
}