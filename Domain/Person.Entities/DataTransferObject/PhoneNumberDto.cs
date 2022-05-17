using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Entities.DataTransferObject
{
    public class PhoneNumberDto
    {
        public string PhoneNumber { get; set; }
        public IEnumerable<PhoneNumberType> PhoneNumberTypes { get; set; }
    }
}
