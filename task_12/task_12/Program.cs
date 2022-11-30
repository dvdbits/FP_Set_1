using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b;

            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception error)
            {
                Console.WriteLine("Va rog introduceti numere intregi!");
                Console.ReadKey();
                return;
            }


            if (a > b)
            {
                (a, b) = (b, a);
            }

            if (n > b)
            {
                Console.WriteLine(0);
            }
            else
            {
                int d1 = a / n;
                if (a % n != 0)
                {
                    d1++;
                }
                int d2 = b / n;

                Console.WriteLine(d2 - d1 + 1);
            }

            Console.ReadKey();
        }
    }
}
