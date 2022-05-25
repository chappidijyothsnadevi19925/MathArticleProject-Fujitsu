using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathArticleProjects
{
    internal class ArrayComparison
    {
        static void Main1(String[] args)
        {
            decimal[] myArr = { 10.0m, 11.3m, 4.5m, -2.0m, 3.6m, -3.3m, 0.0m };
            decimal  max, min;
            int n = 7,i;
            max = myArr[0];
            min = myArr[0];
            for (i = 0; i < n; i++)
            {
                if (myArr[i] > max)
                {
                    max = myArr[i];
                }
                if (myArr[i]<min)
                {
                    min = myArr[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            
        }
    }
}
