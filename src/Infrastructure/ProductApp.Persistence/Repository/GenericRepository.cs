using Microsoft.EntityFrameworkCore;
using ProductApp.Aplication.İnterfaces.Repositorys;
using ProductApp.Domain.Common;
using ProductApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistence.Repository
{
    public class GenericRepository<T> : IGenericRepositoryAsync<T>  where T:BaseEntity
    {
       private readonly ProductDbContext context;

        public GenericRepository(ProductDbContext context)
        {
            this.context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GettAllAsync()
        {
         return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GettByIdAsync(Guid id)
        {
          return await context.Set<T>().FindAsync(id);
        }
    }
}
