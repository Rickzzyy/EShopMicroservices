using Microsoft.Extensions.DependencyInjection;

namespace Ordering.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationSerivces(this IServiceCollection services)
    {
        //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<DependencyInjection>());
        //services.AddFluentValidation(cfg => cfg.RegisterValidatorsFromAssemblyContaining<DependencyInjection>());
        return services;
    }
}
