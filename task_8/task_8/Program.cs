using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a, b;

            try
            {
                a = Convert.ToDecimal(Console.ReadLine());
                b = Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception error)
            {
                Console.WriteLine("Va rog introduceti numere reale!");
                Console.ReadKey();
                return;
            }

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);

            Console.ReadKey();
        }
    }
}
