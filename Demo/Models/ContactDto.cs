using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class ContactDto
    {
        [Required(ErrorMessage ="The first name is required")]
        public string FirstName { get; set; } = "";
        [Required(ErrorMessage = "The last Name is required")]
        public string LastName { get; set; } = "";
        [Required(ErrorMessage = "The email is required")]
        [EmailAddress]
        public string EmailAddress { get; set; } = "";

        [Required(ErrorMessage ="The message is required")]
        public string Message { get; set; } = "";
    }
}
