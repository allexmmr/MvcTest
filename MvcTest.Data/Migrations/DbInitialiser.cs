using MvcTest.Data.Models;
using System;
using System.Linq;
using static MvcTest.Common.Domain.Enums;

namespace MvcTest.Data.Migrations
{
    public static class DbInitialiser
    {
        public static void Initialise(MvcTestContext context)
        {
            context.Database.CreateIfNotExists();

            // Look for any contact.
            if (context.Contacts.Any())
            {
                return; // DB has been seeded
            }

            Contact[] contacts = new Contact[]
            {

              new Contact { FirstName = "Allex", LastName = "Rocha", Knickname = null, DisplayAs = DisplayAsEnum.FirstLast, DateOfBirth = Convert.ToDateTime("26/09/1987"), PhoneNumber = "0415 507 628" },
              new Contact { FirstName = "Eldon", LastName = "Wong", Knickname = null, DisplayAs = DisplayAsEnum.FirstLast, DateOfBirth = null, PhoneNumber = "0411 214 821" }
            };

            foreach (Contact item in contacts)
            {
                context.Contacts.Add(item);
            }

            context.SaveChanges();
        }
    }
}