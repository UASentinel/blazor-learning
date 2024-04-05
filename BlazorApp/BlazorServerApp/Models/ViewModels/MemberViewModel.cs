using System.ComponentModel.DataAnnotations;

namespace BlazorServerApp.Models.ViewModels
{
    public class MemberViewModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Max length for Name is 30")]
        [MinLength(3, ErrorMessage = "Min length for Name is 3")]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email format")]
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime JoinedDate { get; set; }
    }
}
