using BankConfirmation_DTO;
namespace BankConfirmation_IF
{
    public interface IAccountClosed
    {
        List<AccountClosed> GetAll();
        AccountClosed GetById(int id);
        void Insert(AccountClosed accountClosed);
        void Update(AccountClosed accountClosed);
        void Delete(int id);
    }
}
