using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TaskEmployee.Models
{
    internal class Employee
    {
        private string _Name;
        private string _Surname;
        private int _Salary;


        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                bool controler = false;
                for (int i = 0; i < value.Length; i++)
                {
                   bool letter = char.IsLetter(value[i]) && char.IsUpper(value[0]);
                    if(letter)
                    {
                        
                    }
                    else
                    {
                        controler= true;
                        break;
                    }
                }

                if(controler)
                {
                    Console.WriteLine("Name should be write by only letters");
                        
                }
                else
                {
                    _Name = value;
                }
            }
        }

        public string Surname
        {
            get
            {
                return _Surname;
            }

            set
            {
                bool controler = false;
                for (int i = 0; i < value.Length; i++)
                {
                    bool letter = char.IsLetter(value[i]) && char.IsUpper(value[0]);
                    if (letter)
                    {

                    }
                    else
                    {
                        controler = true;
                        break;
                    }
                }

                if (controler)
                {
                    Console.WriteLine("Surname should be written by only letters and first " +
                        "letter should be in uppercase");
                }
                else
                {
                    _Surname = value;
                }
            }
        }

        public int Salary 
        {
            get
            {
                return _Salary;
            }

            set
            {
                if(value <= 250)
                {
                    Console.WriteLine("Salary can not be less than 250");
                }
                else
                {
                    _Salary = value;
                }
            }
        }

        public Employee(string Name, string Surname, int Salary)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Salary = Salary;
        }

    }
}
