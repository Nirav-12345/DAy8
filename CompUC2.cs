using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCompUC2
{
    public class CompUC2
    {

        public int x1;
        public int x2;

        public int y1;

        public int y2;

        public int a1;

        public int a2;

        public int b1;

        public int b2;

        public  void UC2()
        {
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());




            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            double length1 = Math.Sqrt(Math.Pow((x2 - x1), 2)) + Math.Sqrt(Math.Pow((y2 - y1), 2));
            double length2 = Math.Sqrt(Math.Pow((a2 - a1), 2)) + Math.Sqrt(Math.Pow((b2 - b1), 2));
            if (length1 == length2)
            {
                Console.WriteLine("Two are equal");
            }

            else
            {
                Console.WriteLine("Unequal");



            }
        }
    }
}
