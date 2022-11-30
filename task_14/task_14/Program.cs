using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception error)
            {
                Console.WriteLine("Va rog introuceti un numar intreg!");
                Console.ReadKey();
                return;
            }


            char[] temp = n.ToString().ToCharArray();
            Array.Reverse(temp);

            string nReversed = new string(temp);

            if (n.ToString() == nReversed)
            {
                Console.WriteLine(n + " este un numar palindrom");
            }
            else
            {
                Console.WriteLine(n + " nu este un numar palindrom");
            }

            Console.ReadKey();
        }
    }
}
