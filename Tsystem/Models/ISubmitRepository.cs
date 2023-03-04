using System;
using System.Collections.Generic;

namespace Tsystem.Models
{
    public interface ISubmitRepository
    {
        IEnumerable<Submit> GetAll();

        IEnumerable<Submit> GetAll_sick();

        IEnumerable<Submit> GetAll_pto();

        IEnumerable<Employee> GetAll_employee();

        Submit Add(Submit user);

        Employee Add_employee(Employee employee);
    }
}
