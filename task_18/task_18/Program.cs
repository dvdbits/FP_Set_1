using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());

                if(n < 0)
                {
                    throw new Exception("");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Va rog introduceti un numar pozitiv intreg!");
                Console.ReadKey();
                return;
            }

            int d = 2;
            while (n != 1)
            {
                int p = 0;

                while (n % d == 0)
                {
                    p++;
                    n /= d;
                }

                if (p > 0)
                {
                    Console.Write(d + "^" + p + " ");
                }

                d++;
            }

            Console.ReadKey();
        }
    }
}
