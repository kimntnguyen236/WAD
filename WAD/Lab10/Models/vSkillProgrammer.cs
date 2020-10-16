using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab10.Models
{
    public class vSkillProgrammer
    {
        [Key]
        public string ProgrammerCode { get; set; }
        [Required]
        public string ProgrammerName { get; set; }
        public int Id { get; set; }
        public decimal Salary { get; set; }
        [Required]
        [StringLength(50)]
        public string SkillName { get; set; }
    }
}
