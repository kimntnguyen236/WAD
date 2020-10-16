using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Lab5.Models
{
    [Table("Payment")]// ten bang trong csdl
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [DisplayName("Ma Thanh Toan")] // Doi ten hien thi cua cai PaymentCode ben duoi
        public string PaymentCode { get; set; }

        [Required(ErrorMessage ="Project code is required...")]
        public string ProjectCode { get; set; }

        [Required(ErrorMessage = "Project name is required...")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="project name from 3 to 50 characters.")]
        public string ProjectName { get; set; }
       
        [Required(ErrorMessage ="Budget is required...")]
        [Range(100000,99999999,ErrorMessage ="Budget from $100000 to $99999999")]
        public double? Budget { get; set; }

        [Required(ErrorMessage = "Fee is required...")]
        [Range(100000, 99999999, ErrorMessage = "Fee from $100000 to $99999999")]
        public double? Fee { get; set; }

        public double? EndBalance
        {
            get
            {
                return (Budget - Fee);

            }
        }

    }
}
