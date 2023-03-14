using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeDepartment.Models
{
    internal class Department
    {
        public string Name;
        public readonly int EmployeeLimit = 2;
        public readonly int SalaryLimit  = 250;
        public int EmployeeCount = 0;
        public Employee[] Employees = {};



        public Employee[] AddEmployee()
        {   
            Array.Resize(ref Employees, EmployeeCount + 1);
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Surname: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Salary: ");
            int salary = int.Parse(Console.ReadLine());

            Employees[EmployeeCount] = new Employee(name,surname, salary);
            EmployeeCount++;


            return Employees;

        }

        public void ShowEmployee()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"Name {employee.Name}, Surname {employee.Surname}, " +
                    $"Salary {employee.Salary}");
            }
        }


        bool CheckName(string name, string surname)
        {
            if (string.IsNullOrEmpty(name)|| string.IsNullOrEmpty(surname)){
                return false;
            }
            if(!name.All(char.IsLetter) || !surname.All(char.IsLetter)){
                return false;
            }
            if (!char.IsUpper(name[0]) || !char.IsUpper(surname[0])){
                return false;
            }
            return true;
        }


    }
}
