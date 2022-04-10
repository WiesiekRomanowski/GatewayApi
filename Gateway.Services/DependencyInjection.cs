using Microsoft.Extensions.DependencyInjection;

namespace Gateway.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        return services;
    }
}