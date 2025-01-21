
using System;

namespace student_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating student object
            Student student = new Student("Buddhika","Niroshan","eg245158",new DateTime(2000,02,14));
            
            student.DisplayStudentInfo();
        }
    }
}
