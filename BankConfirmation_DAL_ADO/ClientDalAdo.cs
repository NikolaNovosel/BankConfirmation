using BankConfirmation_DTO;
using BankConfirmation_IF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConfirmation_DAL_ADO
{
    public class ClientDalAdo : Connection, IClient
    {
        public void Delete(int id)
        {
            using SqlConnection con = new(connectionString);
            using SqlCommand cmd = new SqlCommand("DeleteClient");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<Client> GetAll()
        {
            List<Client> listClient = new List<Client>();

            using SqlConnection con = new(connectionString);
            using SqlCommand cmd = new("GetAllClient",con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            using SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Client client = new();
                    client.Id = reader.GetInt32("@id");
                    client.FirstName = reader.GetString("@firstName");
                    client.LastName = reader.GetString("@lastName");
                    client.ClientIdNumber = reader.GetString("@clientIdNumber");
                    client.ClientAddress = reader.GetString("@clientAddress");
                    client.ClientCity = reader.GetString("@clientCity");
                    client.ClientCountry = reader.GetString("@clientCountry");
                    client.EntryCity = reader.GetString("@entryCity");
                    client.EntryBranch = reader.GetString("@entryBranch");
                    client.EntryDate = reader.GetDateTime("@entryDate");
                    listClient.Add(client);
                }
            }
            con.Close();
            
            return listClient;
        }

        public Client GetById(int id)
        {
            Client client = new();
            
            using SqlConnection con = new(connectionString);
            using SqlCommand cmd = new("GetByIdClient");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    client.Id = reader.GetInt32("@id");
                    client.FirstName = reader.GetString("@firstName");
                    client.LastName = reader.GetString("@lastName");
                    client.ClientIdNumber = reader.GetString("@clientIdNumber");
                    client.ClientAddress = reader.GetString("@clientAddress");
                    client.ClientCity = reader.GetString("@clientCity");
                    client.ClientCountry = reader.GetString("@clientCountry");
                    client.EntryCity = reader.GetString("@entryCity");
                    client.EntryBranch = reader.GetString("@entryBranch");
                    client.EntryDate = reader.GetDateTime("@entryDate");
                }
            }
            con.Close();

            return client;
        }

        public void Insert(Client client)
        {
            SqlConnection con = new(connectionString);
            SqlCommand cmd = new("InsertClient");
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            cmd.Parameters.AddWithValue("@firstName", client.FirstName);
            cmd.Parameters.AddWithValue("@lastName", client.LastName);
            cmd.Parameters.AddWithValue("@clientIdNumber", client.ClientIdNumber);
            cmd.Parameters.AddWithValue("@clientAddress", client.ClientAddress);
            cmd.Parameters.AddWithValue("@clientCity", client.ClientCity);
            cmd.Parameters.AddWithValue("@clientCountry", client.ClientCountry);
            cmd.Parameters.AddWithValue("@entryBranch", client.EntryBranch);
            cmd.Parameters.AddWithValue("@entryDate", client.EntryDate);
            cmd.Parameters.AddWithValue("@entryCity", client.EntryCity);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Update(Client client)
        {
            SqlConnection con = new(connectionString);
            SqlCommand cmd = new("UpdateClient");
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            cmd.Parameters.AddWithValue("@id", client.Id);
            cmd.Parameters.AddWithValue("@firstName", client.FirstName);
            cmd.Parameters.AddWithValue("@lastName", client.LastName);
            cmd.Parameters.AddWithValue("@clientIdNumber", client.ClientIdNumber);
            cmd.Parameters.AddWithValue("@clientAddress", client.ClientAddress);
            cmd.Parameters.AddWithValue("@clientCity", client.ClientCity);
            cmd.Parameters.AddWithValue("@clientCountry", client.ClientCountry);
            cmd.Parameters.AddWithValue("@entryBranch", client.EntryBranch);
            cmd.Parameters.AddWithValue("@entryDate", client.EntryDate);
            cmd.Parameters.AddWithValue("@entryCity", client.EntryCity);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
