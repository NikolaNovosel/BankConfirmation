using BankConfirmation_DTO;
using BankConfirmation_IF;

namespace BankConfirmation_UI_MVC.REST
{
    internal class ClientRest : ServiceRest<Client>, IClient
    {
        public void Delete(int id)
        {
            DeleteT(id, "client");
        }

        public List<Client> GetAll()
        {
            return GetListT("client");
        }

        public Client GetById(int id)
        {
            return GetT(id, "client");
        }

        public void Update(Client client)
        {
            PutT(client,"client");
        }

        public void Insert(Client client)
        {
            PostT(client,"client");
        }
    }
}
