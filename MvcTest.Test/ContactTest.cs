using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcTest.Data;
using MvcTest.Data.Models;
using System.Data.Entity;
using static MvcTest.Common.Domain.Enums;

namespace MvcTest.Test
{
    [TestClass]
    public class ContactClass
    {
        private readonly MvcTestContext _context;

        public ContactClass()
        {
            MvcTestContextFactory factory = new MvcTestContextFactory();
            _context = new MvcTestContext(factory.Create().Database.Connection.ConnectionString);
        }

        private static readonly Contact _contactCreate =
            new Contact { FirstName = "Test", LastName = "#1", DisplayAs = DisplayAsEnum.LastFirst, PhoneNumber = "0401 123 456" };

        private static readonly Contact _contactEdit =
            new Contact { FirstName = "Test", LastName = "#2", DisplayAs = DisplayAsEnum.FirstLast, PhoneNumber = "0401 111 111" };

        private const int _id = 2;

        [TestMethod]
        public void List()
        {
            var actual = _context.Contacts.ToListAsync();
            
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Result.Count >= 0);
        }

        [TestMethod]
        public void Details()
        {
            var actual = _context.Contacts.SingleOrDefaultAsync(q => q.Id == _id);

            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Result.Id >= 0);
        }

        [TestMethod]
        public void Create()
        {
            var actual = _context.Contacts.Add(_contactCreate);
            _context.SaveChangesAsync();

            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Id >= 0);
        }

        [TestMethod]
        public void Edit()
        {
            var actual = _context.Contacts.Attach(_contactEdit);
            _context.Entry(_contactEdit).State = EntityState.Modified;
            _context.SaveChangesAsync();

            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Id >= 0);
        }

        [TestMethod]
        public void Delete()
        {
            var contact = _context.Contacts.SingleOrDefaultAsync(q => q.Id == _id).Result;
            _context.Contacts.Remove(contact);
            var actual = _context.SaveChangesAsync();
            
            Assert.IsTrue(actual.Result != 0);
        }
    }
}