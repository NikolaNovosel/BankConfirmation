using BankConfirmation_BLL;
using BankConfirmation_DTO;
using BankConfirmation_IF;
namespace BankConfirmations_BLL
{
    public class ClientBll
    {
        public static List<Client> GetAll()
        {
            IClient clientDal = Factory.GetClient();
            return clientDal.GetAll();
        }
        public static Client GetById(int id)
        {
            IClient clientDal = Factory.GetClient();
            return clientDal.GetById(id);
        }
        public static void Insert(Client client)
        {
            IClient clientDal = Factory.GetClient();
            clientDal.Insert(client);
        }
        public static void Update(Client client)
        {
            IClient clientDal = Factory.GetClient();
            clientDal.Update(client);
        }
        public static void Delete(int id)
        {
            IClient clientDal = Factory.GetClient();
            clientDal.Delete(id);
        }
    }
}
