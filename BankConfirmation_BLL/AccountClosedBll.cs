using BankConfirmation_DTO;
using BankConfirmation_IF;
namespace BankConfirmation_BLL
{
    public class AccountClosedBll
    {
        public List<AccountClosed> GetAll()
        {
            IAccountClosed accountClosedDal = Factory.GetAccountClosed(DalType.ef);
            return accountClosedDal.GetAll();
        }
        public AccountClosed GetById(int id)
        {
            IAccountClosed accountClosedDal = Factory.GetAccountClosed(DalType.ef);
            return accountClosedDal.GetById(id);
        }
        public void Insert(AccountClosed accountClosed)
        {
            IAccountClosed accountClosedDal = Factory.GetAccountClosed(DalType.ef);
            accountClosedDal.Insert(accountClosed);
        }
        public void Update(AccountClosed accountClosed)
        {
            IAccountClosed accountClosedDal = Factory.GetAccountClosed(DalType.ef);
            accountClosedDal.Update(accountClosed);
        }
        public void Delete(int id)
        {
            IAccountClosed accountClosedDal = Factory.GetAccountClosed(DalType.ef);
            accountClosedDal.Delete(id);
        }
    }
}
