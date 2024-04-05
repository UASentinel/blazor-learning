using Microsoft.AspNetCore.Components.Routing;

namespace BlazorServerApp.Models.Utils
{
    public class NavElement
    {
        public string Href { get; set; }
        public string Icon { get; set; }
        public string Label { get; set; }
        public NavLinkMatch Match { get; set; }
        public NavElement(string href, string icon, string label, NavLinkMatch match = NavLinkMatch.Prefix)
        {
            Href = href;
            Icon = icon;
            Label = label;
            Match = match;
        }
    }
}
