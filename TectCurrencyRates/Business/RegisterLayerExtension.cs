
using Business.Abstractions;
using Business.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Business;

public static class RegisterLayerExtension
{
    public static void AddBusiness(this IServiceCollection services) 
    {
        services.AddScoped<ICourseService, CourseService>();
        services.AddScoped<ICurrencyService, CurrencyService>();
    }
}
