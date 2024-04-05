using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.Shared.Modals
{
    public partial class DeleteModal
    {
        private bool showModal = false;

        [Parameter]
        public string Body { get; set; }

        [Parameter]
        public EventCallback OnConfirmed { get; set; }

        public void Show() => showModal = true;
        public void Hide() => showModal = false;

        private async Task Confirm()
        {
            await OnConfirmed.InvokeAsync();
        }
    }
}
