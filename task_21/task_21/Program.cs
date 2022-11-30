using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Raspundeti cu 'da' sau 'nu' ");

            int a = 1, b = 1024;

            while (a < b)
            {
                int m = (a + b) / 2;

                Console.WriteLine("Numarul este mai mare sau egal decat " + m + "?");
            

                string answer = Console.ReadLine();
                while(answer != "da" && answer != "nu")
                {
                    Console.WriteLine("Raspuns gresit, mai incercati o data!");
                    answer = Console.ReadLine();
                }


                if (a + 1 == b)
                {
                    (a, b) = (b, a);
                }
                else if (answer == "da")
                {
                    a = m;
                }
                else if(answer == "nu")
                {
                    b = m;
                }

                
            }

            Console.WriteLine("Numarul este : " + b);
            Console.ReadKey();
        }
    }
}
