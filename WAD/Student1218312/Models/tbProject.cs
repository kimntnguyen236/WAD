using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student1218312.Models
{
    [Table("tbProject")]
    public class tbProject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectCode { get; set; }
        [Required]
        public string ClientName { get; set; }
        [Required]
        public string ProjectName { get; set; }
        [Required]
        public DateTime? StartDate { get; set; }
        [Required]
        public DateTime? EndDate { get; set; }
        [Required]
        [Range(1000, maximum: int.MaxValue)]
        public decimal Cost { get; set; }

    }
}
