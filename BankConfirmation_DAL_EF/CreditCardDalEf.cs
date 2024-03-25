using BankConfirmation_DTO;
using BankConfirmation_IF;
using Microsoft.EntityFrameworkCore;

namespace BankConfirmation_DAL_EF
{
    public class CreditCardDalEf : BankConfirmationContext, ICreditCard
    {
        public void Delete(int id)
        {
            var result = CreditCard.First(i => i.Id == id);
            CreditCard.Remove(result);
            SaveChanges();
        }

        public List<CreditCard> GetAll() => [.. CreditCard.Include(i=>i.Client)];

        public CreditCard GetById(int id) => CreditCard.Include(i=>i.Client).First(i => i.Id == id);

        public void Insert(CreditCard creditCard)
        {
            CreditCard.Add(creditCard);
            SaveChanges();
        }

        public void Update(CreditCard creditCard)
        {
            CreditCard.Update(creditCard);
            SaveChanges();
        }
    }
}
