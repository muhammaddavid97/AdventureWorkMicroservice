using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts.Interfaces
{
    public interface IRegionPersonRepository
    {
        Task<IEnumerable<VRegionPerson>> GetAllRegionPersonAsync(bool trackChanges);
    }
}
