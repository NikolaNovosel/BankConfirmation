using System;

namespace BankConfirmation_DTO
{
    public class AccountClosed
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime AccountDateOpen { get; set; }
        public DateTime AccountDateClosed { get; set; }
        public string AccountType { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
