using Infrastructure.Abstractions;
using Infrastructure.Implementations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class RegisterLayerExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IThirdPartyCurrencyService, PrivatBankCurrencyService>();
    }
}
