namespace BlazorServerApp.Models.Entities
{
    [Serializable]
    public class Contact
    {
        public Contact(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
