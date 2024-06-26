﻿using BankConfirmation_DTO;
using BankConfirmation_IF;
using Microsoft.EntityFrameworkCore;

namespace BankConfirmation_DAL_EF
{
    public class AccountDalEf : BankConfirmationContext, IAccount
    {
        public void Delete(int id)
        {
            var result = Account.Find(id);
            Account.Remove(result);
            SaveChanges();
        }
        public List<Account> GetAll() => [..Account];
        public Account GetById(int id) => Account.Include(i=>i.Client).First(i=>i.Id==id);

        public void Insert(Account account)
        {
            Account.Add(account);
            SaveChanges();
        }

        public void Update(Account account)
        {
            Account.Update(account);
            SaveChanges();
        }
    }
}
