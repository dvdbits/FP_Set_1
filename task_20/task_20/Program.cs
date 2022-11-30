using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_20
{
    class Program
    {
        static void Main(string[] args)
        {
            // m/n

            int m, n;
            
            try
            {
                m = Convert.ToInt32(Console.ReadLine());
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception err)
            {
                Console.WriteLine("Va rog introduceti numere intregi!");
                Console.ReadKey();
                return;
            }

            if (n == 0)
            {
                Console.WriteLine("numitorul nu poate fi 0!");
                Console.ReadKey();
                return;
            }

            if (m == 0)
            {
                Console.Write(0);
                Console.ReadKey();
                return;
            }


            int x = gcd(m, n);
            m /= x;
            n /= x;

            int auxN = n;
            while (auxN % 2 == 0)
            {
                auxN /= 2;
            }
            while (auxN % 5 == 0)
            {
                auxN /= 5;
            }


            if (auxN == 1)
            {
                decimal result = (decimal)(Convert.ToDecimal(m) / Convert.ToDecimal(n));
                Console.Write(result);
                Console.ReadKey();
                return;
            }


            int integerPart = m / n;
            int rest = m % n;


            List<int> digits = new List<int>();
            List<int> rests = new List<int>();

            Console.Write(integerPart + ".");
            rests.Add(rest);

            while (rest != 0)
            {
                int digit = rest * 10 / n;
                digits.Add(digit);

                rest = rest * 10 % n;

                if (rests.Contains(rest))
                {
                    break;
                }
                else
                {
                    rests.Add(rest);
                }
            }

            for (int i = 0; i < rests.Count; i++)
            {
                if (rests[i] == rest)
                {
                    Console.Write("(");
                }

                Console.Write(digits[i]);
            }

            Console.Write(")");

            Console.ReadKey();
        }

        static int gcd(int a, int b)
        {

            while(b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }

            return a;
        }

    }
}
