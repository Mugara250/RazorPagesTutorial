var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

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

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hello from first middleware\n");
    await next();
    await context.Response.WriteAsync("Hello again from first middleware\n");
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("The pipeline has been hijacked!\n");
});

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