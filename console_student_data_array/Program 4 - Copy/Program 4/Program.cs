//Program 4
//CIS 199-50
//Due Date: 12/02/2024
//By: Helen Le

//This file creates an array of student objects and tests them. It displays current student data
//and then after changes were made to the objects, it displays the changes as "After Changes".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student objects with initial data
            Student student1 = new Student("John McLane", 3.6, 12, "Junior", "Computer Information Systems", true); //Defines student data in order of name, GPA, credit hours, classificatiion, major, enrollment status
            Student student2 = new Student("Patrick Swayze", 3.8, 14, "Freshman", "Business Administration", true);
            Student student3 = new Student("Marty McFly", 3.3, 15, "Junior", "Chemistry", true);
            Student student4 = new Student("Dolly Parton", 3.6, 12, "Sophomore", "Mechanical Engineering", true);
            Student student5 = new Student("Harvey Spector", 2.8, 18, "Senior", "Criminal Justice", false);

            //Array to store student objects
            Student[] students = { student1, student2, student3, student4, student5 };

            Console.WriteLine("--Current Students--");
            DisplayStudents(students);

            //Modify student data
            student1.Name = "John Marston";
            student2.GPA = 3.7;
            student3.CreditHours = 9;
            student4.Unenroll();
            student5.Enroll();

            Console.WriteLine("\n--After Changes--");
            DisplayStudents(students);
        }

        //Precondition: students should contain valid Student objects
        //Postcondition: Students' updated information is displayed
        public static void DisplayStudents(Student[] students)
        {
            foreach(Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
