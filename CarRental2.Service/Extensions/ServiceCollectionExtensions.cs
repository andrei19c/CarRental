using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental2.Service.Extensions
{
    public static class ServiceCollectionExtensions
    {
        //public static IServiceCollection AddServices(this IServiceCollection services)
        //{
             
        //}

        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
