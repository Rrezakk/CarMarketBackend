using CarMarketBackend.Domain.Models.JWT;
using CarMarketBackend.Services.JWT;

namespace CarMarketBackend;

public static class Init
{
    public static void InitializeRepositories(this IServiceCollection serviceCollection)
    {
        //serviceCollection.AddScoped<EfRepository>();
    }
    public static void InitializeServices(this IServiceCollection serviceCollection,WebApplicationBuilder builder)
    {
        //serviceCollection.AddScoped<IService, Service>();
        serviceCollection.AddCors();
        serviceCollection.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        serviceCollection.AddScoped<IJwtUtils, JwtUtils>();
        serviceCollection.AddScoped<IAccountService, AccountService>();
        serviceCollection.AddScoped<IEmailService, EmailService>();
        serviceCollection.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
    }
}

