using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.Models
{
    public class PaymentData
    {
        [Key]
        public int PaymentDetailId { get; set; }

        [Required]
        [StringLength(50)]
        public string CardOwnerName { get; set; }

        [Required]
        [DataType(DataType.CreditCard)] 
        public string CardNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ExpirationDate { get; set; }

        [Required]
        [StringLength(3)]
        [RegularExpression(@"^\d{3}$")]
        public string SecurityCode { get; set; }
    }
}
