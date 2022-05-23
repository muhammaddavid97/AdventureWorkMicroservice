using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Entities.DataTransferObject
{
    public class PhoneNumberDto
    {
        [Required(ErrorMessage = "Phone Number is required")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Phone Number Type ID is required")]
        public int PhoneNumberTypeID { get; set; }
    }
}
