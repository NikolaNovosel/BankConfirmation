using System;

namespace BankConfirmation_DTO
{
    public class Overdraft
    {
        public int Id { get; set; }
        public int Limit { get; set; }
        public decimal DebtCurrent { get; set; }
        public DateOnly DateOpen { get; set; }
        public DateOnly DateClosed { get; set; }
        public Account AccountId { get; set; }
    }
}
