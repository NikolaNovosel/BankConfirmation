using BankConfirmation_DTO;
using BankConfirmation_IF;
using Microsoft.EntityFrameworkCore;

namespace BankConfirmation_DAL_EF
{
    public class CreditDalEf : BankConfirmationContext, ICredit
    {
        public void Delete(int id)
        {
            var result = Credit.First(i => i.Id == id);
            Credit.Remove(result);
            SaveChanges();
        }

        public List<Credit> GetAll() => [.. Credit.Include(i=>i.Client)];

        public Credit GetById(int id) => Credit.Include(i=>i.Client).First(i => i.Id == id);

        public void Insert(Credit credit)
        {
            Credit.Add(credit);
            SaveChanges();
        }

        public void Update(Credit credit)
        {
            Credit.Update(credit);
            SaveChanges();
        }
    }
}
