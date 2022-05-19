using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Entities.DataTransferObject
{
    public class EmailAddressDTO
    {

        public int EmailAddressID { get; set; }
        [Required(ErrorMessage = "Email Address is required")]
        public string EmailAddress1 { get; set; }
    }
}
