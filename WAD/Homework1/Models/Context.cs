using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Homework1.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }
        public DbSet<tbNews> tbNews { get; set; }
        public DbSet<tbAdmin> tbAdmin { get; set; }
    }
}
