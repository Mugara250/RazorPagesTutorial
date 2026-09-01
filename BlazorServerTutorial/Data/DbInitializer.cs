using BlazorServerTutorial.Models;

namespace BlazorServerTutorial.Data;

public class DbInitializer
{
    public static void Initialize(ClientContext context)
    {
        context.Database.EnsureCreated();

        if (context.Clients.Any())
        {
            return;
        }

        var clients = new List<Client>()
        {
            new Client
            {
                Id = 1, Name = "CeeCee Sharpe", Email = "csharpe@example.com", Company = "Acme Corp", IsActive = true
            },
            new Client
            {
                Id = 2, Name = "Dot Nett", Email = "dnett@example.com", Company = "Tech Solutions", IsActive = true
            },
            new Client
            {
                Id = 3, Name = "Jay Script", Email = "jscript@example.com", Company = "Web Design Co", IsActive = false
            },
            new Client
            {
                Id = 4, Name = "Ella Query", Email = "equery@example.com", Company = "Data Systems", IsActive = true
            },
            new Client
            {
                Id = 5, Name = "Ray Zor", Email = "rzor@example.com", Company = "UI Designs", IsActive = false
            }
        };

        foreach (var client in clients)
        {
            context.Clients.Add(client);
        }

        context.SaveChanges();

    }
}