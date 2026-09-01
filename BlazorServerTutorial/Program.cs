using Microsoft.EntityFrameworkCore;
using BlazorServerTutorial.Components;
using BlazorServerTutorial.Data;
using BlazorServerTutorial.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
// Add Client service to the container
builder.Services.AddScoped<ClientService>();

// Add ClientPreferencesService to the container
builder.Services.AddScoped<ClientPreferencesService>();

// Add the ClientContext service to the container
builder.Services.AddDbContext<ClientContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("ClientContext")).UseLowerCaseNamingConvention()
);
    
var app = builder.Build();

CreateDbIfNotExists(app);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

static void CreateDbIfNotExists(IHost host)
{
    using (var scope = host.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<ClientContext>();
        // context.Database.EnsureCreated(); // calls the OnModelCreating() method in ClientContext
        DbInitializer.Initialize(context);
    }
}