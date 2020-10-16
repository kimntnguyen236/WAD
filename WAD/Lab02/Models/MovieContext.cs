using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace Lab02.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("MovieConn") { }

        public DbSet<Movie> movies { get; set; }
    }
}