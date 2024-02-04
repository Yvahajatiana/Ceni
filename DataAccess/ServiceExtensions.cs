using CoreApp.Repositories;
using DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class ServiceExtensions
    {
        public static void AddDataAccessLayer(this IServiceCollection services)
        {
            services.AddSingleton<DapperContext>();
            services.AddScoped<IElectorRepository, ElectorRepository>();
        }
    }
}
