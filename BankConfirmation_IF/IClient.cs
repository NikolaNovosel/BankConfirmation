using BankConfirmation_DTO;
namespace BankConfirmation_IF
{
    public interface IClient
    {
        List<Client> GetAll();
        Client GetById(int id);
        void Insert(Client client);
        void Update(Client client);
        void Delete(int id);
    }
}
