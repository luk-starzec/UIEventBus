using Microsoft.Extensions.DependencyInjection;

namespace Catalog
{
    public static class AddServicesExtension
    {
        public static IServiceCollection AddCatalogServices(this IServiceCollection services)
        {
            services.AddTransient<ICatalogService, CatalogService>();
            services.AddScoped<JsHelper>();
            return services;
        }
    }
}
