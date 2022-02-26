using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparOops
{
    public class Compare
    {
        public int x1;
        public int x2;

        public int y1;

        public int y2;

        public int a1;

        public int a2;

        public int b1;

        public int b2;
        public void Uu()
        {
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());




            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());



            double L1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of 1st Line :" + L1);

            Console.WriteLine();
            double L2 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            Console.WriteLine("Length of 1st Line :" + L2);


            if (L1 == L2)
            {
                Console.WriteLine("Equeals are two line");
            }
            else
            {
                Console.WriteLine("Two Lines Are not Equals");
            }

            if (L1 > L2)
            {
                Console.WriteLine("1st Line is Gratet to 2nd Line");
            }
            else
            {
                Console.WriteLine("2nd line is grater to 1st line");
            }
        }
    }
}
    

