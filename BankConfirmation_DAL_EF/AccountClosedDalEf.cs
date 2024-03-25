using BankConfirmation_DTO;
using BankConfirmation_IF;
using Microsoft.EntityFrameworkCore;

namespace BankConfirmation_DAL_EF
{
    public class AccountClosedDalEf : BankConfirmationContext, IAccountClosed
    {
        public void Delete(int id)
        {
            var result = AccountClosed.First(i=>i.Id==id);
            AccountClosed.Remove(result);
            SaveChanges();
        }

        public List<AccountClosed> GetAll() => [.. AccountClosed.Include(i => i.Client)];

        public AccountClosed GetById(int id) => AccountClosed.Include(i=>i.Client).First(i=>i.Id==id);

        public void Insert(AccountClosed accountClosed)
        {
            AccountClosed.Add(accountClosed);
            SaveChanges();
        }

        public void Update(AccountClosed accountClosed)
        {
            AccountClosed.Update(accountClosed);
            SaveChanges();
        }
    }
}
