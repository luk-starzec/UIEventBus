using Catalog;
using ComponentBus;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Report;
using Shop;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Warehouse;

namespace BlazorApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<ComponentEventBus>();

            builder.Services.AddCatalogServices();
            builder.Services.AddShopServices();
            builder.Services.AddWarehouseServices();
            builder.Services.AddRaportServices();

            await builder.Build().RunAsync();
        }
    }
}
