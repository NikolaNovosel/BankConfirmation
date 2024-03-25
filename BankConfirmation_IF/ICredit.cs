using BankConfirmation_DTO;
namespace BankConfirmation_IF
{
    public interface ICredit
    {
        List<Credit> GetAll();
        Credit GetById(int id);
        void Insert(Credit credit);
        void Update(Credit credit);
        void Delete(int id);
    }
}
