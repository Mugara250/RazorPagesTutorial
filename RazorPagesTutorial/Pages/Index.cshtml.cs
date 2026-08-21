using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesTutorial.Pages;

public class IndexModel : PageModel
{
    public string PostTitle { get; set; } = null!;
    public DateTime PostDate { get; set; }
    public string PostBody { get; set; } = null!;
    [BindProperty]
    public string Title { get; set; } = null!;
    [BindProperty]
    public DateTime Date { get; set; }
    [BindProperty]
    public string Body { get; set; } = null!;
    public void OnGet()
    {
        PostTitle = "Cuban Midnight Sandwich";
        PostDate = new DateTime(2001, 1, 21);
        PostBody =
            "This sandwich is called a 'Media Noche' which translates to 'Midnight.' It makes a wonderful dinner sandwich because it is served hot. A nice side dish is black bean soup or black beans and rice, and plaintain chips.";
        
    }

    public void OnPost() {}
}