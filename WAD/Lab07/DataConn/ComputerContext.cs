using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab07.DataConn
{
    public class ComputerContext : DbContext
    {
        public ComputerContext(DbContextOptions options) : base(options) { }
        public DbSet<Models.Computer> Computers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //nếu kết nối trong Startup thì không dùng cái này nữa
            //string strCon = "server=.;database=Project1DB;uid=sa;pwd=123";
            //optionsBuilder.UseSqlServer(strCon);
        }
    }
}
