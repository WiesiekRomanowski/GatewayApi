using Microsoft.Extensions.DependencyInjection;

namespace Gateway.Core.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}