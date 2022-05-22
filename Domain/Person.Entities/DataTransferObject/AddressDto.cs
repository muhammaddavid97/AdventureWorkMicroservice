using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Entities.DataTransferObject
{
    public class AddressDto
    {
        [Required(ErrorMessage = "Address Type is required")]
        public int AddressTypeID { get; set; }
        [Required(ErrorMessage = "Country Region is required")]
        public string CountryRegionCode { get; set; }
        [Required(ErrorMessage = "State Province is required")]
        public int StateProvinceID { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string AddressLine1 { get; set; }
    }
}
