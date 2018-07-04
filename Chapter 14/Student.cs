using System;

namespace ConsoleApp2
/*1.Define a class Student, which contains the following 
 * information about students: full name, course, subject, university, e-mail and phone number
 
 2.Declare several constructors for the class Student, which have different lists of parameters 
 (for complete information about a student or part of it). 
 Data, which has no initial value to be initialized with null. Use nullable types for all non-mandatory data
 
 3.Add a static field for the class Student, which holds the number of created objects of this class.
 
 4.Add a method in the class Student, which displays complete information about the student.
 
 5. Modify the current source code of Student class so as to encapsulate the data in the class using properties.*/
{
    class Student
    {

        static int count;

        public string name;
        private int? course;
        private string subject;
        private string university;
        private string email;
        private int? phoneNumber;
        

        public string Name { get => name; set => name = value; }
        public int? Course { get => course; set => course = value; }
        public string Subject { get => subject; set => subject = value; }
        public string University { get => university; set => university = value; }
        public string Email { get => email; set => email = value; }
        public int? PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public Student()
        {
            count++;
        }

        public Student(string stName, string stUniversity, int? stCourse, string stSubject, string stEmail, int stPhoneNumber)
        {
            this.Name = stName;
            this.University = stUniversity;
            this.Course = stCourse;
            this.Subject = stSubject;
            this.Name = stName;
            this.Email = stEmail;
            this.PhoneNumber = stPhoneNumber;
            count++;
        }

        public Student(string stName, string stUniversity, int? stCourse, string stSubject)
        {
            this.Name = stName;
            this.University = stUniversity;
            this.Course = stCourse;
            this.Subject = stSubject;
            count++;
        }

        public Student(string stEmail, int? stPhoneNumber)
        { 
            
            this.Email = stEmail;
            this.PhoneNumber = stPhoneNumber;
            count++;
        }

        public void StudentsCount()
        {
            Console.Write(count);
        }

        public void StudentInfo()
        {
           
                Console.WriteLine($"Student {Name}, is on {Course} course of {University} and studies {Subject}. His phone number is {PhoneNumber} and email {Email}");
            
        }




    }
}

