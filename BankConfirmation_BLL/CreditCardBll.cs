using BankConfirmation_BLL;
using BankConfirmation_DTO;
using BankConfirmation_IF;
namespace BankConfirmations_BLL
{
    public class CreditCardBll
    {
        public static List<CreditCard> GetAll()
        {
            ICreditCard creditCardDal = Factory.GetCreditCard(DalType.ef);
            return creditCardDal.GetAll();
        }
        public static CreditCard GetById(int id)
        {
            ICreditCard creditCardDal = Factory.GetCreditCard(DalType.ef);
            return creditCardDal.GetById(id);
        }
        public static void Insert(CreditCard creditCard)
        {
            ICreditCard creditCardDal = Factory.GetCreditCard(DalType.ef);
            creditCardDal.Insert(creditCard);
        }
        public static void Update(CreditCard creditCard)
        {
            ICreditCard creditCardDal = Factory.GetCreditCard(DalType.ef);
            creditCardDal.Update(creditCard);
        }
        public static void Delete(int id)
        {
            ICreditCard creditCardDal = Factory.GetCreditCard(DalType.ef);
            creditCardDal.Delete(id);
        }
    }
}
