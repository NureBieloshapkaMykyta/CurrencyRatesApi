using DataAccess.Abstractions;
using DataAccess.Implementations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

public static class RegisterLayerExtension
{
    public static void AddDataAccess(this IServiceCollection services, IConfiguration configuration) 
    {
        services.AddScoped<IFilesAccessService, FilesAccessService>();
    }
}
