using MiniTask.Abstractions.Services;
using MiniTask.Models;
using MiniTask.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTask.Implementations.Services
{
    internal class TeacherService : IBaseService
    {
        Teacher[] teachers = { };
        
        public void Create()
        {
            Teacher teacher = new Teacher();
            Array.Resize(ref teachers, teachers.Length + 1);

            Console.WriteLine("Enter name: ");
            teacher.Name = Console.ReadLine();

            Console.WriteLine("Enter surname: ");
            teacher.Surname = Console.ReadLine();

            Console.WriteLine("Please enter group No: ");
            teacher.GroupNo = Console.ReadLine();

            teachers[teachers.Length-1] = teacher;
        }

        public void Delete()
        {
            
        }

        public void GetById()
        {
            Console.WriteLine("Enter Id");
            int id = int.Parse(Console.ReadLine());
            foreach (Teacher teacher in teachers)
            {
                if(teacher.Id == id)
                {
                    Console.WriteLine(teacher.ToString());
                    break;
                }
            }

        }


        public void Show()
        {
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine(teacher.ToString());
            }
        }
    }
}
