using ContactApp.Models;
using ContactApp.Models;

namespace ContactApp.DataAccess
{
    public interface IContactManager
    {
        List<ContactInfo> GetAllContacts();
        ContactInfo GetContactById(int id);
        void AddContact(ContactInfo contact);
    }
}

