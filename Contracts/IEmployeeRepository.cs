﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees(Guid companyId, bool trackChanges);
        Employee GetEmployee(Guid companyId, Guid id, bool trackChanges);
    }
}
