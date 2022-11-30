using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c;

            try
            {
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception error)
            {
                Console.WriteLine("Va rog introduceti numere reale!");
                Console.ReadKey();
                return;
            }


            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Laturile unui triunghi nu pot avea valore mai mica sau egala cu 0!");
                Console.ReadKey();
                return;
            }


            if (a < b + c && b < a + c && c < a + b)
            {
                Console.WriteLine("Numerele pot fi laturi ale unui triunghi");
            }
            else
            {
                Console.WriteLine("Numerele nu pot fi laturi ale unui triunghi");
            }

            Console.ReadKey();
        }
    }
}
