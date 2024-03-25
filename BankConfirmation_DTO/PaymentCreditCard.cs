using System;

namespace BankConfirmation_DTO
{
    public class PaymentCreditCard
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateOnly DateCurrency { get; set; }
        public DateOnly DateEntry { get; set; }
        public string PaymentPurpose { get; set; }
        public Client ClientId { get; set; }
        public CreditCard CreditCardId { get; set; }
    }
}
