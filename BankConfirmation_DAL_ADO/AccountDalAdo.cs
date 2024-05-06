
using BankConfirmation_DAL_ADO;
using BankConfirmation_DTO;
using BankConfirmation_IF;
using System.Data;
using System.Data.SqlClient;

namespace BankConfirmations_DAL_ADO
{
    public class AccountDalAdo : Connection,  IAccount
    {
        public List<Account> GetAll()
        {
            List<Account> listAccount = new List<Account>();

            using SqlConnection con = new (connectionString);
            using SqlCommand cmd = new ("GetAllAccount", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            using SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Account account = new();
                    account.Id = reader.GetInt32("Id");
                    account.Number = reader.GetString("Number");
                    account.Balance = reader.GetDecimal("Balance");
                    account.AccountDateOpen = reader.GetDateTime("AccountDateOpen");
                    account.AccountType = reader.GetString("AccountType");
                    listAccount.Add(account);
                }
            }
            con.Close();

            return listAccount;
        }

        public Account GetById(int id)
        {
            Account account = new();
            using SqlConnection con = new(connectionString);
            using SqlCommand cmd = new("GetByIdAccount", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            using SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    account.Number = reader.GetString("Number");
                    account.Balance = reader.GetDecimal("Balance");
                    account.AccountDateOpen = reader.GetDateTime("AccountDateOpen");
                    account.AccountType = reader.GetString("AccountType");
                    account.ClientId = reader.GetInt32("ClientId");
                    account.Client = new ();
                    account.Client.FirstName = reader.GetString("FirstName");
                    account.Client.LastName = reader.GetString("LastName");
                    account.Client.ClientIdNumber = reader.GetString("ClientIdNumber");
                    account.Client.ClientCity = reader.GetString("ClientCity");
                    account.Client.ClientAddress = reader.GetString("ClientAddress");
                    account.Client.ClientCountry = reader.GetString("ClientCountry");
                }
            }
            con.Close();

            return account;
        }

        public void Insert(Account account)
        {
            using SqlConnection con = new(connectionString);
            using SqlCommand cmd = new("InsertAccount", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@number", account.Number);
            cmd.Parameters.AddWithValue("@balance", account.Balance);
            cmd.Parameters.AddWithValue("@accountDateOpen", account.AccountDateOpen);
            cmd.Parameters.AddWithValue("@accountType", account.AccountType);
            cmd.Parameters.AddWithValue("@clientId", account.ClientId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Update(Account account)
        {
            using SqlConnection con = new(connectionString);
            using SqlCommand cmd = new("UpdateAccount", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", account.Id);
            cmd.Parameters.AddWithValue("@number", account.Number);
            cmd.Parameters.AddWithValue("@balance", account.Balance);
            cmd.Parameters.AddWithValue("@accountDateOpen", account.AccountDateOpen);
            cmd.Parameters.AddWithValue("@accountType", account.AccountType);
            cmd.Parameters.AddWithValue("@clientId", account.ClientId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Delete(int id)
        {
            using SqlConnection con = new(connectionString);
            using SqlCommand cmd = new("DeleteAccount", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
