using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// ràng buộc
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Lab05.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("Ma thanh toan")] // đổi tên thanh tieng viet
        public string PaymentCode { get; set; }


        [Required(ErrorMessage = "Project Code is required...")]
        public string ProjectCode { get; set; }


        [Required(ErrorMessage = "Project Name is required...")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Project Name from 3 to 50 characters")]
        public string ProjectName { get; set; }


        [Required(ErrorMessage = "Budget is required...")]
        [Range(100000, 99999999, ErrorMessage = "Budget from $100,000 to $99,999,999")]
        public double? Budget { get; set; }


        [Required(ErrorMessage = "Fee is required...")]
        [Range(100000, 99999999, ErrorMessage = "Fee from $100,000 to $99,999,999")]
        public double? Fee { get; set; }

        public double? endbalance
        {
            get
            {
                return (Budget - Fee);
            }
        }
    }
}
