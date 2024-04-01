using BankConfirmation_BLL;
using BankConfirmation_DTO;
using BankConfirmation_IF;
namespace BankConfirmations_BLL
{
    public class CreditBll
    {
        public List<Credit> GetAll()
        {
            ICredit creditDal = Factory.GetCredit(DalType.ef);
            return creditDal.GetAll();
        }
        public Credit GetById(int id)
        {
            ICredit creditDal = Factory.GetCredit(DalType.ef);
            return creditDal.GetById(id);
        }
        public void Insert(Credit credit)
        {
            ICredit creditDal = Factory.GetCredit(DalType.ef);
            creditDal.Insert(credit);
        }
        public void Update(Credit credit)
        {
            ICredit creditDal = Factory.GetCredit(DalType.ef);
            creditDal.Update(credit);
        }
        public void Delete(int id)
        {
            ICredit creditDal = Factory.GetCredit(DalType.ef);
            creditDal.Delete(id);
        }
    }
}
