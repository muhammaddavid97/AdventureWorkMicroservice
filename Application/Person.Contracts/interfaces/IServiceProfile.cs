using Persons.Entities.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts.interfaces
{
    public interface IServiceProfile
    {
        Task PostProfile(int id,ProfileDTO profileDTO);
    }
}
