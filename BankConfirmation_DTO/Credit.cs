using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace BankConfirmation_DTO
{
    public class Credit
    {
        public int Id { get; set; }
        [Required]
        [StringLength(11,ErrorMessage ="Agreement number must be exatly of 11 char", MinimumLength =11)]
        [Display(Name ="Aggrement Number")]
        public string AgreementNumber { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Credit number must be exatly of 10 char", MinimumLength =10)]
        [Display(Name = "Client Number")]
        public string CreditNumber { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Payment number must be exatly of 10 char", MinimumLength =10)]
        [Display(Name = "Payment Number")]
        public string PaymentNumber { get; set; }
        [Required]
        [Range(1000,30000000,ErrorMessage ="Range amount entry between: 1k-30m")]
        [Display(Name = "Debt Current")]
        public decimal DebtCurrent { get; set; }
        [Required]
        [Range(0,30000, ErrorMessage = "Maximum entry amount: 30k")]
        [Display(Name = "Fee Current")]
        public decimal FeeCurrent { get; set; }
        [Required]
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
    }
}
