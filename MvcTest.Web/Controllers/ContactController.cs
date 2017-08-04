using Microsoft.AspNetCore.Mvc;
using MvcTest.Data;
using MvcTest.Data.Models;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MvcTest.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly MvcTestContext _context;

        public ContactController(MvcTestContext context)
        {
            _context = context;
        }

        // GET: Contact
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contacts.ToListAsync());
        }

        // GET: Contact/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contact contact = await _context.Contacts.SingleOrDefaultAsync(q => q.Id == id);

            if (contact == null)
            {
                return NotFound();
            }

            return PartialView(contact);
        }

        // GET: Contact/Create
        public IActionResult Create()
        {
            return PartialView();
        }

        // POST: Contact/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Knickname,DisplayAs,DateOfBirth,PhoneNumber")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(contact);
                await _context.SaveChangesAsync();

                return RedirectToAction("Successfully");
            }

            return PartialView(contact);
        }

        // GET: Contact/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contact contact = await _context.Contacts.SingleOrDefaultAsync(q => q.Id == id);

            if (contact == null)
            {
                return NotFound();
            }

            return PartialView(contact);
        }

        // POST: Contact/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Knickname,DisplayAs,DateOfBirth,PhoneNumber")] Contact contact)
        {
            if (id != contact.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Contacts.Attach(contact);
                _context.Entry(contact).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return RedirectToAction("Successfully");
            }

            return PartialView(contact);
        }

        // GET: Contact/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contact contact = await _context.Contacts.SingleOrDefaultAsync(q => q.Id == id);

            if (contact == null)
            {
                return NotFound();
            }

            return PartialView(contact);
        }

        // POST: Contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Contact contact = await _context.Contacts.SingleOrDefaultAsync(q => q.Id == id);
            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync();

            return RedirectToAction("Successfully");
        }

        // GET: Successfully
        public ActionResult Successfully()
        {
            return PartialView("Successfully", "Shared");
        }
    }
}