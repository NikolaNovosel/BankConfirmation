using BankConfirmation_BLL;
using BankConfirmation_DTO;
using BankConfirmation_IF;
namespace BankConfirmations_BLL
{
    public class CreditBll
    {
        public static List<Credit> GetAll()
        {
            ICredit creditDal = Factory.GetCredit();
            return creditDal.GetAll();
        }
        public static Credit GetById(int id)
        {
            ICredit creditDal = Factory.GetCredit();
            return creditDal.GetById(id);
        }
        public static void Insert(Credit credit)
        {
            ICredit creditDal = Factory.GetCredit();
            creditDal.Insert(credit);
        }
        public static void Update(Credit credit)
        {
            ICredit creditDal = Factory.GetCredit();
            creditDal.Update(credit);
        }
        public static void Delete(int id)
        {
            ICredit creditDal = Factory.GetCredit();
            creditDal.Delete(id);
        }
    }
}
