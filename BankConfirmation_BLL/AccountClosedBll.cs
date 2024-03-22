using BankConfirmation_DTO;
using BankConfirmation_IF;
namespace BankConfirmation_BLL
{
    public class AccountClosedBll
    {
        public static List<AccountClosed> GetAll()
        {
            IAccountClosed accountClosedDal = Factory.GetAccountClosed();
            return accountClosedDal.GetAll();
        }
        public static AccountClosed GetById(int id)
        {
            IAccountClosed accountClosedDal = Factory.GetAccountClosed();
            return accountClosedDal.GetById(id);
        }
        public static void Insert(AccountClosed accountClosed)
        {
            IAccountClosed accountClosedDal = Factory.GetAccountClosed();
            accountClosedDal.Insert(accountClosed);
        }
        public static void Update(AccountClosed accountClosed)
        {
            IAccountClosed accountClosedDal = Factory.GetAccountClosed();
            accountClosedDal.Update(accountClosed);
        }
        public static void Delete(int id)
        {
            IAccountClosed accountClosedDal = Factory.GetAccountClosed();
            accountClosedDal.Delete(id);
        }
    }
}
