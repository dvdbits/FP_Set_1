using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
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
            catch (Exception error)
            {
                Console.WriteLine("Va rog introduceti un numar intreg!");
                Console.ReadKey();
                return;
            }

            string digits = n.ToString();

            if (n < 0)
            {
                digits = digits.Remove(0,1);
                Console.Write('-');
            }

            char[] digitsArray = digits.ToCharArray();
            Array.Reverse(digitsArray);

            Console.WriteLine(new string(digitsArray));
            Console.ReadKey();
        }
    }
}
