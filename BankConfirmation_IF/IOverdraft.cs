using BankConfirmation_DTO;
namespace BankConfirmation_IF
{
    public interface IOverdraft
    {
        List<Overdraft> GetAll();
        Overdraft GetById(int id);
        void Insert(Overdraft overdraft);
        void Update(Overdraft overdraft);
        void Delete(int id);
    }
}
