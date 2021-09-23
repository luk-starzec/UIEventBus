using Microsoft.Extensions.DependencyInjection;

namespace Report
{
    public static class AddServicesExtension
    {
        public static IServiceCollection AddRaportServices(this IServiceCollection services)
        {
            services.AddTransient<IEventParser, EventParser>();
            services.AddTransient<IEventSubscriber, EventSubscriber>();
            return services;
        }
    }
}
