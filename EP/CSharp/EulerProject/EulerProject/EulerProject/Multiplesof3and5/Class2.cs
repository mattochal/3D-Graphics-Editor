using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Multiplesof3and5
{
    class Class2
    {
        static void Main()
        {
            const int sum = 1000;

            for (int a = 1; a <= sum/3; a++)
            {

                for (int b = a + 1; b <= sum/2; b++)
                {
                    int c = sum - a - b;
                    if ( c > 0 && (a*a + b*b == c*c) )
                       Console.WriteLine("a = {0}, b = {1}, c = {2}",a,b,c);
                }
            }
        }
    }
}
