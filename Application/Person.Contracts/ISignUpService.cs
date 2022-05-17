using Persons.Entities.DataTransferObject;
using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts
{
    public interface ISignUpService
    {
        Task<bool> SignUp(PersonSignUpDto signUpDto);
    }
}
