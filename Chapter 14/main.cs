using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2;

namespace ConsoleApp2
{
    class main
    {

        static void Main(string[] args)
        {

            Student student = new Student("savee@.gmail.com", null);
            student.Name="Igor";
            student.Subject = "Math";
            student.PhoneNumber = 0979797997;
            student.University = "Ivan Franko National University";
            student.Course = 1;


            Student student2 = new Student("Ivan", "Kyiv University", 3, "Geometry");
            

            Console.WriteLine("So first student's info is:");
            student.StudentInfo();
            Console.WriteLine();
            Console.WriteLine("And the second student's info is:");
            student2.StudentInfo();
            Console.WriteLine();
            Console.Write("There were created ");
            student.StudentsCount();
            Console.Write(" instances of students");
            Console.ReadKey();
            
        }

    }
}
