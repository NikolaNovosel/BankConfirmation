using System;

namespace BankConfirmation_DTO
{
    public class CreditClosed
    {
        public int Id { get; set; }
        public string CreditAgreement { get; set; }
        public string CreditNumber { get; set; }
        public string CreditPayment { get; set; }
        public DateOnly DateClosed { get; set; }
        public Client ClientId { get; set; }
    }
}

