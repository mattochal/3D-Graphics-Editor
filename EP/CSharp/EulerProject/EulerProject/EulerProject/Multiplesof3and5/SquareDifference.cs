using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Multiplesof3and5
{
    class SquareDifference
    {
        static void Main()
        {
            int a;
            int sumone = 0;
            int sumtwo = 0;
            for (a = 1; a < 101; a++)
            {
                sumone += a * a;
                sumtwo += a;
            }
            sumtwo = sumtwo * sumtwo;
            
            Console.WriteLine(sumone);

            Console.WriteLine(sumtwo);

            Console.WriteLine(sumone-sumtwo);

        }
    }
}
