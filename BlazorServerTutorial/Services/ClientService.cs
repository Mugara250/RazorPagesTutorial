using BlazorServerTutorial.Models;

namespace BlazorServerTutorial.Services;

public class ClientService
{
    private List<Client> clients = new List<Client>
    {
        new Client { Id = 1, Name = "CeeCee Sharpe", Email = "csharpe@example.com", Company = "Acme Corp", IsActive = true },
        new Client { Id = 2, Name = "Dot Nett", Email = "dnett@example.com", Company = "Tech Solutions", IsActive = true },
        new Client { Id = 3, Name = "Jay Script", Email = "jscript@example.com", Company = "Web Design Co", IsActive = false },
        new Client { Id = 4, Name = "Ella Query", Email = "equery@example.com", Company = "Data Systems", IsActive = true },
        new Client { Id = 5, Name = "Ray Zor", Email = "rzor@example.com", Company = "UI Designs", IsActive = false }
    };

    public List<Client> GetAllClients()
    {
        return clients;
    }
    
    public async Task<List<Client>> GetAllClientsAsync()
    {
        // Simulate API delay
        await Task.Delay(2000);
        return clients;
    }
    public void AddClient(Client client)
    {
        client.Id = clients.Count + 1;
        clients.Add(client);
    }

    public event Action? OnClientsChanged;

    public void NotifyClientsChanged()
    {
        OnClientsChanged?.Invoke();
    }
}