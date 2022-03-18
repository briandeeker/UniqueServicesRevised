using System.ComponentModel.DataAnnotations;

namespace UniqueServices.Models
{
    public class EmailMessageViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(40, ErrorMessage = "Name can't contain more than 40 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter at least one e-mail address.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please make a selection.")]
        public string Selection { get; set; }

        public string RedirectUrl { get; set; }
    }
}