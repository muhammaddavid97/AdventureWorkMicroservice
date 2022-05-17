using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Entities.DataTransferObject
{
    public class AddressDto
    {
        public IEnumerable<AddressType> AddressType { get; set; }
        public IEnumerable<CountryRegion> CountryRegion { get; set; }
        public IEnumerable<StateProvince> StateProvince { get; set; }
        public string Address { get; set; }
    }
}
