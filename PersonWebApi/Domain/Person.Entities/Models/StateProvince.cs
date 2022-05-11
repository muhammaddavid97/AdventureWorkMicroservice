using System;
using System.Collections.Generic;

#nullable disable

namespace Persons.Entities.Models
{
    public partial class StateProvince
    {
        public StateProvince()
        {
            Addresses = new HashSet<Address>();
        }

        public int StateProvinceID { get; set; }
        public string StateProvinceCode { get; set; }
        public string CountryRegionCode { get; set; }
        public bool? IsOnlyStateProvinceFlag { get; set; }
        public string Name { get; set; }
        public int TerritoryID { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual CountryRegion CountryRegionCodeNavigation { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
