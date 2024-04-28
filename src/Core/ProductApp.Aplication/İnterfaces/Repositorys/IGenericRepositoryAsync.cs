using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Aplication.İnterfaces.Repositorys
{
    public interface IGenericRepositoryAsync<T> where T : class
    {
        Task<List<T>> GettAllAsync();
        Task<T> GettByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
    }
}
