using System;
using System.Collections.Generic;
using System.Text;
using CakesWebApp.Models;
using Microsoft.EntityFrameworkCore;
using SIS.HTTP.Common;

namespace CakesWebApp.Data
{
    public class CakesDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.Connection).UseLazyLoadingProxies();
        }
    }
}
