using Persons.Entities.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateUser(PersonModelDTO personModelDTO);
        Task<string> CreateToken();
    }
}
