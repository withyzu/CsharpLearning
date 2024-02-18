using DemoCRUD.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SharedLibrary.Repositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<IProductRepository, ProductService>();

builder.Services.AddScoped(http => new HttpClient {
	BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});

await builder.Build().RunAsync();
