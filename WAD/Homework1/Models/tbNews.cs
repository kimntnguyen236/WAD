using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Homework1.Models
{
    [Table("tbNews")]
    public class tbNews
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NewsId { get; set; }
        [Required]
        public string HeadLines { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string ContentOfNews { get; set; }
    }
}
