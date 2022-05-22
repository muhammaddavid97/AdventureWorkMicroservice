using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Entities.DataTransferObject
{
    public class EmailDto
    {
        [Required(ErrorMessage = "Email is required")]
        public string EmailAddress1 { get; set; }
    }
}
