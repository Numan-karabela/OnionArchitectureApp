using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Aplication.İnterfaces.Repositorys;
using ProductApp.Persistence.Context;
using ProductApp.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddDbContext<ProductDbContext>(ops=>ops.UseInMemoryDatabase("MemoryDb"));
            services.AddTransient<IProductResository,ProductRepository>();


        }
    }
}
