using System;
using System.Collections.Generic;

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
        public DateTime EntryDate { get; set; }
        public ICollection<Account> Account { get; set; }
        public ICollection<AccountClosed> AccountClosed { get; set; }
        public ICollection<Credit> Credit { get; set; }
        public ICollection<CreditCard> CreditCard { get; set; }
        public ICollection<CreditClosed> CreditClosed { get; set; }
        public ICollection<Deposit> Deposit { get; set; }
    }
}
