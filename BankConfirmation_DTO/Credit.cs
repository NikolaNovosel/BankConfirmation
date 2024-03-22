namespace BankConfirmation_DTO
{
    public class Credit
    {
        public int Id { get; set; }
        public string CreditAgreement { get; set; }
        public string CreditNumber { get; set; }
        public string CreditPayment { get; set; }
        public decimal DebtCurrent { get; set; }
        public decimal FeeCurrent { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
