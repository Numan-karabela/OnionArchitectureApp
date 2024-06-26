﻿using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistence.Context
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }

        public DbSet<Product> products{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id=Guid.NewGuid(), Name="Numan1",Quantity=1000,Value=11},
                new Product() { Id=Guid.NewGuid(), Name="Numan2",Quantity=3000,Value=12},
                new Product() { Id=Guid.NewGuid(), Name="Numan3",Quantity=4000,Value=13}
        );

            base.OnModelCreating(modelBuilder);
        } 
    }
}
