using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathArticleProjects
{
    internal class Student
    {
        public int studentRollNo;
        public string studentName;
        public string studentMailId;
        public string studentPercentage;
        public static string schoolName;

        public static void DisplayStudentDetails(Student s)
        {
            Console.WriteLine(s.studentRollNo);
            Console.WriteLine(s.studentName);
            Console.WriteLine(s.studentMailId);
            Console.WriteLine(s.studentPercentage);
            Console.WriteLine(Student.schoolName);

        }

        static void Main56(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();

            Student.schoolName = "Narayana college";
            s1.studentRollNo = 101;
            s1.studentName = "Jhon";
            s1.studentMailId = "Jhon@gmail.com";
            s1.studentPercentage = "60%";

            s2.studentRollNo = 102;
            s2.studentName = "Smith";
            s2.studentMailId = "Smith@gmail.com";
            s2.studentPercentage = "70%";
            
            s3.studentRollNo = 103;
            s3.studentName = "Henry";
            s3.studentMailId = "Henry@gmail.com";
            s3.studentPercentage = "80%";

            Student.DisplayStudentDetails(s1);
            Student.DisplayStudentDetails(s2);
            Student.DisplayStudentDetails(s3);
            

        }
    }
}
