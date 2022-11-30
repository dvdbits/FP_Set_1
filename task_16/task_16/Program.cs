using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_16
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a, b, c, d , e;
            try
            {
                a = Convert.ToDecimal(Console.ReadLine());
                b = Convert.ToDecimal(Console.ReadLine());
                c = Convert.ToDecimal(Console.ReadLine());
                d = Convert.ToDecimal(Console.ReadLine());
                e = Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception error)
            {
                Console.WriteLine("Va rog introduceti numere reale!");
                Console.ReadKey();
                return;
            }


            if (a > d)
            {
                (a, d) = (d, a);
            }
            if (b > e)
            {
                (b, e) = (e, b);
            }
            if (a > c)
            {
                (a, c) = (c, a);
            }
            if (b > d)
            {
                (b, d) = (d, b);
            }
            if (a > b)
            {
                (a, b) = (b, a);
            }
            if (c > e)
            {
                (c, e) = (e, c);
            }
            if (b > c)
            {
                (b, c) = (c, b);
            }
            if (d > e)
            {
                (d, e) = (e, d);
            }
            if (c > d)
            {
                (c, d) = (d, c);
            }

            Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e);

            Console.ReadKey();
        }
    }
}
