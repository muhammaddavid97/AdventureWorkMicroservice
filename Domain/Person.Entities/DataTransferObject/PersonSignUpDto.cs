using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Entities.DataTransferObject
{
    public class PersonSignUpDto
    {
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Suffix is required")]
        public string Suffix { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        public string PhoneNumber { get; set; }

        public ICollection<string> PersonType { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MaxLength(10, ErrorMessage = "Maximum length for Password is 10 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [MaxLength(10, ErrorMessage = "Maximum length for Password is 10 characters")]
        public string ConfirmPassword { get; set; }
    }
}
