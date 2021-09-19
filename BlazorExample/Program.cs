using BlazorExample.Catalog;
using BlazorExample.Report;
using BlazorExample.Shop;
using BlazorExample.Warehouse;
using ComponentBus;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorExample
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<ComponentEventBus>();

            builder.Services.AddTransient<ICatalogService, CatalogService>();
            builder.Services.AddTransient<IShopService, ShopService>();
            builder.Services.AddTransient<IWarehouseService, WarehouseService>();

            builder.Services.AddTransient<IEventParser, EventParser>();

            await builder.Build().RunAsync();
        }
    }
}
