using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathArticleProjects
{
    internal class Employee
    {
       
        public int empId;
        public string empName;
        public string empSal;
        public static string companyName;
        public static void DisplayEmployeeDatails(Employee e)
        {
            Console.WriteLine(e.empId);
            Console.WriteLine(e.empName);
            Console.WriteLine(e.empSal);
            Console.WriteLine(Employee.companyName);
            Console.WriteLine("-------------------");
        }
        public void PrintEmployeeDetails()
        {
            Console.WriteLine(empId);
            Console.WriteLine(empName);
            Console.WriteLine(empSal);
            Console.WriteLine(Employee.companyName);
            Console.WriteLine("-------------------");
        }
        public static Employee GetEmploteeDetails()
        {
            Employee emp = new Employee();
            return emp;
        }
        static void Main123(string[] args)
        {
            Employee e1 = Employee.GetEmploteeDetails();
            Employee e2 = Employee.GetEmploteeDetails();           //Instance calling
            Employee e3 = Employee.GetEmploteeDetails();
            e1.PrintEmployeeDetails();
            e2.PrintEmployeeDetails();
            e3.PrintEmployeeDetails();


            Employee.companyName = "Fujitsu";
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();

            emp1.empId = 101;
            emp1.empName = "Jhon";
            emp1.empSal = "12000";
           // emp1.companyName = "Fujitsu";
           
            emp2.empId = 102;
            emp2.empName = "Smith";
            emp2.empSal = "15000";
           // emp1.companyName = "Fujitsu";

            emp3.empId = 103;
            emp3.empName = "Henry";
            emp3.empSal = "20000";
            // static calling
            Employee.DisplayEmployeeDatails(emp1);
            Employee.DisplayEmployeeDatails(emp2);
            Employee.DisplayEmployeeDatails(emp3);

            //Non-static calling
            emp1.PrintEmployeeDetails();
            emp2.PrintEmployeeDetails();
            emp3.PrintEmployeeDetails();

          //  emp1.companyName = "Fujitsu";

           /* Console.WriteLine(emp1.empId);
            Console.WriteLine(emp1.empName);
            Console.WriteLine(emp1.empSal);
            Console.WriteLine(Employee.companyName);

            Console.WriteLine(emp2.empId);
            Console.WriteLine(emp2.empName);
            Console.WriteLine(emp2.empSal);
            Console.WriteLine(Employee.companyName);
            
            Console.WriteLine(emp3.empId);
            Console.WriteLine(emp3.empName);
            Console.WriteLine(emp3.empSal);
            Console.WriteLine(Employee.companyName);*/
        }
    }
}
