using BankConfirmation_BLL;
using BankConfirmation_DTO;
using BankConfirmation_IF;
namespace BankConfirmations_BLL
{
    public class AccountBll
    {
        public static List<Account> GetAll()
        {
            IAccount accountDal = Factory.GetAccount();
            return accountDal.GetAll();
        }
        public static Account GetById(int id)
        {
            IAccount accountDal = Factory.GetAccount();
            return accountDal.GetById(id);
        }
        public static void Insert(Account account)
        {
            IAccount accountDal = Factory.GetAccount();
            accountDal.Insert(account);
        }
        public static void Update(Account account)
        {
            IAccount accountDal = Factory.GetAccount();
            accountDal.Update(account);
        }
        public static void Delete(int id)
        {
            IAccount accountDal = Factory.GetAccount();
            accountDal.Delete(id);
        }
    }
}
