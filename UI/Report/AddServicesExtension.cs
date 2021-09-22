using Microsoft.Extensions.DependencyInjection;

namespace Report
{
    public static class AddServicesExtension
    {
        public static IServiceCollection AddRaportServices(this IServiceCollection services)
        {
            services.AddTransient<IEventParser, EventParser>();
            return services;
        }
    }
}
