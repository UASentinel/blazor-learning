using BlazorServerApp.Data;
using BlazorServerApp.Models.Entities;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.Pages.FetchContacts
{
    public partial class FetchContacts
    {
        [Inject]
        private IContactService contactService { get; set; }

        private List<Contact> contacts;

        private string firstNameInput;
        private string lastNameInput;
        private string emailInput;

        protected override async Task OnInitializedAsync()
        {
            contacts = contactService.GetContacts();
            await base.OnInitializedAsync();
        }

        private void AddContact()
        {
            var contact = new Contact(firstNameInput, lastNameInput, emailInput);
            contactService.AddContact(contact);
        }
    }
}
