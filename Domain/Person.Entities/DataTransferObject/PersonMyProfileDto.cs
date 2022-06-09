
using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Entities.DataTransferObject
{
    public class PersonMyProfileDto
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        public string Suffix { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public ICollection<EmailDto> Email { get; set; }
        public ICollection<PhoneNumberDto> PhoneNumber { get; set; }
        public List<AddressDto> Address { get; set; }
    }
}
