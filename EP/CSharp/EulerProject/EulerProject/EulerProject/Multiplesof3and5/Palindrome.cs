using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Multiplesof3and5
{
    class Palindrome
    {

        public Palindrome()
        {
            string sum;
            int a = 999;
            int b = 999;
            string revsum = "..........";

            do
            {
                b = 999;
                do
                {
                    sum = Convert.ToString(a * b);
                    char[] array = sum.ToCharArray();

                    for (int c = 0; c < sum.Length; c++)
                    {
                        //array[c] = sum[sum.Length - c];
                        revsum = string.Join(string.Empty,sum.Reverse());//this.method1(sum);//Convert.ToString(array);
                    }
                    b--;

                } while (sum != revsum && b > 913);
                a--;

            } while (sum != revsum);
            Console.WriteLine("{0} * {1} = {2}", a,b, sum);

           
        }
        /*
    public string method1(string s1)
        {
            return s1;
        }*/

        static void Main()
        {
            new Palindrome();
        }
    }
}
