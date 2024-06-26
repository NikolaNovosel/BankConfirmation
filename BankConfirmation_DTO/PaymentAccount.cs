﻿using System;

namespace BankConfirmation_DTO
{
    public class PaymentAccount
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateCurrency { get; set; }
        public DateTime DateEntry { get; set; }
        public string PaymentCurrency { get; set; }
        public string PaymentPurpose { get; set; }
        public Client ClientId { get; set; }
        public Account AccountId { get; set; }
    }
}
