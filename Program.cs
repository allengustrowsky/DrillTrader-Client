using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using client.Data;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddMudServices();
//builder.Services.AddHttpClient();chat
builder.Services.AddScoped(sp =>
    new HttpClient
    {
        //BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
        BaseAddress = new Uri("http://127.0.0.1:3000/")
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
