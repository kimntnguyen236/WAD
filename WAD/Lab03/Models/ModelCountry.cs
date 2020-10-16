namespace Lab03.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelCountry : DbContext
    {
        public ModelCountry()
            : base("name=ModelCountry")
        {
        }

        public virtual DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Photo_)
                .IsUnicode(false);
        }
    }
}
