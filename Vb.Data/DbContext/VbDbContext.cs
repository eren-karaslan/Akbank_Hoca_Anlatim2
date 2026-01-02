using Microsoft.EntityFrameworkCore;
using Vb.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vb.Data;


public class VbDbContext : DbContext
{
    
    public VbDbContext(DbContextOptions<VbDbContext> options) : base(options)
    {
        //Bura genelde boş olur, genelde tek amaç Startup.cs'de connection_string tanımlanmasına yarar
    }
    /*
    //Buraya DbSet'ler eklenecek (yani veritabanındaki tablolar)
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<AccountTransaction> AccountTransactions { get; set; }
    public DbSet<EftTransaction> EftTransactions { get; set; }
    public DbSet<MoneyTransferTransaction> MoneyTransferTransactions { get; set; }
    */
    /*
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Buraya Configuration'lar eklenecek (yani tablolarının, kolonlarının, ilişkilerinin detaylı ayarları)
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new AddressConfiguration());
        modelBuilder.ApplyConfiguration(new ContactConfiguration());
        modelBuilder.ApplyConfiguration(new AccountConfiguration());
        modelBuilder.ApplyConfiguration(new AccountTransactionConfiguration());
        modelBuilder.ApplyConfiguration(new EftTransactionConfiguration());
        modelBuilder.ApplyConfiguration(new MoneyTransferTransactionConfiguration());
        base.OnModelCreating(modelBuilder);
    }*/
}
