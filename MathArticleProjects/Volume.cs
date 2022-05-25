using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathArticleProjects
{
    internal class Volume
    {
        public static double VolumeOfSphere(double r)
        {
            return (4 / 3) * 3.14 * r * r;
        }
        public static double VolumeOfCylinder(double r1,double h)
        {
            return 3.14 * r1 * r1 * h;
        }
        public static double VolumeOfCuboid(double l,double b,double h1)
        {
            return l * b * h1;
        }
        public static double VolumeOfCone(double r2,double h2)
        {
            return 3.14 * r2 * r2 * (h2 / 3);
        }
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
