//-----------------------------------------------------------------------
// File:    Student.cs
// Summary: program for Task 6, write an application to show students and
//          grades
// Version: 1.0
// Owner:   Tomas Berggren
//-----------------------------------------------------------------------
// Log: 2019-03-28: Created the file
//		2019-04-10: Revised and prepared for submission. 
// 
//-----------------------------------------------------------------------

namespace Task6
{
    public class Student
    {
        //declare an instance variable that holds the x cordinate value
        public string name { get; set; }
        //declare an instance variable that holds the y cordinate value
        public string birthDate { get; set; } 
        public string course { get; set; } 
        public string grade { get; set; } 

        //Add empty constructor
        public Student(string studentName, string studentBirthDate, string studentCourse, string studentGrade)
        {
            name = studentName;
            birthDate = studentBirthDate;
            course = studentCourse;
            grade = studentGrade;
        }// end constructor
        
        public virtual string Display()
        {
            string result = "Student: " + this.name + " " +
                this.birthDate + " " + this.course + " " +
                this.grade;
            return result;
        }
    }
}
