using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathArticleProjects
{
    internal class ArrayMaxMin
    {
        static void Main12(String[] args)
        {
            decimal[] myArr = { 5.0m, 11.0m, 12.5m, -2.0m, 3.6m, -4.3m, 9.0m };
            decimal max, min;
            int n = 7, i;
            max = myArr[0];
            min = myArr[0];
            for (i = 0; i < n; i++)
            {
                if (myArr[i] > max)
                {
                    max = myArr[i];
                }
                if (myArr[i] < min)
                {
                    min = myArr[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);

        }
    }
}
