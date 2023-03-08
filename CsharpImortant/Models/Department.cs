using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEmployee.Models
{
    internal class Department
    {
        public string Name;
        public readonly int EmployeeLimit = 2;
        public readonly int SalaryLimit = 250;
        public Employee[] employees = { };
        public int EmployeeCount = 0;

        public Employee[] AddEmployee()
        {

            Array.Resize(ref employees, EmployeeCount + 1);
            Console.Write("Please enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Please enter SurName : ");
            string surname = Console.ReadLine();
            Console.Write("Please enter Salary : ");
            int salary = int.Parse(Console.ReadLine());

            if (salary > 250)
            {
                AddEmployee();
            }
            else
            {
                Console.WriteLine("Salary should be more than 250");
            }
            return employees;
            
        }


        public void ShowEmployee()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine("Name: " + employee.Name, "Surname: " + employee.Surname,
                    "Salary: " + employee.Salary);
            }
        }
    }
}
