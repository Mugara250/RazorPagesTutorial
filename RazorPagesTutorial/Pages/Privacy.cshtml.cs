using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorPagesTutorial.Pages;

public class PrivacyModel : PageModel
{
    public string Country { get; set; } = null!;
    public List<SelectListItem> Countries { get; set; } = null!;

    public void OnGet()
    {
        Countries =
        [
            new SelectListItem("RW", "Rwanda"),
            new SelectListItem("UG", "Uganda"),
            new SelectListItem("SA", "South Africa"),
            new SelectListItem("KE", "Kenya"),
            new SelectListItem("TZ", "Tanzania")
        ];
    }
}