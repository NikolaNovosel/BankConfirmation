using BankConfirmation_DTO;
using BankConfirmation_IF;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BankConfirmation_DAL
{
    public class AccountDalAdo : IAccount
    {
        private readonly Connection connection = new();

        public List<Account> GetAll()
        {
            List<Account> listAccount = new List<Account>();

            using SqlConnection con = new(connection.connectionString);
            using SqlCommand cmd = new("GetAllAccount", con);
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
            using SqlConnection con = new(connection.connectionString);
            using SqlCommand cmd = new("GetByIdAccount", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            using SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    account.Id = reader.GetInt32("Id");
                    account.Number = reader.GetString("Number");
                    account.Balance = reader.GetDecimal("Balance");
                    account.AccountDateOpen = reader.GetDateTime("AccountDateOpen");
                    account.AccountType = reader.GetString("AccountType");
                    account.ClientId = reader.GetInt32("ClientId");
                }
            }
            con.Close();

            return account;
        }

        public void Insert(Account account)
        {
            using SqlConnection con = new(connection.connectionString);
            using SqlCommand cmd = new("InsertAccount", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Number", account.Number);
            cmd.Parameters.AddWithValue("Balance", account.Balance);
            cmd.Parameters.AddWithValue("AccountOpenDate", account.AccountDateOpen);
            cmd.Parameters.AddWithValue("AccountType", account.AccountType);
            cmd.Parameters.AddWithValue("ClientId", account.ClientId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Update(Account account)
        {
            using SqlConnection con = new(connection.connectionString);
            using SqlCommand cmd = new("UpdateAccount", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Id", account.Id);
            cmd.Parameters.AddWithValue("Number", account.Number);
            cmd.Parameters.AddWithValue("Balance", account.Balance);
            cmd.Parameters.AddWithValue("OpenDate", account.AccountDateOpen);
            cmd.Parameters.AddWithValue("Type", account.AccountType);
            cmd.Parameters.AddWithValue("ClientId", account.ClientId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Delete(int id)
        {
            using SqlConnection con = new(connection.connectionString);
            using SqlCommand cmd = new("DeleteAccount", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
