using Microsoft.EntityFrameworkCore;
using RazorPagesTutorial.Data;
using RazorPagesTutorial.Pages.Pizza;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
// add custom services to the container
builder.Services.AddScoped<IPizzaData, PizzaData>();
// add database connection service to the container
Console.WriteLine(builder.Configuration.GetConnectionString("DefaultConnection"));
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();

using var scope = app.Services.CreateScope();
var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

try
{
    if (db.Database.CanConnect())
    {
        Console.WriteLine("Successfully connected to the database!");
    }
    else
    {
        Console.WriteLine("Cannot connect to the database");
    }
}
catch (Exception e)
{
    Console.WriteLine($"Database connection failed: {e.Message}");
    throw;
}
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

// app.Use(async (context, next) =>
// {
//     await context.Response.WriteAsync("Hello from first middleware\n");
//     await next();
//     await context.Response.WriteAsync("Hello again from first middleware\n");
// });
//
// app.Run(async (context) =>
// {
//     await context.Response.WriteAsync("The pipeline has been hijacked!\n");
// });

app.MapStaticAssets();
app.MapRazorPages()
    .WithStaticAssets();
// custom middleware component
app.Use(async (context, next) =>
{
    await next();
    await context.Response.WriteAsync("A custom middleware with a request through the pipeline");
});
app.Run();