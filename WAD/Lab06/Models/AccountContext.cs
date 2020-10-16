using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Lab06.Models
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions options) : base(options) { }
        public DbSet<Account> Account { get; set; }
    }
}
