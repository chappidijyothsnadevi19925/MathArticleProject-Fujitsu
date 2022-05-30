using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathArticleProjects
{
    internal class ThreeInstances
    {
        public int studentRollNo;
        public string studentName;
        public string studentMailId;
        public string studentPercentage;
        public static string schoolName;

        public static void DisplayDetails(ThreeInstances t)
        {
            Console.WriteLine(t.studentRollNo);
            Console.WriteLine(t.studentName);
            Console.WriteLine(t.studentMailId);
            Console.WriteLine(t.studentPercentage);
            Console.WriteLine(ThreeInstances.schoolName);


        }
        static void Main97(string[] args)
        {
            ThreeInstances t1 = new ThreeInstances();
            ThreeInstances t2 = new ThreeInstances();
            ThreeInstances t3 = new ThreeInstances();
            t1.studentRollNo = 1001;
            t1.studentName = "Jack";
            t1.studentMailId = "Jack@gmail.com";
            t1.studentPercentage = "45.2";
            ThreeInstances.schoolName = "Global school";

            t2.studentRollNo = 1002;
            t2.studentName = "peter";
            t2.studentMailId = "Peter@gmail.com";
            t2.studentPercentage = "85.2";
            ThreeInstances.schoolName = "Global school";

            t3.studentRollNo = 1003;
            t3.studentName = "Mark";
            t3.studentMailId = "Mark@gmail.com";
            t3.studentPercentage = "56.5";
            ThreeInstances.schoolName = "Global school";

            ThreeInstances.DisplayDetails(t1);
            ThreeInstances.DisplayDetails(t2);
            ThreeInstances.DisplayDetails(t3);



        }
    }
}
