using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Lab06.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string AccountCode { get; set; }

        [Required]
        public string AccountName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string PinCode { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [DataType(DataType.Currency)]
        public double Balance { get; set; }
        public bool IsAdmin { get; set; }
    }
}
