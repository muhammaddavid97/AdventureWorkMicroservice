using System;
using System.Collections.Generic;

#nullable disable

namespace Persons.Entities.Models
{
    public partial class CountryRegion
    {
        public CountryRegion()
        {
            StateProvinces = new HashSet<StateProvince>();
        }

        public string CountryRegionCode { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<StateProvince> StateProvinces { get; set; }
    }
}
