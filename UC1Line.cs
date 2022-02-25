using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesionUC1
{
    public class UC1Line
    {
        public static int a;

        public static int b;

        public static int c;

        public static int d;

        public void comp(int a, int b, int c, int d)

        {
            int x1 = a;

            int y1 = b;

            int x2 = c;

            int y2 = d;


            if (x1 < 0 || y1 < 0 || x2 < 0 || y2 < 0)

            {
                Console.WriteLine("Please enter positive number");
            }

            else if (x1 == 0 || y1 == 0 || x2 == 0 || y2 == 0)
            {
                Console.WriteLine("Please enter greater than zero");
            }

            else
            {

                double g = Math.Pow((x2 - x1), 2);
                double h = Math.Pow((y2 - y1), 2);
                double length = g + h;

                Console.WriteLine(g);
                Console.WriteLine(h);




                Console.WriteLine("The Length Of Cart" + length + "in cm");

            }



        }




    }
}
