using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathArticleProjects
{
    internal class SecondInstance
    {
        public int StudentRollNo;
        public string studentName;
        public string studentMailId;
        public string studentPercentage;
        public static string schoolName;

        public static SecondInstance GetStudentDetails()
        {
            SecondInstance s = new SecondInstance();
            return s;
        }

        static void Main(string[] args)
        {
            SecondInstance s1 = SecondInstance.GetStudentDetails();
            SecondInstance s2 = SecondInstance.GetStudentDetails();
            SecondInstance s3 = SecondInstance.GetStudentDetails();

            s1.StudentRollNo = 1001;
            s1.studentName = "Jack";
            s1.studentMailId = "Jack@gmail.com";
            s1.studentPercentage = "45.2";
            SecondInstance.schoolName = "Global school";

            s2.StudentRollNo = 1002;
            s2.studentName = "Peter";
            s2.studentMailId = "Peter@gmail.com";
            s2.studentPercentage = "85.2";
            SecondInstance.schoolName = "Global school";

            s3.StudentRollNo = 1003;
            s3.studentName = "mark";
            s3.studentMailId = "mark@gmail.com";
            s3.studentPercentage = "56.5";
            SecondInstance.schoolName = "Global school";




        }
    }
}
