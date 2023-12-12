using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using mslearnwasm;
using BlazorApplicationInsights;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazorApplicationInsights(config =>
{
    config.ConnectionString = "InstrumentationKey=a07bf12c-69ad-458c-8c4b-23648c384c81;IngestionEndpoint=https://westeurope-5.in.applicationinsights.azure.com/;LiveEndpoint=https://westeurope.livediagnostics.monitor.azure.com/";
    config.InstrumentationKey = "a07bf12c-69ad-458c-8c4b-23648c384c81";
});

await builder.Build().RunAsync();
