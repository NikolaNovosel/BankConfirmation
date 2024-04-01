using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace BankConfirmation_DTO
{
    public class Client
    {   
        public int Id { get; set; }
        [Required]
        [Display(Name ="First Name")]
        [StringLength(20, ErrorMessage = "Maximum entry characters: 20")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(20, ErrorMessage = "Maximum entry characters: 20")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Client Id Number")]
        [StringLength(13, ErrorMessage ="Id Number must be exactly of 13 char", MinimumLength =13)]
        public string ClientIdNumber { get; set; }
        [Required]
        [Display(Name = "Client Address")]
        [StringLength(35, ErrorMessage = "Maximum entry characters: 35")]
        public string ClientAddress { get; set; }
        [Required]
        [Display(Name = "Client City")]
        [StringLength(25, ErrorMessage = "Maximum entry characters: 25")]
        public string ClientCity { get; set; }
        [Required]
        [Display(Name = "Client Country")]
        [StringLength(25, ErrorMessage = "Maximum entry characters: 25")]
        public string ClientCountry { get; set; }
        [Required]
        [Display(Name ="Entry Branch")]
        [StringLength(20, ErrorMessage = "Maximum entry characters: 20")]
        public string EntryBranch { get; set; }
        [Required]
        [Display(Name ="Entry City")]
        [StringLength(35, ErrorMessage = "Maximum entry characters: 35")]
        public string EntryCity { get; set; }
        [Required]
        [Display(Name = "Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }
        [JsonIgnore]
        public ICollection<Account> Account { get; set; }
        [JsonIgnore]
        public ICollection<AccountClosed> AccountClosed { get; set; }
        [JsonIgnore]
        public ICollection<Credit> Credit { get; set; }
        [JsonIgnore]
        public ICollection<CreditCard> CreditCard { get; set; }
        [JsonIgnore]
        public ICollection<CreditClosed> CreditClosed { get; set; }
        [JsonIgnore]
        public ICollection<Deposit> Deposit { get; set; }
    }
}
