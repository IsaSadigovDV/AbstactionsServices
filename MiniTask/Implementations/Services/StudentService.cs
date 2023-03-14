using MiniTask.Abstractions.Services;
using MiniTask.Models;
using MiniTask.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MiniTask.Implementations.Services
{
    internal class StudentService :  IBaseService
    {
        Student[] students = { }; 
        public void Create()
        {
            Student student = new Student();    
            Array.Resize(ref students, students.Length + 1);


            Console.WriteLine("Enter name: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Enter surname: ");
            student.Surname = Console.ReadLine();

            Console.WriteLine("Please enter group No: ");
            student.GroupNo = Console.ReadLine();

            students[students.Length - 1] = student;
        }

        public void Delete()
        {


        }

        public void GetById()
        {
            Console.WriteLine("Enter Id");
            int id = int.Parse(Console.ReadLine());

            foreach (Student student in students)
            {
                if(student.Id == id)
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }

     

        public void Show()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
