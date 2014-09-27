using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Multiplesof3and5
{
    class MultiplesOfThreeFive
    {
        static void Main()
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {

                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
