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
            int[] sums = new int[8];


            /***int counter = 0;
            int checksize = 3; 


            for (int a = 0; a < sums.Length; a++)
            {
                for (int b = 0; b < 8; b++)
                {
                    sums[counter] = nums[b,0]; 
                }
            }***/

            for (int a = 0; a < 2; a++)
            {
                sums[4 * a + 0] = nums[0, 0+a] + nums[1, 0+a] + nums[2, 0+a];
                sums[4 * a + 1] = nums[0, 0 + a] + nums[1, 0 + a] + nums[2, 1 + a];
                sums[4 * a + 2] = nums[0, 0 + a] + nums[1, 1 + a] + nums[2, 1 + a];
                sums[4 * a + 3] = nums[0, 0 + a] + nums[1, 1 + a] + nums[2, 1 + a];
            }

            //Console.ReadLine();

            if  (Array.IndexOf(sums, sums.Max()) < 4)
            {
                return false;
            }   else return true;

        }

        public static void Main()
        {
            const int size = 105;
 
            int counter = 0;
            int i;


            int[,] numbers = new int[size, size];

            for (int numI = 0; numI < size; numI++)
            {
                for (int numJ = 0; numJ < size; numJ++)
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
            System.IO.StreamReader file = new System.IO.StreamReader("c:\\Users\\Mateusz\\Desktop\\EP\\CSharp\\Problem67.txt");

            string line;

            while ((line = file.ReadLine()) != null)
            {
                i = 0;
                Console.WriteLine(line.Length);

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

            for (counter = 0; counter < 80; counter++)
            {
                int[,] subnums = new int[3,4];
                for (i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
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

        }
    }
}
