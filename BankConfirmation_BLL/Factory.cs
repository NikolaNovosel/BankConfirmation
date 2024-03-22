using BankConfirmation_DAL_EF;
using BankConfirmation_IF;
namespace BankConfirmation_BLL
{
    internal class Factory
    {
        internal static IAccount GetAccount()
        {
            return new AccountDalEf();
        }
        internal static IAccountClosed GetAccountClosed()
        {
            return new AccountClosedDalEf();
        }
        internal static IClient GetClient()
        {
            return new ClientDalEf();
        }
        internal static ICredit GetCredit()
        {
            return new CreditDalEf();
        }
        internal static ICreditCard GetCreditCard()
        {
            return new CreditCardDalEf();
        }
    }

    internal enum DAL
    {
        ado,
        ef
    }
}
