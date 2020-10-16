using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework3.Models
{
    [Table("Items")]
    public class Items
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ItemCode { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public int Price { get; set; }
        public string Image { get; set; }
    }
}
