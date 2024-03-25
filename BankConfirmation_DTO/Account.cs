using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Xml.Serialization;

namespace BankConfirmation_DTO
{
    public class Account
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public decimal Balance { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyy-mm-dd}", ApplyFormatInEditMode =true)]
        public DateTime AccountDateOpen { get; set; }
        public string AccountType { get; set; }
        public int ClientId { get; set; }
        [XmlIgnore]
        public Client Client { get; set; }
        public void GetXml()
        {
            using var stream = new FileStream("xmlAccount", FileMode.Create);
            var xml = new XmlSerializer(typeof(Account));
            xml.Serialize(stream,this);
        }
    }
}
