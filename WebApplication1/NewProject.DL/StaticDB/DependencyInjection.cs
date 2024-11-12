using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using NewProject.DL.Interfaces;
using NewProject.DL.Repositories;



namespace NewProject.DL.StaticDB


{
    public static class DependencyInjection
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddSingleton<IMovieRepository, MovieRepository>();
        }
    }
}
