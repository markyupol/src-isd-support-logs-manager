using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// TODO: Temporary Commented Out
//builder.Services.AddScoped<ISupportDataService, ClientSupportDataService>();

builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();

