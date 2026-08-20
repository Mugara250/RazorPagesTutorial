using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesTutorial.Pages;

public class Pizza : PageModel
{
    public double Total { get; set; }
    public string Customer { get; set; }
    public string Order { get; set; }
    public bool ExtraCheese { get; set; }

    public double PizzaTotal(string pizzaType)
    {
        Dictionary<string, double> PizzaCost = new Dictionary<string, double>()
        {
            { "Cheese", 10 },
            { "Pepperoni", 11 },
            { "Vegetarian", 12 },
        };
        return PizzaCost[pizzaType];
    }
    public void OnGet()
    {
        Customer = "Mushi Mbonyumugara";
        Order = "Cheese";
        ExtraCheese = false;
        Total = PizzaTotal("Cheese");
    }
}