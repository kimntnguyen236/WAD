using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab08.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CustomerCode { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 2)]
        public string CustomerAddress { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
