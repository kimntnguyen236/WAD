using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Homework2.Models
{
    [Table("tbPeople")]
    public class tbPeople
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public bool Roles { get; set; }
        public double Balance { get; set; }
    }
}
