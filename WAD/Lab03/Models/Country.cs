namespace Lab03.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string CountryName { get; set; }

        public int? Population { get; set; }

        [StringLength(50)]
        public string Language { get; set; }

        [Column("Photo ")]
        [StringLength(350)]
        public string Photo_ { get; set; }
    }
}
