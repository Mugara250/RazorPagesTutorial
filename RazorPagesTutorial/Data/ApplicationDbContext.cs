using Microsoft.EntityFrameworkCore;

namespace RazorPagesTutorial.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
}