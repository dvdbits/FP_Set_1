using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
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
            catch ( Exception error)
            {
                Console.WriteLine("Va rog introduceti numere reale!");
                Console.ReadKey();
                return;
            }

            if(a == 0)
            {
                double x = -c / b;
                Console.WriteLine("x : " + x);
                Console.ReadKey();
                return;
            }

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Nu exista solutie reala!");
            }
            else if (delta == 0)
            {
                double x = -(b / (2 * a));

                Console.WriteLine("x : " + x);
            }
            else if (delta > 0)
            {
                double deltaSquareRoot = Math.Sqrt(delta);
                double x1 = (-b - deltaSquareRoot) / (2 * a);
                double x2 = (-b + deltaSquareRoot) / (2 * a);

                Console.WriteLine("x1 : " + x1);
                Console.WriteLine("x2 : " + x2);
            }

            Console.ReadKey();
        }
    }
}
