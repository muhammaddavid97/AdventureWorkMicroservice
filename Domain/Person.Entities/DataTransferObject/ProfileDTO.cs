using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Entities.DataTransferObject
{
    public class ProfileDTO
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public int BusinessEntityID { get; set; }
        public ICollection<EmailAddress> Emails { get; set; }
        public ICollection<PersonPhone> PersonPhones { get; set; }
        //public ICollection<BusinessEntityAddress> AddressType { get; set; }
        //public ICollection<Address> Address { get; set; }
    }
}
