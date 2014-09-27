using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Multiplesof3and5
{
    class TriangularNumber
    {
        
        static void Main()
        {
            long[] TriNums = new long[100000];
            long n = 0;

            long i = 2015;

            while(n < 500)
            {
                n = 2;
                TriNums[i] =(i * (i + 1))/2;

                for (long d = TriNums[i] - 1; d > 1; d--)
                {
                    if (TriNums[i] % d == 0) { n++; };
                }

                Console.WriteLine(i);
                Console.WriteLine(n);
                Console.WriteLine("===");
                i++;

            }

            Console.WriteLine("The number is " + Convert.ToString(TriNums[i-1]));
            Console.WriteLine(n-1);
            Console.WriteLine(i-1);
            Console.ReadLine();

        }
    }
}

