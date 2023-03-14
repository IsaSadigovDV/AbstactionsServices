using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDepartment.Models
{
    internal class Employee
    {
        public string Name;
        public string Surname;
        public int Salary;




        public Employee(string name, string surname, int salary)
        {
            this.Name = name;
            this.Surname = surname;
            this.Salary = salary;




        }
    }
}
