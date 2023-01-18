using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ProductsApp.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Configuration.AddJsonFile($"/appsettings.{builder.HostEnvironment.Environment}.json",true,true);
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["BaseUrl"]) });
await builder.Build().RunAsync();
