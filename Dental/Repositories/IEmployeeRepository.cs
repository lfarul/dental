﻿using Dental.Models;
using System.Collections.Generic;

namespace Dental.Repositories
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int EmployeeID);
        IEnumerable<Employee> GetAllEmployees();
        Employee Add(Employee employee);
        Employee Update(Employee employeeUpdate);
        Employee Delete(int Id);
    }
}
