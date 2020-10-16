using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Lab07.Models
{
    [Table("Computer")]
    public class Computer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Computer ID")]
        public int Id { get; set; }

        [DisplayName("Computer Name")]
        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Description from 5 to 100 characters!")]
        public string Description { get; set; }
        [Required]
        [Range(200, 5000)]
        [DataType(DataType.Currency)] // dấu $
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Photo { get; set; }
    }
}
