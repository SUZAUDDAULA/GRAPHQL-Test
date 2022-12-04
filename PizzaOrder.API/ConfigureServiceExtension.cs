using Microsoft.Extensions.DependencyInjection;
using PizzaOrder.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrder.API
{
    public static class ConfigureServiceExtension
    {
        public static void AddCustomService(this IServiceCollection services)
        {
            services.AddTransient<IPizzaDetailsService, PizzaDetailsService>();
            services.AddTransient<IOrderDetailsService, OrderDetailsService>();
        }
    }
}
