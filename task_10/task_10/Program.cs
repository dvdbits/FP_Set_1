using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10
{
    class Program
    {


        static bool isPrime(int n)
        {
            if(n == 2)
            {
                return true;
            }

            if(n < 2 || n % 2 == 0)
            {
                return false;
            }


            for(int d = 3; d * d <= n; d += 2)
            {
                if(n % d  == 0)
                {
                    return false;
                } 
            }

            return true;
        } 


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
            catch(Exception error)
            {
                Console.WriteLine("Va rog introduceti un numar pozitiv intreg!");
                Console.ReadKey();
                return;
            }


            if (isPrime(n))
            {
                Console.WriteLine(n + " este prim");
            }
            else
            {
                Console.WriteLine(n + " nu este prim");
            }

            Console.ReadKey();
        }
    }
}
