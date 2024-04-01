using BankConfirmation_DTO;
using BankConfirmation_IF;
using System.Net.Http;
using System.Security.Policy;

namespace BankConfirmation_UI_MVC.REST
{
    internal class CreditRest : ServiceRest<Credit>, ICredit
    {
        public void Delete(int id)
        {
            DeleteT(id, "credit");
        }

        public List<Credit> GetAll()
        {
            return GetListT("credit");
        }

        public Credit GetById(int id)
        {
            return GetT(id, "credit");
        }

        public void Insert(Credit credit)
        {
            PostT(credit, "credit");
        }
        public void Update(Credit credit)
        {
            PutT(credit, "credit");
        }
    }
}
