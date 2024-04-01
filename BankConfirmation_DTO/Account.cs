using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace BankConfirmation_DTO
{
    public class Account
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10,ErrorMessage = "Number must be exactly of 10 characters", MinimumLength =10)]
        public string Number { get; set; }
        [Required]
        [Range(0,1000000,ErrorMessage ="Maximum entry amount: 1000000")]
        public decimal Balance { get; set; }
        [Required]
        [Display(Name ="Date Open")]
        [DataType(DataType.Date)]
        public DateTime AccountDateOpen { get; set; }
        [Required]
        [Display(Name = "Type")]
        [StringLength(10, ErrorMessage = "Number must be exactly of 10 characters")]
        public string AccountType { get; set; }
        [Required]
        [Display(Name = "Client Id")]
        public int ClientId { get; set; }
        [XmlIgnore]
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        public void GetXml()
        {
            using var stream = new FileStream("xmlAccount", FileMode.Create);
            var xml = new XmlSerializer(typeof(Account));
            xml.Serialize(stream,this);
        }
    }
}
