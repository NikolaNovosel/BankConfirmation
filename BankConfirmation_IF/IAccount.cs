using BankConfirmation_DTO;
namespace BankConfirmation_IF
{
    public interface IAccount
    {
        List<Account> GetAll();
        Account GetById(int id);
        void Insert(Account account);
        void Update(Account account);
        void Delete(int id);
    }
}
