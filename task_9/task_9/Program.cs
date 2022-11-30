using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception error)
            {
                Console.WriteLine("Va rog introduceti un numar intreg!");
                Console.ReadKey();
                return;
            }

            int d;
            n = Math.Abs(n);
            for (d = 1; d * d < n; ++d)
            {
                if (n % d == 0)
                {
                    Console.Write(-d + " " + d + " " + -(n / d) + " " + (n / d) + " ");
                }
            }

            if (d * d == n)
            {
                Console.Write(-d + " " + d);
            }

            Console.ReadKey();
        }
    }
}
