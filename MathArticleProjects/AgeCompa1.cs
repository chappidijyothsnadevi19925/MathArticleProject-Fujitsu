using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathArticleProjects
{
    internal class AgeCompa1
    {
        static void Main4(String[] args)
        {
            int a1 = 45, a2 = 45, a3 = 45;
            if (a1 == a2 && a2 == a3)
            {
                Console.WriteLine("Smith,Jhon,Henry");
            }
            else if (a1 <= a2 && a1 <= a3)
            {
                Console.WriteLine("Smith");

            }
            else if (a2 <= a3 && a2 <= a1)
            {
                Console.WriteLine("Jhon");
            }
            else
            {
                Console.WriteLine("Henry");
            }
        }
    }
}
