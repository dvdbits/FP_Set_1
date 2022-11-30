using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_19
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
            catch(Exception err)
            {
                Console.WriteLine("Va rog introduceti un numar pozitiv intreg!");
                Console.ReadKey();
                return;
            }


            int[] v = new int[10];

            while (n != 0)
            {
                int d = n % 10;
                v[d] = 1;
                n /= 10;
            }

            int temp = 0;

            for (int i = 0; i < 10; ++i)
            {
                if (v[i] == 1)
                {
                    temp++;
                }
            }

            if (temp == 2)
            {
                Console.WriteLine("numarul este format numai din 2 cifre");
            }
            else
            {
                Console.WriteLine("numarul este format din mai putin sau mai mult de 2 cifre");
            }

            Console.ReadKey();
        }
    }
}
