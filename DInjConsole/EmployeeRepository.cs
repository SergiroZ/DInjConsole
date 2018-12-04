using System.Collections.Generic;
using System.Linq;

namespace DInjConsole
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _data = new List<Employee>()
        {
            new Employee {Id = 1, Name = "Employee 1"},
            new Employee {Id = 2, Name = "Employee 2"},
        };

        public Employee FindById(int id)
        {
            return _data.SingleOrDefault(e => e.Id == id);
        }
    }
}