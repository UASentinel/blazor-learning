using BlazorServerApp.Models.Entities;

namespace BlazorServerApp.Pages.Contacts
{
    public partial class Contacts
    {
        private List<Contact> contacts;
        
        private ContactsList contactsList;

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(1000);

            contacts = new List<Contact>()
            {
                new Contact("Volodymyr", "Fedorenko", "volodymyr.fedorenko@nure.ua"),
                new Contact("Vadym", "Chan", "vadym.chan@nure.ua"),
                new Contact("Illya", "Teliuk", "illya.teliuk@nure.ua")
            };

            await base.OnInitializedAsync();
        }

        private void ChangeContactsVisibility()
        {
            contactsList.ChangeContactsVisibility();
        }
    }
}
