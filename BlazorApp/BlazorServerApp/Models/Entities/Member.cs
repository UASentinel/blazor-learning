namespace BlazorServerApp.Models.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime JoinedDate { get; set; }
    }
}
