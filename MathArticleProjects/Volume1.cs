using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathArticleProjects
{
    internal class Volume1
    {
        static void Main(String[] args)
        {
            double res = Volume.VolumeOfSphere(15.5);
            Console.WriteLine(res);

            double res1 = Volume.VolumeOfCylinder(15.5, 65.2);
            Console.WriteLine(res1);

            double res2 = Volume.VolumeOfCuboid(20, 20.5, 65.2);
            Console.WriteLine(res2);

            double res3 = Volume.VolumeOfCone(15.5, 65.2);
            Console.WriteLine(res3);
        }

    }
}
