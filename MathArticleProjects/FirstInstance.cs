using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathArticleProjects
{
    internal class FirstInstance
    {
        public int studentRollNo;
        public string studentName;
        public string studentMailId;
        public string studentPercentage;
        public static string schoolName;

        public void PrintDetails()
        {
            Console.WriteLine(studentRollNo);
            Console.WriteLine(studentName);
            Console.WriteLine(studentMailId);
            Console.WriteLine(studentPercentage);
            Console.WriteLine(schoolName);
        }

        static void Main55(string[] args)
        {
            FirstInstance f1 = new FirstInstance();
            FirstInstance f2 = new FirstInstance();
            FirstInstance f3 = new FirstInstance();

            f1.studentRollNo = 1001;
            f1.studentName = "jack";
            f1.studentMailId = "jack@gmail.com";
            f1.studentPercentage = "45.2";
            FirstInstance.schoolName = "Global school";

            f2.studentRollNo = 1002;
            f2.studentName = "peter";
            f2.studentMailId = "peter@gmail.com";
            f2.studentPercentage = "85.2";
            FirstInstance.schoolName = "Global school";

            f3.studentRollNo = 1003;
            f3.studentName = "mark";
            f3.studentMailId = "mark@gmail.com";
            f3.studentPercentage = "56.5";
            FirstInstance.schoolName = "Global school";

            f1.PrintDetails();
            f2.PrintDetails();
            f3.PrintDetails();



        }
    }
}
