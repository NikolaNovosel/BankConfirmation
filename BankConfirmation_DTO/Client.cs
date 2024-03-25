
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Xml.Serialization;

namespace BankConfirmation_DTO
{
    public class Client
    {   

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClientIdNumber { get; set; }
        public string ClientAddress { get; set; }
        public string ClientCity { get; set; }
        public string ClientCountry { get; set; }
        public string EntryBranch { get; set; }
        public string EntryCity { get; set; }
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        public DateTime EntryDate { get; set; }
        [XmlIgnore]
        public ICollection<Account> Account { get; set; }
        [XmlIgnore]
        public ICollection<AccountClosed> AccountClosed { get; set; }
        [XmlIgnore]
        public ICollection<Credit> Credit { get; set; }
        [XmlIgnore]
        public ICollection<CreditCard> CreditCard { get; set; }
        [XmlIgnore]
        public ICollection<CreditClosed> CreditClosed { get; set; }
        [XmlIgnore]
        public ICollection<Deposit> Deposit { get; set; }
        public void GetXml()
        {
            using var stream = new FileStream("xmlClient",FileMode.Create);
            var xml = new XmlSerializer(typeof(Client));
            xml.Serialize(stream,this);
        }
    }
}
