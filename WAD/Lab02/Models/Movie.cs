using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab02.Models
{
    public class Movie
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string MovieName { get; set; }
        [Required]
        [StringLength(25,MinimumLength =3, ErrorMessage = "Movie name from 3 to 25 characters! ")]
        public string Genre { get; set; }
        [Required]
        public string Director { get; set; }
    }
}