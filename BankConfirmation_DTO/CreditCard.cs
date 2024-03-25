namespace BankConfirmation_DTO
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int Limit { get; set; }
        public decimal DebtCurrent { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}

