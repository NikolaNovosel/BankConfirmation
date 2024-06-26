﻿using BankConfirmation_DAL_EF;
using BankConfirmation_DTO;
using BankConfirmation_IF;
using BankConfirmations_DAL_ADO;
using Newtonsoft.Json;
using System.Text;
namespace BankConfirmation_BLL
{
    internal class Factory
    {
        internal static IAccount GetAccount(DalType type)
        {
            if (type == (DalType)Enum.Parse(typeof(DalType),entityFramework))
            {
                return new AccountDalEf();
            }
            if (type == (DalType)Enum.Parse(typeof(DalType), adoNet))
            {
                return new AccountDalAdo();
            }
            return null;
        }
        internal static IAccountClosed GetAccountClosed(DalType type)
        {
            if (type == (DalType)Enum.Parse(typeof(DalType), entityFramework))
            {
                return new AccountClosedDalEf();
            }
            if (type == (DalType)Enum.Parse(typeof(DalType), adoNet))
            {
                return new AccountClosedDalEf();
            }
            return null;
        }
        internal static IClient GetClient(DalType type)
        {
            if (type == (DalType)Enum.Parse(typeof(DalType), entityFramework))
            {
                return new ClientDalEf();
            }
            if (type == (DalType)Enum.Parse(typeof(DalType), adoNet))
            {
                return new ClientDalEf();
            }
            return null;
        }
        internal static ICredit GetCredit(DalType type)
        {
            if (type == (DalType)Enum.Parse(typeof(DalType), entityFramework))
            {
                return new CreditDalEf();
            }
            if (type == (DalType)Enum.Parse(typeof(DalType), adoNet))
            {
                return new CreditDalEf();
            }
            return null;
        }
        internal static ICreditCard GetCreditCard(DalType type)
        {
            if (type == (DalType)Enum.Parse(typeof(DalType), entityFramework))
            {
                return new CreditCardDalEf();
            }
            if (type == (DalType)Enum.Parse(typeof(DalType), adoNet))
            {
                return new CreditCardDalEf();
            }
            return null;
        }
        private static string GetPath()
        {
            string path = "appsettings.json";

            using FileStream fileStream = File.Open(path, FileMode.Open, FileAccess.Read);
            
            byte[] bt = new byte[1024];
            UTF8Encoding end = new(true);

            while (fileStream.Read(bt, 0, bt.Length) > 0)
            {
                 return end.GetString(bt);
            }
            
            return null;
        }
        private static dynamic json = JsonConvert.DeserializeObject(GetPath());
        private static readonly string entityFramework = (string)(json["Ef"]);
        private static readonly string adoNet = (string)(json["Ado"]);
    }

    internal enum DalType
    {
        ado,
        ef
    }
}
