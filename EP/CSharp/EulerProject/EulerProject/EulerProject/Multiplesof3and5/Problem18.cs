using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Multiplesof3and5
{
    class Problem18
    {

        static Boolean Right(int[,] nums)
        {
            int[] sums = new int[8];S
            sums[0] = nums[0, 0] + nums[1, 0];
            sums[1] = nums[0, 0] + nums[1, 1];
            sums[2] = nums[0, 1] + nums[1, 1];
            sums[3] = nums[0, 1] + nums[1, 2];

            sums[0] = nums[0, 0] + nums[1, 0];
            sums[1] = nums[0, 0] + nums[1, 1];
            sums[2] = nums[0, 1] + nums[1, 1];
            sums[3] = nums[0, 1] + nums[1, 2];

            //Console.ReadLine();

            if  (Array.IndexOf(sums, sums.Max()) < 2)
            {
                return false;
            }   else return true;

        }

        public static void Main()
        {
            int counter = 0;
            int i;


            int[,] numbers = new int[18,18];

            for (int numI = 0; numI < 18; numI++)
            {
                for (int numJ = 0; numJ < 18; numJ++)
                {
                    numbers[numI, numJ] = 0;
                }
            }

            numbers[0, 0] = 3;
            numbers[1, 0] = 7;
            numbers[2, 0] = 2;
            numbers[3, 0] = 8;
            numbers[1, 1] = 4;
            numbers[2, 1] = 4;
            numbers[3, 1] = 5;
            numbers[2, 2] = 6;
            numbers[3, 2] = 9;
            numbers[3, 3] = 3;

             // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader("c:\\Users\\Mateusz\\Desktop\\EP\\CSharp\\Problem18.txt");

            string line;

            while ((line = file.ReadLine()) != null)
            {
                i = 0;
                do 
                {
                    numbers[counter, i] = Convert.ToInt32(line.Substring(i*3, 2));
                    i++;
                }while(i <= line.Length/3);
                counter++;
            }

            Console.WriteLine("Loaded");
             


            int[] posnum = new int[2];
            posnum[0] = 0;
            posnum[1] = 0;


            int sum = numbers[0,0];

            for (counter = 0; counter < 15; counter++)
            {
                int[,] subnums = new int[2,3];
                for (i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        subnums[i,j] = numbers[posnum[0]+i+1, posnum[1]+j];
                    }
                }


                if (Right(subnums))
                {
                    posnum[1]++;
                    //Console.WriteLine("right");
                }
                //else { Console.WriteLine("down");}

                posnum[0]++;

                sum += numbers[posnum[0], posnum[1]];


            }

            Console.WriteLine(sum);
            Console.ReadLine();



            
            //int biggest = 0;
            
            //counter= 0;

            




            /**

            if (sum > biggest)
            {
                biggest = sum;
            }

            /***
            for(int a = 0 ; a < 15; a++)
            {
                do //(int b = 0; b < 15; b++)
                {
                    sum += numbers[a,b];
                    counter++;

                } while (counter<15+1);

                if (sum > biggest)
                    {
                        biggest = sum;
                    }

                sum = 0;
            }

            /***
            int c = 0;

            foreach (int n in numbers)
            {
                
                if (c == 15)
                {
                    c = 0;
                    Console.WriteLine(); 
                }
                c++;
                Console.Write(n);
                Console.Write(' ');
            }
            Console.ReadLine();
            ***/
        }
    }
}
