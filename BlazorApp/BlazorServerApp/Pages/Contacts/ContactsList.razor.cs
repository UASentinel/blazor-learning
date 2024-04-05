using BlazorServerApp.Models.Entities;
using BlazorServerApp.Shared.Modals;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorServerApp.Pages.Contacts
{
    public partial class ContactsList
    {
        [Inject]
        private IJSRuntime jsRuntime { get; set; }

        [Parameter]
        public List<Contact> Contacts { get; set; }

        [Parameter]
        public RenderFragment NullContacts { get; set; }

        [Parameter]
        public RenderFragment EmptyContacts { get; set; }

        private bool displayName = true;
        private bool displayEmail = false;
        private bool displayContacts = true;

        private DeleteModal deleteModal;
        private Contact selectedContact;

        private async Task RequestDeleteContact(Contact contact)
        {
            //var confirm = await jsRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to delete this contact?");

            //if(confirm)
            //    Contacts.Remove(contact);
            selectedContact = contact;

            deleteModal.Body = $"Are you sure you want to delete {contact.FirstName} {contact.LastName}?";
            deleteModal.Show();
        }

        public void ChangeContactsVisibility()
        {
            displayContacts = !displayContacts;
        }

        private async Task OnDeleteConfirmed()
        {
            Contacts.Remove(selectedContact);
            deleteModal.Hide();
        }
    }
}
