using BankConfirmation_DTO;
namespace BankConfirmation_IF
{
    public interface IPaymentAccount
    {
        List<PaymentAccount> GetAll();
        PaymentAccount GetById(int id);
        void Insert(PaymentAccount paymentAccount);
        void Update(PaymentAccount paymentAccount);
        void Delete(int id);
    }
}
