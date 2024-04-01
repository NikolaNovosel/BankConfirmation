using BankConfirmation_BLL;
using BankConfirmation_DTO;
using BankConfirmation_IF;
namespace BankConfirmations_BLL
{
    public class ClientBll
    {
        public List<Client> GetAll()
        {
            IClient clientDal = Factory.GetClient(DalType.ef);
            return clientDal.GetAll();
        }
        public Client GetById(int id)
        {
            IClient clientDal = Factory.GetClient(DalType.ef);
            return clientDal.GetById(id);
        }
        public void Insert(Client client)
        {
            IClient clientDal = Factory.GetClient(DalType.ef);
            clientDal.Insert(client);
        }
        public void Update(Client client)
        {
            IClient clientDal = Factory.GetClient(DalType.ef);
            clientDal.Update(client);
        }
        public void Delete(int id)
        {
            IClient clientDal = Factory.GetClient(DalType.ef);
            clientDal.Delete(id);
        }
    }
}
