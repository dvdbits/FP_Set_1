using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;

            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                k = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception error)
            {
                Console.WriteLine("Va rog introduceti numere intregi!");
                Console.ReadKey();
                return;
            }

            if (n % k == 0)
            {
                Console.WriteLine(n + " divide " + k);
            }
            else
            {
                Console.WriteLine(n + " nu divide " + k);
            }

            Console.ReadKey();
        }
    }
}
