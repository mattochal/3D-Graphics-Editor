using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Multiplesof3and5
{
    class AdjecentProduct
    {
        static void Main()
        {
            string[] rows = System.IO.File.ReadAllLines(@"C:\Users\Mateusz\Desktop\table.txt");

            int[,] num  = new int[21,21];

            int j = 0;

            foreach (string row in rows)
            {
                Console.WriteLine(row);
                for (int i = 0; i < (row.Length/3)+1; i++)
                {
                    num[j,i] = Convert.ToInt32(row.Substring(3 * i, 2));
                }
                j++;
            }

            int max = 0;
            int maxmax = 0;
            
            for (int b = 0; b < 21; b++)
            {
                for (int a = 0; a < 21-3; a++)
                {
                    max = (num[b, a] * num[b, a + 1] * num[b, a + 2] * num[b, a + 3]);
                    if (max > maxmax)
                    {
                        maxmax = max;
                        Console.WriteLine("{0}, {1}, {2}, {3}", num[b, a], num[b, a+1], num[b, a+2], num[b, a+3]);
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("asdfasdgfsadbdf");
            Console.WriteLine();
            for (int b = 0; b < 21; b++)
            {
                for (int a = 0; a < 21 - 3; a++)
                {
                    max = (num[a,b] * num[a + 1, b] * num[a + 2, b] * num[a + 3, b]);
                    if (max > maxmax)
                    {
                        maxmax = max;
                        Console.WriteLine("{0}, {1}, {2}, {3}", num[a, b], num[a + 1, b], num[a + 2, b], num[a + 3, b]);
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("asdfasdgfsadbdf");
            Console.WriteLine();
            for (int b = 0; b < 21-3; b++)
            {
                for (int a = 0; a < 21 - 3; a++)
                {
                    max = (num[a, b] * num[a + 1, b + 1] * num[a + 2, b + 2] * num[a + 3, b + 3]);
                    //Console.WriteLine(max);
                    //Console.Read();

                    if (max > maxmax)
                    {
                        maxmax = max;
                        Console.WriteLine("{0}, {1}, {2}, {3}", num[a, b], num[a + 1, b+1], num[a + 2, b+2], num[a + 3, b+3]);
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine("asdfasdgfsadbdf");
            Console.WriteLine();
            for (int b = 3; b < 21; b++)
            {
                for (int a = 0; a < 21 - 3; a++)
                {
                    max = (num[a, b] * num[a + 1, b - 1] * num[a + 2, b - 2] * num[a + 3, b - 3]);
                    //Console.WriteLine(max);
                    //Console.Read();

                    if (max > maxmax)
                    {
                        maxmax = max;
                        Console.WriteLine("{0}, {1}, {2}, {3}", num[a, b], num[a + 1, b - 1], num[a + 2, b - 2], num[a + 3, b - 3]);
                        Console.WriteLine();
                    }
                }
            }


            Console.WriteLine(maxmax);

            max = (num[0, 0] * num[1, 0] * num[2, 0] * num[3, 0]);
            Console.WriteLine(max);

            max = (num[0, 0] * num[0, 1] * num[0, 2] * num[0, 3]);
            Console.WriteLine(max);

            max = (num[0, 0] * num[1, 1] * num[2,2] * num[3, 3]);
            Console.WriteLine(max);


        }
    }
}
