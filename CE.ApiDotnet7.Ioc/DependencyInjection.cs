using System;
using CE.ApiDotnet7.Application.Mappings;
using CE.ApiDotnet7.Application.Services;
using CE.ApiDotnet7.Application.Services.Interfaces;
using CE.ApiDotnet7.Domain.Interfaces;
using CE.ApiDotnet7.Infra.Data.Context;
using CE.ApiDotnet7.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CE.ApiDotnet7.Infra.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CeContext>(options => options.UseSqlServer(configuration.GetConnectionString("CeConnection")));
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IUserRepository, UserRepository>();


            //   services.AddScoped<IPurchaseRepository, PurchaseRepository>();

            return services;
        }

        public static IServiceCollection AddService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(CarToDtoMapping));
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();



            return services;
        }
    }
}
