using Microsoft.EntityFrameworkCore;
using SMS.model;

namespace SMS
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("SERVER=localhost; User Id=root; Password=1234; DATABASE=amaster",new MySqlServerVersion(new Version("8.0.29")));
        }
        public DbSet<Product> Products {get;set;}
        public DbSet<Attendant> Attendants {get;set;}
        public DbSet<Transactiona> Transactionas {get;set;}
        public DbSet<Admin> Admins {get;set;}
        // public DbSet<User> Users {get;set;}
    }
}
