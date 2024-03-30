using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17.Models
{
    internal class Department
    {
        private List<Employee> Employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void ShowEmployeeInfo()
        {
            foreach (var employee in Employees)
            {
                Console.WriteLine($"Ad: {employee.Name}, Soyad: {employee.Surname}, Yaş: {employee.Age}, Maaş: {employee.Salary}");
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return Employees;
        }

    }
}
