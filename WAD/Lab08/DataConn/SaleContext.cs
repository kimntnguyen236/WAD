using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab08.Models;

namespace Lab08.DataConn
{
    public class SaleContext : DbContext
    {
        public SaleContext(DbContextOptions options) : base(options) { }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
