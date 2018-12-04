using System;

namespace DInjConsole
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public void Print(int employeeId)
        {
            var employee = _repository.FindById(employeeId);
            Console.WriteLine(employee != null
                ? $"Id:{employee.Id}, Name:{employee.Name}"
                : $"Employee with Id:{employeeId} not found.");
        }
    }
}