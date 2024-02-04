using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp
{
    public static class ServicesExtensions
    {
        public static void AddCoreApp(this IServiceCollection services)
        {
            services.AddScoped<IRegistrationService, RegistrationService>();
        }
    }
}
