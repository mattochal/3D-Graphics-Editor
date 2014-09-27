using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Multiplesof3and5
{
    class Problem10_Primes_
    {
        public static void Main()
        {
            const int size = 2000000;
            Boolean[] numbers = new Boolean[size];

            for (int n = 0; n < numbers.Length; n++)
            {
                numbers[n] = true;
            }

            //numbers[0] = true;
            //numbers[1] = true;
            double sum = 0;
            int c;
            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i] == true)
                {
                    sum += i;
                    c = 0;
                    while (c * i < size) { numbers[c * i] = false; c++; }
                }
            }

            Console.WriteLine(sum);
            Console.ReadLine(); 

            
        }
    }
}
