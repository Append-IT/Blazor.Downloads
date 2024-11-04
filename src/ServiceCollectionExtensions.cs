using Microsoft.Extensions.DependencyInjection;
namespace Append.Blazor.Downloads;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDownloadServices(this IServiceCollection services)
    {
        return services.AddScoped<IDownloadService, DownloadService>();
    }
}

