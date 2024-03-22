using BankConfirmation_DTO;
namespace BankConfirmation_IF
{
    public interface IDeposit
    {
        List<Deposit> GetAll();
        Deposit GetById(int id);
        void Insert(Deposit deposit);
        void Update(Deposit deposit);
        void Delete(int id);
    }
}
