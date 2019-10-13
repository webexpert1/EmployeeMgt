using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMgt.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employee;

        public MockEmployeeRepository()
        {
            _employee = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Richard", Department = "IT", Email = "r@gmail.com"},
                new Employee() { Id = 2, Name = "Mary", Department = "HR", Email = "mary@gmail.com"},
                new Employee() { Id = 3, Name = "John", Department = "Marketing" , Email = "jn@gmail.com"}
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employee;
        }

        public Employee GetEmployee(int id)
        {
            return _employee.FirstOrDefault(e => e.Id == id);
        }
    }
}
