using Microsoft.Extensions.DependencyInjection;

namespace Warehouse
{
    public static class AddServicesExtension
    {
        public static IServiceCollection AddWarehouseServices(this IServiceCollection services)
        {
            services.AddTransient<IWarehouseService, WarehouseService>();
            return services;
        }
    }
}
