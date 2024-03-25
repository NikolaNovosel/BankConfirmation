
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Xml.Serialization;

namespace BankConfirmation_DTO
{
    public class AccountClosed
    {
        public int Id { get; set; }
        public string Number { get; set; }
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        public DateTime AccountDateOpen { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AccountDateClosed { get; set; }
        public string AccountType { get; set; }
        public int ClientId { get; set; }
        [XmlIgnore]
        public Client Client { get; set; }
        public void GetXml()
        {
            using var stream = new FileStream("xmlAccountClosed",FileMode.Create);
            var xml = new XmlSerializer(typeof(AccountClosed));
            xml.Serialize(stream,this);
        }
    }
}
