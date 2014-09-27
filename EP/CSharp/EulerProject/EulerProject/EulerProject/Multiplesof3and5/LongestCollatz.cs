using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Multiplesof3and5
{
    class LongestCollatz
    {
        static void Main()
        {
            long startnum = 1000000;
            long num;
            long longest = 0;
            //int seqnum = 0;
            int n = 0;
            int c = 0;

            do
            {
                num = startnum;
                n = 1;
                do
                {
                    
                    if ((num % 2) == 0)
                    {
                        num = num / 2;
                    }
                    else
                    {
                        num = (3 * num) + 1;
                    }
                    n++;
                } while (num > 1);

                if (n >= c)
                {
                    longest = startnum;
                    c = n;
                }


                startnum--;
            } while (startnum > 1);

            Console.WriteLine("longest is {0} with length of {1}", longest, c);
            Console.ReadLine();

            /*int startnum = 1000000;
            int num;
            int longest = 0;
            //int seqnum = 0;
            int n = 0;
            int c = 0;

            do
            {
                num = startnum;
                n = 0;
                do{
                    if (num % 2 == 0)
                    {
                        num /= 2;
                    }
                    else
                    {
                        num = (3 * num) + 1;
                    }
                    n++;
                }while (num > 1);

                if (n >= c) 
                {
                    longest = startnum;
                    c = n; 
                }

                startnum--;
            } while (startnum > 1);

            Console.WriteLine("longest is {0} with length of {1}", longest, c);
            Console.ReadLine();*/
        }
    }
}
