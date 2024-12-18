using Microsoft.AspNetCore.Mvc;
using OrnekProje.Context;
using OrnekProje.Models;

namespace OrnekProje.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public ContactController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddContact()
        {
            Contact contact = new Contact();
            return View(contact);
        }
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                dbContext.Contacts.Add(contact);
                dbContext.SaveChanges();
                //veritabanı ekleme işlemlerini yap.
                return RedirectToAction("Index");

            }
         //validasyon hatalarını göster aynı sayfada
            return View(contact);
        }

        [HttpGet]
        public IActionResult UpdateContact(int contactId)
        {
            //LINQ
            Contact contact = dbContext.Contacts.FirstOrDefault(x => x.Id == contactId);
            return View(contact);
        }

        //Veritabanı bağlantısı kur.
    }
}
