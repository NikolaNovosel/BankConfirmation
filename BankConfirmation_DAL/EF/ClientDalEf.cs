using BankConfirmation_DTO;
using BankConfirmation_IF;

namespace BankConfirmation_DAL
{
    public class ClientDalEf : BankConfirmationContext, IClient
    {
        public void Delete(int id)
        {
            var result = Client.First(i => i.Id == id);
            Client.Remove(result);
            SaveChanges();
        }

        public List<Client> GetAll() => [.. Client];

        public Client GetById(int id) => Client.First(i => i.Id == id);

        public void Insert(Client client)
        {
            Client.Add(client);
            SaveChanges();
        }

        public void Update(Client client)
        {
            Client.Update(client);
            SaveChanges();
        }
    }
}
