using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        private int _salary;
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public int Salary
        {
            get { return _salary; }
            set
            {
                if (value > 0)
                {
                    _salary = value;
                }
            }
        }
        public Employee(string name, string surname, byte age, int salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            
            Salary = salary;
        }
    }
}
