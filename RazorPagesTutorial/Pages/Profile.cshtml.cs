using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesTutorial.Pages;

public class Profile : PageModel
{
    public void OnGet()
    {
        ViewData["myName"] = "Mushi Mbonyumugara";
        ViewData["username"] = "Mugara";
        ViewData["myOccupation"] = "Software Engineeer";
        ViewData["myAge"] = 25;
        ViewData["currentDate"] = $"{DateTime.Today.ToShortDateString()}";
    }
}