using BlazorServerApp.Models.Entities;
using BlazorServerApp.Pages.Contacts;

namespace BlazorServerApp.Data
{
    public interface IContactService
    {
        List<Contact> GetContacts();
        void AddContact(Contact contact);
    }
}
