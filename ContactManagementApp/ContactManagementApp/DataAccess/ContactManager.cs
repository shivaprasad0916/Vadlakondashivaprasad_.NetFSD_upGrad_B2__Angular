using ContactApp.Models;
using ContactApp.Models;

namespace ContactApp.DataAccess
{
    public class ContactManager : IContactManager
    {
        private static List<ContactInfo> _contacts = new List<ContactInfo>
        {
            new ContactInfo { ContactId = 101, FirstName = "shiva", LastName = "prasad", CompanyName = "UpGrad", EmailId = "shivaprasad@gmail.com", MobileNo = 0123456789, Designation = "Junior Software Engineer" },
            new ContactInfo { ContactId = 102, FirstName = "Mohan", LastName = "", CompanyName = "Cognizant", EmailId = "mohan@gmail.com", MobileNo = 9955468223, Designation = "QA Tester" },
            new ContactInfo { ContactId = 103, FirstName = "Nikhil", LastName = "Kumar", CompanyName = "Accenture", EmailId = "nikhilkumar@gmail.com", MobileNo = 8546727890, Designation = "Delivery Manager" },
            new ContactInfo { ContactId = 104, FirstName = "charan", LastName = "kumar", CompanyName = "Infosys", EmailId = "jane@xyz.com", MobileNo = 9542635958, Designation = "Developer" }
        };

        public List<ContactInfo> GetAllContacts()
        {
            return _contacts;
        }

        public ContactInfo GetContactById(int id)
        {
            return _contacts.FirstOrDefault(c => c.ContactId == id);
        }

        public void AddContact(ContactInfo contact)
        {
            contact.ContactId = _contacts.Count > 0 ? _contacts.Max(c => c.ContactId) + 1 : 1;
            _contacts.Add(contact);
        }
    }
}