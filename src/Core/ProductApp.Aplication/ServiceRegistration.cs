using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Aplication.İnterfaces.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Aplication
{
    public static class ServiceRegistration
    {
        public static void AddAplicationService(this IServiceCollection services)
        {
            var assm=Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assm);
            services.AddMediatR(assm);

        }

      
    }
}
