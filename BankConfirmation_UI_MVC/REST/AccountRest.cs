using BankConfirmation_DTO;
using BankConfirmation_IF;

namespace BankConfirmation_UI_MVC.REST
{
    internal class AccountRest : ServiceRest<Account>, IAccount
    {
        public void Delete(int id)
        {
            DeleteT(id, "account");
        }

        public List<Account> GetAll()
        {
            return GetList("account");
        }

        public Account GetById(int id)
        {
            return GetT(id, "account");
        }

        public void Insert(Account account)
        {
            PutT(account, "account");
        }

        public void Update(Account account)
        {
            PostT(account, "account");
        }
    }
}
