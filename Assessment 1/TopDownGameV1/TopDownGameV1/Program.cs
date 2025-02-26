using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace TopDownGameV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Grab and store map data as characters
            //* y0 x0,y0 x1,y0 x2
            // * y1 x0,y1 x1,y1 x2 
            char[,] map = //[y,x]
            {
                {'.','.','.','.','.' },
                {'.','.','.','.','.' },
                {'.','.','.','.','.' },
                {'.','.','.','.','.' },
                {'.','.','.','.','.' }

            };
            //Player data 
            int playerX = 2;
            int playerY = 2;
            char playerIcon = '#';
            //Start loop
            bool isPlaying = true;

            do
            {
                //Display Map
                Console.Clear();
                string mapDisplay = "";
                for (int y = 0; y < map.GetLength(0); y++)
                {
                    for (int x = 0; x < map.GetLength(1); x++)
                    {
                        //Check to see if draw plauer or map
                        if (x == playerX && y == playerY)
                        {
                            mapDisplay += " " + playerIcon;
                        }
                        else
                        {// draw map here
                            mapDisplay += " " + map[y, x];
                        }

                    }
                    mapDisplay += '\n';
                }
                Console.WriteLine(mapDisplay);


                //Get Input
                ConsoleKey playerInput = Console.ReadKey().Key;

                switch (playerInput)
                {
                    case ConsoleKey.W:
                        playerY -= 1;
                        break;
                    case ConsoleKey.S:
                        playerY += 1;
                        break;
                    case ConsoleKey.A:
                        playerX -= 1;
                        break;
                    case ConsoleKey.D:
                        playerX += 1;
                        break;

                }

            }
            while (isPlaying== true);
        }
    }
}
