namespace BankConfirmation_DTO
{
    public class Deposit
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public decimal Amount { get; set; }
        public decimal Interest { get; set; }
        public string DepositType { get; set; }
        public string Currency { get; set; }
        public Client ClientId { get; set; }
    }
}

