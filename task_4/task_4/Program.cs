using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;

            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception error)
            {
                Console.WriteLine("Va rog introduceti un numar intreg!");
                Console.ReadKey();
                return;
            }

            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;

            if (isLeapYear)
            {
                Console.WriteLine(year + " este an bisect");
            }
            else
            {
                Console.WriteLine(year + " nu este an bisect");
            }

            Console.ReadKey();
        }
    }
}
