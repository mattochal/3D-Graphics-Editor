using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Multiplesof3and5
{
    class Problem16
    {
        static void Main()
        {
            int[] num = new int[400];

            for(int i = 0; i<num.Length; i++)
            {
                num[i] = 0;
            }

            num[num.Length -1] = 2;

            for (int y = 1; y < 1000; y++)
            {
                int x = 399;
                int tc1 = 0;
                int tc2 = 0;

                while (((num[x] != 0)||(num[x-1] != 0)||(num[x-2] != 0)||(num[x-3] != 0)||(num[x-4] != 0)) || (tc2 != 0))
                {
                    if (num[x] >= 5) 
                    { 
                        tc1 = 1; 
                        num[x] = num[x] - 5;
                    }
                    else { tc1 = 0; }
                    
                    num[x] = 2 * num[x] + tc2;

                    tc2 = tc1;
                    x--;

                }
            }

            int t = 0;

            foreach(int c in num)
            {
                t = t + c;
                Console.Write(c);
            }

            Console.WriteLine("The total is: " + t);
            Console.ReadLine();
        }
    }
}
