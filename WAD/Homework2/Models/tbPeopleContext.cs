using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Homework2.Models
{
    public class tbPeopleContext : DbContext
    {
        public tbPeopleContext(DbContextOptions options) : base(options) { }
        public DbSet<tbPeople> tbPeople { get; set; }
    }
}
