namespace BlazorServerTutorial.Models;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Company { get; set; }
    public bool IsActive { get; set; }

    public Client(int id, string name, string email, string company, bool isActive)
    {
        Id = id;
        Name = name;
        Email = email;
        Company = company;
        IsActive = isActive;
    }
}