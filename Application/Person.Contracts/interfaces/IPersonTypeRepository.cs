﻿using Persons.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Contracts.interfaces
{
    public interface IPersonTypeRepository
    {
        Task<IEnumerable<VPersonType>> GetAllPersonType(bool trackChanges);
    }
}
