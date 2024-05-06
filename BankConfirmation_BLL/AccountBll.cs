using BankConfirmation_BLL;
using BankConfirmation_DTO;
using BankConfirmation_IF;
namespace BankConfirmations_BLL
{
    public class AccountBll
    {
        public List<Account> GetAll()
        {
            IAccount accountDal = Factory.GetAccount(DalType.ado);
            return accountDal.GetAll();
        }
        public Account GetById(int id)
        {
            IAccount accountDal = Factory.GetAccount(DalType.ado);
            return accountDal.GetById(id);
        }
        public void Insert(Account account)
        {
            IAccount accountDal = Factory.GetAccount(DalType.ado);
            accountDal.Insert(account);
        }
        public void Update(Account account)
        {
            IAccount accountDal = Factory.GetAccount(DalType.ado);
            accountDal.Update(account);
        }
        public void Delete(int id)
        {
            IAccount accountDal = Factory.GetAccount(DalType.ado);
            accountDal.Delete(id);
        }
    }
}
