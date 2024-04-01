using BankConfirmation_BLL;
using BankConfirmation_DTO;
using BankConfirmation_IF;
namespace BankConfirmations_BLL
{
    public class CreditCardBll
    {
        public List<CreditCard> GetAll()
        {
            ICreditCard creditCardDal = Factory.GetCreditCard(DalType.ef);
            return creditCardDal.GetAll();
        }
        public CreditCard GetById(int id)
        {
            ICreditCard creditCardDal = Factory.GetCreditCard(DalType.ef);
            return creditCardDal.GetById(id);
        }
        public void Insert(CreditCard creditCard)
        {
            ICreditCard creditCardDal = Factory.GetCreditCard(DalType.ef);
            creditCardDal.Insert(creditCard);
        }
        public void Update(CreditCard creditCard)
        {
            ICreditCard creditCardDal = Factory.GetCreditCard(DalType.ef);
            creditCardDal.Update(creditCard);
        }
        public void Delete(int id)
        {
            ICreditCard creditCardDal = Factory.GetCreditCard(DalType.ef);
            creditCardDal.Delete(id);
        }
    }
}
