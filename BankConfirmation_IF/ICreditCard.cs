using BankConfirmation_DTO;
namespace BankConfirmation_IF
{
    public interface ICreditCard
    {
        List<CreditCard> GetAll();
        CreditCard GetById(int id);
        void Insert(CreditCard creditCard);
        void Update(CreditCard creditCard);
        void Delete(int id);
    }
}
