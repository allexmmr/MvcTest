using MvcTest.Data.Models;
using System.Data.Entity;

namespace MvcTest.Data
{
    public class MvcTestContext : DbContext
    {
        public MvcTestContext(string connString) : base(connString)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().ToTable("Contact");
        }
    }
}