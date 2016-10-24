using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ica12_jake_wilkins
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int squareSize = 0;     //input from user on square size, must be between 10-200
            int squareX = 0;
            int squareY = 0;

            //title
            Console.WriteLine("\t\t\tCheckerboard Draw");

            //input from user, check to make sure valid input
            do
            {
                Console.Write("\nEnter the size of the squares: ");
                while (int.TryParse(Console.ReadLine(), out squareSize) == false)
                {
                    Console.WriteLine("\nAn incorrect character was entered.");
                    Console.Write("\nEnter the size of the squares: ");
                }
                if (squareSize < 20 || squareSize > 200)
                {
                    Console.WriteLine("\nThe value entered is out of range.");
                    squareSize = 0;
                }

                //this is the correct input and will draw based upon the input
                else if (600 % squareSize == 0 && 800 % squareSize == 0)
                {
                    CDrawer gdi = new CDrawer();
                    for (squareY = 0; squareY < 600; squareY = squareY + squareSize)
                    {
                        for (squareX = 0; squareX < 800; squareX = squareX + squareSize)
                        {
                            if (((squareX / squareSize) + (squareY / squareSize)) % 2 == 0)
                            {
                                gdi.AddRectangle(squareX, squareY, squareSize, squareSize, Color.CadetBlue);
                            }
                            else
                            {
                                gdi.AddRectangle(squareX, squareY, squareSize, squareSize, Color.Maroon);
                            }                                       
                        }
                    }
                }

                else
                {
                    Console.WriteLine("\nThe value is not evenly divisable.");
                    squareSize = 0;
                }
            } while (squareSize == 0);

            //pause to view then exit
            Console.Write("\nPress any key to exit... ");
            Console.ReadKey();
        }
    }
}

