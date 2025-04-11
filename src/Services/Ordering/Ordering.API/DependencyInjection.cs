namespace Ordering.API;

public static class DependencyInjection
{
    public static IServiceCollection AddApiSerivces(this IServiceCollection services)
    {
        //services.AddCarter();

        return services;
    }

    public static WebApplication UseApiSerivces(this WebApplication app)
    {
        //app.MapCarter();
        return app;
    }

}