using ProductApp.Aplication.İnterfaces.Repositorys;
using ProductApp.Domain.Entities;
using ProductApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistence.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductResository
    {
        public ProductRepository(ProductDbContext context) : base(context)
        {
        }
    }
}
