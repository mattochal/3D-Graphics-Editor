using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Fibonacii
{
    class FibonacciSequeance
    {
        static void Main()
        {
            int newi = 1;
            int lasti = 0;
            int nexti = 1;

            int sum = 0;

            while (nexti < 4000001)
            {
                /*Console.WriteLine(nexti);
                Console.Read();*/
                if (nexti % 2 == 0)
                {
                    sum = sum + nexti;
                }

                lasti = newi;
                newi = nexti;
                nexti = newi + lasti;
            }
            Console.WriteLine(sum);

        }
    }
}
