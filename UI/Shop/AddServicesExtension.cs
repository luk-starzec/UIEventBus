using Microsoft.Extensions.DependencyInjection;

namespace Shop
{
    public static class AddServicesExtension
    {
        public static IServiceCollection AddShopServices(this IServiceCollection services)
        {
            services.AddTransient<IShopService, ShopService>();
            return services;
        }
    }
}
