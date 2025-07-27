using BlackListWebApp.Components;
using BlackListWebApp.Data;
using BlackListWebApp.Interfaces;
using BlackListWebApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString)
);

// Register application services
builder.Services.AddScoped<IBlackListService, BlackListService>();
builder.Services.AddScoped<INonVisaService, NonVisaService>();

builder.Services.AddHttpClient<ApiService>(client =>
{
    // 1. Set the base address of the API
    client.BaseAddress = new Uri("https://gfsabrewebapi.azurewebsites.net/");

    // 2. Set default headers
    client.DefaultRequestHeaders.Add("Accept", "*/*");

    // !! IMPORTANT NOTE ON COOKIES !!
    // Hardcoding session cookies is fragile. This replicates the Postman request,
    // but a more robust solution would involve proper session management or token authentication.
    var cookieValue = "ARRAffinity=e0626f5e6852f4855a5f56304569fa400f626eb82af185ca565647512c020dc9; ARRAffinitySameSite=e0626f5e6852f4855a5f56304569fa400f626eb82af185ca565647512c020dc9";
    client.DefaultRequestHeaders.Add("Cookie", cookieValue);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
