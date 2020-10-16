using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab09.Models;

namespace Lab09.DataConnect
{
    public class PatientContext : DbContext
    {
        public PatientContext(DbContextOptions options) : base(options) { }
        public DbSet<Patient> Patient { get; set; }
    }
}
