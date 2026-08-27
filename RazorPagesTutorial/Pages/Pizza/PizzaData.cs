namespace RazorPagesTutorial.Pages.Pizza;

public class PizzaData : IPizzaData
{
    public List<string> GetAll()
    {
        return
        [
            "Pepperoni",
            "Vegetarian",
            "Cheese",
            "Margherita",
            "Hawaiian",
            "BBQ Chicken"
        ];
    }
}