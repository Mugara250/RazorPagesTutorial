using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesTutorial.Pages;

public class Profile : PageModel
{
    public void OnGet()
    {
        ViewData["myName"] = "Mushi Mbonyumugara";
        ViewData["username"] = "Mugara";
        ViewData["occupation"] = "Software Engineeer";
        ViewData["myAge"] = 25;
        ViewData["currentDate"] = "08/20/2026";
    }
}