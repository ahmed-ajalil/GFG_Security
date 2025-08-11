using BlackListWebApp.Components;
using BlackListWebApp.Data;
using BlackListWebApp.Interfaces;
using BlackListWebApp.Services;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(); // End this statement with a semicolon

builder.Services.AddHostedService<BackgroundWorkerService>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString)
);

builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApp(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddRazorPages()
    .AddMicrosoftIdentityUI();

builder.Services.AddAuthorization(options =>
{
    // Policy for users in the "Administrators" group
    options.AddPolicy("AdminsOnly", policy =>
        policy.RequireClaim("groups", "95ffecdc-ecb1-4e1b-a4c3-17d1a5153d5c", "2a438112-4dcf-493e-8e64-fd94ac34ddf8"));

    // Policy for users in the "Managers" group
    options.AddPolicy("UserRole", policy =>
        policy.RequireClaim("groups", "714b5a8d-b284-4905-8537-e3977c04bdb2"));

    // Policy for users in the "Managers" group
    options.AddPolicy("DevelopersOnly", policy =>
        policy.RequireClaim("groups", "2a438112-4dcf-493e-8e64-fd94ac34ddf8"));

    // You can also require membership in one of several groups
    options.AddPolicy("AllUsers", policy =>
        policy.RequireClaim("groups",
            "95ffecdc-ecb1-4e1b-a4c3-17d1a5153d5c",
            "714b5a8d-b284-4905-8537-e3977c04bdb2",
            "2a438112-4dcf-493e-8e64-fd94ac34ddf8"
        ));
});

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

// 1. Load configuration (same as before)
var assembly = Assembly.GetExecutingAssembly();
using var stream = assembly.GetManifestResourceStream("BlackListWebApp.appsettings.json"); // <-- IMPORTANT: Replace YourProjectName
var config = new ConfigurationBuilder()
            .AddJsonStream(stream)
            .Build();
builder.Configuration.AddConfiguration(config);

// 2. Register the GraphEmailService
builder.Services.AddSingleton<GraphEmailService>();

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

// ADD THESE TWO LINES
app.MapRazorPages();
app.MapControllers();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
