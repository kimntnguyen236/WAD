using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Lab8.Models;

namespace Lab8.DataConnect
{
    public class SaleContext : DbContext
    {
        public SaleContext(DbContextOptions options) : base(options) { }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
