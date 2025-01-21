using System;
namespace student_linked_list
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RegNum { get; set; }
        public DateTime DateOfBirth { get; set; }
    
        //constructor to initialize the student details

        public Student(string firstName, string lastName, string regNum, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            RegNum = regNum;
            DateOfBirth = dateOfBirth;
        }
    
        //method to display student details

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"First Name: {FirstName} {LastName}");
            Console.WriteLine($"Registration Number: {RegNum}");
            Console.WriteLine($"Date of birth: {DateOfBirth}");
        }
    }
}
