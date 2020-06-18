/* Nathan Peereboom
 * June 18, 2020
 * Unit 5 Summative: Red Green or Blue
 * Started at 2:00 PM. Finished at 3:10 PM (My computer took 15 minutes to restart during this time).
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _312840RGorB
{
    class Program
    {
        static int greyTiles = 7;
        static int redLength = 2;
        static int greenLength = 3;
        static int blueLength = 4;
        

        static void Main(string[] args)
        {
            Console.WriteLine("Please wait. This will be a moment.");

            Console.WriteLine("Red: " + Tile(redLength, greyTiles).ToString());
            Console.WriteLine("Green: " + Tile(greenLength, greyTiles).ToString());
            Console.WriteLine("Blue: " + Tile(blueLength, greyTiles).ToString());

            Console.ReadLine();
        }

        static long Tile(int length, int space)
        {
            int position = 0;
            long count = 1;
            bool stuck = false;
            while (!stuck)
            {
                if (position >= length)
                {
                    count += Tile(length, position);
                }
                if (position + length < space)
                {
                    position += 1;
                    count += 1;
                }
                else
                {
                    stuck = true;
                }
            }//end while
            return count;
        }
    }
}
