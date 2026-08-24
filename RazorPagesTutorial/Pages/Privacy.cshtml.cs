using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorPagesTutorial.Pages;

public class PrivacyModel : PageModel
{
    public string Country { get; set; } = null!;
    public List<SelectListItem> Countries { get; set; } = null!;
    [BindProperty] public string Title { get; set; } = "";
    [BindProperty] public DateTime Date { get; set; } = DateTime.Today;

    [BindProperty] public string Body { get; set; } = "";

    public string RecentPostTitle { get; set; } = "";
    public DateTime RecentPostDate { get; set; }
    public string RecentPostBody { get; set; } = "";

    public void OnGet(string? title, DateTime date, string? body)
    {
        Countries =
        [
            new SelectListItem("RW", "Rwanda"),
            new SelectListItem("UG", "Uganda"),
            new SelectListItem("SA", "South Africa"),
            new SelectListItem("KE", "Kenya"),
            new SelectListItem("TZ", "Tanzania")
        ];
        if (title != null && body != null)
        {
            RecentPostTitle = title;
            RecentPostDate = date;
            RecentPostBody = body;
        }
        else
        {
            RecentPostTitle = "Cuban Midnight Sandwich";
            RecentPostDate = new DateTime(2001, 1, 21);
            RecentPostBody = "This sandwich is called a 'Media Noche' which translates to 'Midnight.' It makes a wonderful dinner sandwich because it is served hot. A nice side dish is black bean soup or black beans and rice, and plaintain chips.";
        }
    }

    public IActionResult OnPost()
    {
        return RedirectToPage("/Privacy", new
        {
            title = Title,
            date = Date,
            body = Body,
        });
    }
}