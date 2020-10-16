using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
namespace Core3.Models
{
    public class Computer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Computer Code")]
        public int ID { get; set; }
        [DisplayName("Computer Name")]
        [Required]
        public string NAME { get; set; }
        [StringLength(250, ErrorMessage = "Max is 250 character", MinimumLength = 2)]
        public string DESCRIPTION { get; set; }
        [Required]
        [Range(200, 5000)]
        [DataType(DataType.Currency)]
        public double PRICE { get; set; }
        public int Quantity { get; set; }
        public string PHOTO { get; set; }
    }
}
