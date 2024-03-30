using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Models
{
    internal class Department
    {
        Employee[] Employees;
        
        public void AddEmployee(Employee employee)
        {
            Employee[] newemployees = new Employee[Employees.Length + 1];
            for (int i = 0; i < Employees.Length; i++)
            {
                newemployees[i] = Employees[i];
            }
            newemployees[newemployees.Length - 1] = employee;
            Employees = newemployees;

        }
        public Employee ShowEmployeeInfo()
        {
            foreach (Employee employee in Employees)
            {
                return employee;

            }
            return null;



        }
       
    }
}

