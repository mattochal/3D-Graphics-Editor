using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApplication2
{
    class image
    {
        public string path = "Desktop";
        Bitmap myBitmap = new Bitmap("Grapes.jpg");

        public int[,,] PxArray;



        public void FindBoxes()
        {
            for (int y = 0; y < 50; y++)
            {
                for (int x = 0; x < 50; x++)
                {
                    PxArray[x, y, 0] = (myBitmap.GetPixel(x, y).R + myBitmap.GetPixel(x, y).G + myBitmap.GetPixel(x, y).B);
                }
            }

            for (int y = 0; y < 50; y++)
            {
                for (int x = 0; x < 50; x++)
                {
                    if (PxArray[x, y, 0] < 200) //Black
                    {
                            
                    }
                }
            }



            
        }

        public void FindLetter()
        {
        }

    }
    class Program
    {
        static void Main()
        {
        }
    }
}
