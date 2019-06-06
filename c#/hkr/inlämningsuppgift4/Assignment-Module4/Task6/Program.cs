//-----------------------------------------------------------------------
// File:    Program.cs
// Summary: program for Task 6, write an application to show students and
//          grades
// Version: 1.0
// Owner:   Tomas Berggren
//-----------------------------------------------------------------------
// Log: 2019-03-28: Created the file
//		2019-04-10: Revised and prepared for submission. 
// 
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task6
{
    class Program
    {
       
        public static void OrderByName(List<Student> students)
        {
            Console.WriteLine("List of all students in the program");
            Student barley = new Student("Barley", "2001", "Java", "F");
            students.Add(barley);
            Student karley = new Student("Karley", "2001", "C# Programming", "F");
            students.Add(karley);
            Student farley = new Student("Farley", "2001", "Java", "F");
            students.Add(farley);
            Student darley = new Student("Darley", "2005", "Pascal", "B");
            students.Add(darley);
            Student tarley = new Student("Tarley", "2008", "C# Programming", "F");
            students.Add(tarley);
            Student varley = new Student("Farley", "2001", "Java", "F");
            students.Add(varley);

            IEnumerable<Student> query = students.OrderBy(student => student.name);

            foreach (Student student in query)
            {
                Console.WriteLine("{0} - {1}", student.name, student.grade);
            }
        }
        public static void EnterNewStudent(List<Student> students)
        {
            Student barley = new Student("Tomas", "2001", "Java", "F");
            students.Add(barley);
            Student karley = new Student("Nisse", "2001", "Java", "F");
            students.Add(karley);
            Student farley = new Student("Bertil", "2001", "Java", "F");
            students.Add(farley);
            Console.WriteLine("Name");
            string name = Console.ReadLine();
            Console.WriteLine("BirthDate");
            string birthDate = Console.ReadLine();
            Console.WriteLine("Course");
            string course = Console.ReadLine();
            Console.WriteLine("Grade");
            string grade = Console.ReadLine();
            Student newStudent = new Student(name, birthDate, course, grade);
            students.Add(newStudent);
        }
        public static void SearchForStudent(List<Student> students)
        {
            Console.WriteLine("Check if someone is on the list, type a name");
            string searchNameString = Console.ReadLine();
            bool missingName = true;
            foreach (var student in students)
            {
                string lcName = student.name.ToLower();
                string lcSearchNameString = searchNameString.ToLower();
                if (lcName.Contains(lcSearchNameString))
                {
                    Console.WriteLine("Found :" + student.name+" is on the list");
                    missingName = false;
                }
            }
            if (missingName)
            {
                Console.WriteLine("Could not find what you were looking for");
            }
        }
        public static void RemoveStudent(List<Student> students)
        {
            Console.WriteLine("Remove student, type a name");
            string removeNameString = Console.ReadLine();
            bool missingRemoveName = true;
            foreach (var student in students)
            {
                string lcName = student.name.ToLower();
                string lcSearchNameString = removeNameString.ToLower();
                if (lcName.Contains(lcSearchNameString))
                {
                    students.Remove(student);
                    Console.WriteLine("Removed :" + student.name);
                    missingRemoveName = false;
                    break;
                }
            }
            if (missingRemoveName)
            {
                Console.WriteLine("Could not find what you were looking for");
            }
        }
        public static void SearchForAllStudents(List<Student> students)
        {
            Console.WriteLine("Search for all students in a course, press enter for default C# Programming, otherwise type a course name");
            string input = Console.ReadLine();
            string searchCourseString;
            if (input == "")
            {
                searchCourseString = "C# Programming";
            }
            else
            {
                searchCourseString = input;
            }
            bool missing = true;
            foreach (var student in students)
            {
                string lcCourseName = student.course.ToLower();
                string lcSearchCourseString = searchCourseString.ToLower();
                if (lcCourseName.Contains(lcSearchCourseString))
                {
                    Console.WriteLine("Found :" + student.name + " " + student.course);
                    missing = false;
                }
            }
            if (missing)
            {
                Console.WriteLine("Could not find what you were looking for");
            }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(); //Lista som tar klass
            bool isRunning = true;
            Student barley = new Student("Anna", "2001", "Java", "F");
            students.Add(barley);
            Student karley = new Student("Lisa", "2001", "C# Programming", "F");
            students.Add(karley);
            Student farley = new Student("Marie", "2001", "Java", "F");
            students.Add(farley);
            while (isRunning)
            {
                Console.WriteLine("1. Add new student: ");
                Console.WriteLine("2. Check if a student is on the list: ");
                Console.WriteLine("3. Search for all C# students: ");
                Console.WriteLine("4. Display sorted list: ");
                Console.WriteLine("5. Remove student: ");
                Console.WriteLine("6. Exit application ");
                Int32.TryParse(Console.ReadLine(), out int menuChoice);

                switch (menuChoice)
                {
                    case 1:
                        EnterNewStudent(students);
                        break;
                    case 2:
                        SearchForStudent(students);
                        break;
                    case 3:
                        SearchForAllStudents(students);
                        break;
                    case 4:
                        OrderByName(students);
                        break;
                    case 5:
                        RemoveStudent(students);
                        break;
                    case 6:
                        Console.WriteLine("Case 6");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
