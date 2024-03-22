using BankConfirmation_DTO;
namespace BankConfirmation_IF
{
    public interface ICreditClosed
    {
        List<CreditClosed> GetAll();
        CreditClosed GetById(int id);
        void Insert(CreditClosed creditClosed);
        void Update(CreditClosed creditClosed);
        void Delete(int id);
    }
}
