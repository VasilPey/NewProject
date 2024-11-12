using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using NewProject.BL.Interfaces;
using NewProject.BL.Services;
using NewProject.DL.StaticDB;



namespace NewProject.BL.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterBusinessLayer(this IServiceCollection services)
        {
            services.AddSingleton<IMovieService, MovieService>();
            return services;
        }
        public static IServiceCollection RegisterDataLayer(this IServiceCollection services)
        {
            services.RegisterRepositories();
            return services;
        }
    }
}
