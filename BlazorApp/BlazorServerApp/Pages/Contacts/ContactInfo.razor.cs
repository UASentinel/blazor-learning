using BlazorServerApp.Models.Entities;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.Pages.Contacts
{
    public partial class ContactInfo
    {
        [Parameter]
        public Contact Contact { get; set; }

        [Parameter]
        public bool DisplayEmail { get; set; }

        [Parameter]
        public bool DisplayName { get; set; }

        [Parameter]
        public EventCallback<Contact> DeleteContact { get; set; }

        private bool displayInfo;
    }
}
