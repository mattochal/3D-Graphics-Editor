using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorGen
{
    class Program
    {
        static void Main(string[] args)
        {
            const int lim = 100000;
            bool[] primes = new bool [lim];

            for (int i = 0; i < lim; i++)
            {
                primes[i] = true;
            }

            for (int i = 2; i < lim; i++)
            {
                if (primes[i] == true)
                {
                    for (int j = 2; j < lim / i; j++)
                    {
                        primes[j * i] = false;
                    } 

                } 
            }
            
        }
    }
}
