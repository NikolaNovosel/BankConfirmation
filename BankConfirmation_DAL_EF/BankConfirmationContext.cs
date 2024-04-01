using Microsoft.EntityFrameworkCore;
using BankConfirmation_DTO;

namespace BankConfirmation_DAL_EF
{
    public class BankConfirmationContext : DbContext
    {
        private readonly Connection connection = new ();
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(connection.connectionString);
        }
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AccountClosed> AccountClosed { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Credit> Credit { get; set; }
        public virtual DbSet<CreditCard> CreditCard { get; set; }
        public virtual DbSet<CreditClosed> CreditClosed { get; set; }
        public virtual DbSet<Deposit> Deposit { get; set; }
        public virtual DbSet<Overdraft> Overdraft { get; set; }
        public virtual DbSet<PaymentAccount> PaymentAccount { get; set; }
        public virtual DbSet<PaymentCreditCard> PaymentCreditCard { get; set; }
    }
}
