﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Lab05.Models
{
    public class PaymentContext : DbContext
    {
        public PaymentContext(DbContextOptions options) : base(options) { }
        public DbSet<Payment> Payment { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
