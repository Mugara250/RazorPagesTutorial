using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesTutorial.Pages;

public class IndexModel : PageModel
{
    public string Title { get; set; } = null!;
    public DateTime Date { get; set; }
    public string Body { get; set; } = null!;
    public void OnGet()
    {
        Title = "Cuban Midnight Sandwich";
        Date = new DateTime(2001, 1, 21);
        Body =
            "This sandwich is called a 'Media Noche' which translates to 'Midnight.' It makes a wonderful dinner sandwich because it is served hot. A nice side dish is black bean soup or black beans and rice, and plaintain chips.";
        
    }

    public void OnPost(string title, DateTime date, string body)
    {
        Title = title;
        Date = date;
        Body = body;

    }
}