using MvcTest.Data.Models;
using System;
using System.Data.Entity.Migrations;
using static MvcTest.Common.Domain.Enums;

namespace MvcTest.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MvcTestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcTestContext context)
        {
            // You can use the DbSet<T>.AddOrUpdate() helper extension method to avoid creating duplicate seed data

            context.Contacts.AddOrUpdate(
              c => c.FirstName,
              new Contact { FirstName = "Allex", LastName = "Rocha", Knickname = null, DisplayAs = DisplayAsEnum.FirstLast, DateOfBirth = Convert.ToDateTime("26/09/1987"), PhoneNumber = "0415 507 628" }
            );

            context.Contacts.AddOrUpdate(
              c => c.FirstName,
              new Contact { FirstName = "Eldon", LastName = "Wong", Knickname = null, DisplayAs = DisplayAsEnum.FirstLast, DateOfBirth = null, PhoneNumber = "0411 214 821" }
            );
        }
    }
}