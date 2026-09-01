using BlazorServerTutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTutorial.Data;

public class ClientContext : DbContext
{
    public ClientContext(DbContextOptions<ClientContext> options) : base(options){}
    public DbSet<Client> Clients { get; set; }

    public void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>().ToTable("clients");
    }
}