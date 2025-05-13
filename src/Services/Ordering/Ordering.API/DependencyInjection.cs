using BuildingBlocks.Exceptions.Handler;

namespace Ordering.API;

public static class DependencyInjection
{
    public static IServiceCollection AddApiSerivces(this IServiceCollection services)
    {
        services.AddCarter();
        services.AddExceptionHandler<CustomExceptionHandler>();
        return services;
    }

    public static WebApplication UseApiSerivces(this WebApplication app)
    {
        app.MapCarter();
        app.UseExceptionHandler(options => { });
        return app;
    }

}