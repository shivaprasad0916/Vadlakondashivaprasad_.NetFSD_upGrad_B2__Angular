using ContactApp.DataAccess;
using ContactApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactApp.Controllers
{
    [Route("Contact")]
    public class ContactController : Controller
    {
        private readonly IContactManager _contactManager;

        public ContactController(IContactManager contactManager)
        {
            _contactManager = contactManager;
        }

        [HttpGet("ShowContacts")]
        [Route("/")]
        public ActionResult ShowContacts()
        {
            List<ContactInfo> contacts = _contactManager.GetAllContacts();
            return View(contacts);
        }

        [HttpGet("GetContactById/{id}")]
        public ActionResult GetContactById(int id)
        {
            ContactInfo contact = _contactManager.GetContactById(id);
            if (contact == null)
            {
                ViewBag.Message = $"No contact found with ID {id}.";
                return View(null);
            }
            return View(contact);
        }

        [HttpGet("AddContact")]
        public ActionResult AddContact()
        {
            return View();
        }

        [HttpPost("AddContact")]
        public ActionResult AddContact(ContactInfo contactInfo)
        {
            _contactManager.AddContact(contactInfo);
            return RedirectToAction("ShowContacts");
        }
    }
}

