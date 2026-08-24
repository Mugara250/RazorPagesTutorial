using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesTutorial.Pages;

public class OldSearch : PageModel
{
    public void OnGet()
    {
        
    }

    public IActionResult OnPost()
    {
        return NotFound();
    }
}