using System;

namespace BankConfirmation_DTO
{
    public class Overdraft
    {
        public int Id { get; set; }
        public int Limit { get; set; }
        public decimal DebtCurrent { get; set; }
        public DateTime DateOpen { get; set; }
        public DateTime DateClosed { get; set; }
        public Account AccountId { get; set; }
    }
}
