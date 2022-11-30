using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            try
            {
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception error)
            {
                Console.WriteLine("Va rog introduceti numere reale!");
                Console.ReadKey();
                return;
            }

            double x = -b / a;
            Console.WriteLine("x : " + x);
            Console.ReadKey();
        }
    }
}
