using BlazorServerTutorial.Models;

namespace BlazorServerTutorial.Services;

public class ClientService
{
    private readonly List<Client> _clients =
    [
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
        new Client { Id = 5, Name = "Ray Zor", Email = "rzor@example.com", Company = "UI Designs", IsActive = false }
    ];

    public List<Client> GetAllClients()
    {
        return _clients;
    }
    
    public async Task<List<Client>> GetAllClientsAsync()
    {
        // Simulate API delay
        await Task.Delay(2000);
        return _clients;
    }
    public void AddClient(Client client)
    {
        client.Id = _clients.Count + 1;
        _clients.Add(client);
    }

    public event Action? OnClientsChanged;

    public void NotifyClientsChanged()
    {
        OnClientsChanged?.Invoke();
    }
    
    public async Task AddClientAsync(Client client)
    {
        await Task.Delay(1500);
        client.Id = _clients.Count + 1;
        _clients.Add(client);
    }

    public Client? GetClientById(int id)
    {
        return _clients.FirstOrDefault(c => c.Id == id);
    }
}