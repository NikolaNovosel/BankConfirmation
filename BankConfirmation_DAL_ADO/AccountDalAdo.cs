
using BankConfirmation_DTO;
using BankConfirmation_IF;
using System.Data;
using System.Data.SqlClient;

namespace BankConfirmations_DAL_ADO
{
    public class AccountDalAdo : IAccount
    {
        public string connection = "Server=DESKTOP-24B1SAP\\SQLEXPRESS; Database=BankConfirmation TrustedConnection=true; MultipleResultSets=true";

        public List<Account> GetAll()
        {
            List<Account> listAccount = new List<Account>();

            using SqlConnection con = new (connection);
            using SqlCommand cmd = new ("GetAllAccount", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            using SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Account account = new();
                    account.Id = reader.GetInt32("id");
                    account.Number = reader.GetString("number");
                    account.Balance = reader.GetDecimal("balance");
                    account.AccountDateOpen = reader.GetDateTime("open_date");
                    account.AccountType = reader.GetString("type");
                    listAccount.Add(account);
                }
            }
            con.Close();

            return listAccount;
        }

        public Account GetById(int id)
        {
            Account account = new();
            using SqlConnection con = new(connection);
            using SqlCommand cmd = new("GetByIdAccount", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            using SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    account.Id = reader.GetInt32("id");
                    account.Number = reader.GetString("number");
                    account.Balance = reader.GetDecimal("balance");
                    account.AccountDateOpen = reader.GetDateTime("account_open_date");
                    account.AccountType = reader.GetString("account_type");
                    account.ClientId = reader.GetInt32("client_id");
                }
            }
            con.Close();

            return account;
        }

        public void Insert(Account account)
        {
            using SqlConnection con = new(connection);
            using SqlCommand cmd = new("InsertAccount", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("number", account.Number);
            cmd.Parameters.AddWithValue("balance", account.Balance);
            cmd.Parameters.AddWithValue("account_open_date", account.AccountDateOpen);
            cmd.Parameters.AddWithValue("account_type", account.AccountType);
            cmd.Parameters.AddWithValue("client_id", account.ClientId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Update(Account account)
        {
            using SqlConnection con = new(connection);
            using SqlCommand cmd = new("UpdateAccount", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", account.Id);
            cmd.Parameters.AddWithValue("number", account.Number);
            cmd.Parameters.AddWithValue("balance", account.Balance);
            cmd.Parameters.AddWithValue("open_date", account.AccountDateOpen);
            cmd.Parameters.AddWithValue("type", account.AccountType);
            cmd.Parameters.AddWithValue("client_id", account.ClientId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Delete(int id)
        {
            using SqlConnection con = new(connection);
            using SqlCommand cmd = new("DeleteAccount", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
