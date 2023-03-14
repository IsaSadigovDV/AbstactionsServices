using MiniTask.Implementations.Services;
using MiniTask.Models;
using MiniTask.Models.BaseModel;


StudentService studentService = new StudentService();
TeacherService teacherService = new TeacherService();

Console.WriteLine("0 - to quit");
Console.WriteLine("1 - to create a student");
Console.WriteLine("2 - to show students");
Console.WriteLine("3 - to get by Id students");
Console.WriteLine("4 - to create a teacher");
Console.WriteLine("5 - to show teachers:");
Console.WriteLine("6 - to get by Id for teachers");

string request = Console.ReadLine();

    while (request != "0")
    {
        switch (request)
        {
            case "1":
                studentService.Create();break;
            case "2":
                studentService.Show(); break;
            case "3":
                studentService.GetById();break;
            case "4":
                teacherService.Create(); break;
            case "5":
                teacherService.Show();
            break;
            case "6":
            teacherService.GetById();
            break;
            default: Console.WriteLine("Please enter steps only by numbers...");
                break;
        }
    Console.WriteLine("0 - to quit");
    Console.WriteLine("1 - to create a student");
    Console.WriteLine("2 - to show students");
    Console.WriteLine("3 - to get by Id students");
    Console.WriteLine("4 - to create a teacher");
    Console.WriteLine("5 - to show teachers:");
    Console.WriteLine("6 - to get by Id for teachers");
    

    request = Console.ReadLine();



}


