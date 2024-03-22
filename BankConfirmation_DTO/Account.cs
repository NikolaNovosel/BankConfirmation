using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankConfirmation_DTO
{
    public class Account
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public decimal Balance { get; set; }
        public DateTime AccountDateOpen { get; set; }
        public string AccountType { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
