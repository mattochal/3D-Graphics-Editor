using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Multiplesof3and5
{
    class SumDigits
    {
        static void Main()
        {
            double[] num = new double[100];

            double sum = 0;

            string[] rows = System.IO.File.ReadAllLines(@"C:\Users\Mateusz\Desktop\numbers.txt");

            foreach(string row in rows)
            {
                sum += Convert.ToInt64(row.Substring(0,13));
            }
            Console.WriteLine(sum);
            }
        }
    }
