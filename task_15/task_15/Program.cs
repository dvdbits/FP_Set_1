using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a, b, c;
            try
            {
                a = Convert.ToDecimal(Console.ReadLine());
                b = Convert.ToDecimal(Console.ReadLine());
                c = Convert.ToDecimal(Console.ReadLine());
            }
            catch ( Exception error)
            {
                Console.WriteLine("Va rog introduceti numere reale");
                Console.ReadKey();
                return;
            }


            if (a > b)
            {
                (a, b) = (b, a);
            }
            if (a > c)
            {
                (a, c) = (c, a);
            }
            if (b > c)
            {
                (b, c) = (c, b);
            }

            Console.WriteLine(a + " " + b + " " + c);
            Console.ReadKey();
        }
    }
}
