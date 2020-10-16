using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Lab10.Models
{
    public class Programmer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ProgrammerCode { get; set; }
        [Required]
        public string ProgrammerName { get; set; }
        public int Id { get; set; }
        public decimal Salary { get; set; }
    }
}
