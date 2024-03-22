using BankConfirmation_DTO;
namespace BankConfirmation_IF
{
    public interface IPaymentCreditCard
    {
        List<PaymentCreditCard> GetAll();
        PaymentCreditCard GetById(int id);
        void Insert(PaymentCreditCard paymentCreditCard);
        void Update(PaymentCreditCard paymentCreditCard);
        void Delete(int id);
    }
}
