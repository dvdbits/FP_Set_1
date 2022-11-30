using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_13
{
    class Program
    {
        static void Main(string[] args)
        {

            int y1, y2;

            try
            {
                y1 = Convert.ToInt32(Console.ReadLine());
                y2 = Convert.ToInt32(Console.ReadLine());

                if(y1 < 0 || y2 < 0)
                {
                    throw new Exception("");
                }

            }
            catch ( Exception error)
            {
                Console.WriteLine("Va rog introduceti numere intregi pozitive!");
                Console.ReadKey();
                return;
            }


            if (y1 > y2)
            {
                (y1, y2) = (y2, y1);
            }

            int res = 0;
            for (int i = y1 + 1; i < y2; ++i)
            {
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                {
                    res++;
                }
            }
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
