using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());

            }
            catch(Exception error)
            {
                Console.WriteLine("Va rog introduceti numere intregi!");
                Console.ReadKey();
                return;
            }

            int multiple = a * b;

            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }

            Console.WriteLine("cel mai mare divizor comun : " + a);
            Console.WriteLine("cel mai mic multiplu comun : " + multiple / a);

            Console.ReadKey();
        }
    }
}
