using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concretes.EntityFreamwork
{
    public class AccountBookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=AccountBook;Trusted_Connection=true");
        }

        public DbSet<Safe> safes { get; set; } 
        public DbSet<Bank> banks { get; set; }
        public DbSet<BankBalance> bankBalances { get; set; }
        public DbSet<CollectionPayments> collectionpayments { get; set; }
        public DbSet<TransactionType> transactionTypes { get; set; }
        public DbSet<SafeBalance> safebalances { get; set; }
        public DbSet<Currency> currencies { get; set; }

    }
}
