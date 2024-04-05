using BlazorServerApp.Models.Entities;
using System.Net;

namespace BlazorServerApp.Data
{
    public class ContactService : IContactService
    {
        private List<Contact> Contacts { get; set; } = new List<Contact>();

        public List<Contact> GetContacts()
        {
            return Contacts;
        }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
    }
}
