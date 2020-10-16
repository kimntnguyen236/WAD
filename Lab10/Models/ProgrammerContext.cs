using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab10.Models;
namespace Lab10.Models
{
    public class ProgrammerContext : DbContext
    {
        public ProgrammerContext() : base() { }
        public ProgrammerContext(DbContextOptions options) : base(options) { }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Programmer> Programmer { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Lab10.Models.vSkillProgrammer> vSkillProgrammer { get; set; }
    }
}
