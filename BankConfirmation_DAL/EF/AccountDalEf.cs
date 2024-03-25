using BankConfirmation_DTO;
using BankConfirmation_IF;

namespace BankConfirmation_DAL
{
    public class AccountDalEf : BankConfirmationContext, IAccount
    {
        public void Delete(int id)
        {
            var result = Account.First(i => i.Id == id);
            Account.Remove(result);
            SaveChanges();
        }

        public List<Account> GetAll() => [.. Account];

        public Account GetById(int id) => Account.First(i => i.Id == id);

        public void Insert(Account account)
        {
            Account.Add(account);
            SaveChanges();
        }

        public void Update(Account account)
        {
            Account.Update(account);
            SaveChanges();
        }
    }
}
