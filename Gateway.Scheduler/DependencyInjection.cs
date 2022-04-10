using Hangfire;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Gateway.Scheduler;

public static class DependencyInjection
{
    public static IServiceCollection AddScheduler(this IServiceCollection services)
    {
        // var storageOptions = new SqlServerStorageOptions
        // {
        //     CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
        //     SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
        //     QueuePollInterval = TimeSpan.Zero,
        //     UseRecommendedIsolationLevel = true,
        //     UsePageLocksOnDequeue = true,
        //     DisableGlobalLocks = true
        // };
        //
        // services.AddHangfire(configuration => configuration
        //     .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
        //     .UseSimpleAssemblyNameTypeSerializer()
        //     .UseRecommendedSerializerSettings()
        //     .UseSqlServerStorage("setup connection string", storageOptions)
        // );
        //
        // services.AddHangfireServer(options => 
        // {
        //     options.Queues = new[] 
        //     { 
        //         "enter queue names here"
        //     };
        // });

        return services;
    }

    public static IApplicationBuilder UseScheduler(this IApplicationBuilder app)
    {
        // app.UseHangfireServer();
        //
        // app.UseHangfireDashboard("/scheduler", new DashboardOptions 
        // {
        //
        // });
        //
        // SetupRecurringJobs();

        return app;
    }

    private static void SetupRecurringJobs()
    {
    }
}