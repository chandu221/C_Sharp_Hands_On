using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Net.NetworkInformation;
using MilitaryApp.Domain;

namespace MilitaryApp.Data
{
    public class MilitaryContext : DbContext
    {
        public DbSet<Military> Militaries { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<King> Kings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(local)\\SQLexpress;InitialCatalog-MilitaryDB; Integrated Security = True");
        }

}
}
