/*Implement the "Falling Rocks" game in the text console.
 * A small dwarf stays at the bottom of the screen and
 * can move left and right (by the arrows keys). A number
 * of rocks of different sizes and forms constantly fall 
 * down and you need to avoid a crash.*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


class FallingRocks
{
    struct Object
    {
        public int x;
        public int y;
        public char symbol;
        public ConsoleColor color;
    }

    static void PrintOnPosition(int x, int y, char symbol, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(symbol);
    }

    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        // Remove console buffer
        Console.BufferHeight = Console.WindowHeight = 30;
        Console.BufferWidth = Console.WindowWidth = 60;
        Random randomGenerator = new Random();
        List<Object> rockList = new List<Object>();
        char[] typesOfRocks = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        int speed = 0;
        ulong score = 0;
        ulong bestScore = 0;
        int initLives = 4;
        int livesAfterChange = 0;

        // Initialize dwarf
        Object dwarf = new Object();
        dwarf.x = 14;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.symbol = '8';
        dwarf.color = ConsoleColor.White;

        PrintStringOnPosition(1, 10, "Try to avoid the falling rocks, while collecting bonuses.", ConsoleColor.Yellow);
        PrintStringOnPosition(17, 11, "Press any key to start ...", ConsoleColor.Yellow);
        Console.ReadKey();
        while (true)
        {
            bool hitted = false;
            bool liveUp = false;
            bool speedDown = false;
            int rockType = randomGenerator.Next(0, 101);
            if (rockType >= 0 && rockType < 95)
            {
                Object fallingRock = new Object();
                fallingRock.x = randomGenerator.Next(0, Console.WindowWidth/2 - 1);
                fallingRock.y = 6;
                fallingRock.color = ConsoleColor.Green;
                fallingRock.symbol = typesOfRocks[randomGenerator.Next(0, 10)];
                rockList.Add(fallingRock);
            }
            if (rockType >= 95 && rockType < 97)
            {
                Object fallingRock = new Object();
                fallingRock.x = randomGenerator.Next(0, Console.WindowWidth/2 - 1);
                fallingRock.y = 6;
                fallingRock.color = ConsoleColor.Red;
                fallingRock.symbol = '\u00D5';
                rockList.Add(fallingRock);
            }
            if (rockType >= 97 && rockType < 101)
            {
                Object fallingRock = new Object();
                fallingRock.x = randomGenerator.Next(0, Console.WindowWidth/2 - 1);
                fallingRock.y = 6;
                fallingRock.color = ConsoleColor.Red;
                fallingRock.symbol = '\u00A9';
                rockList.Add(fallingRock);
            }

            // Move the dwarf
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);

                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x < Console.WindowWidth/2 - 1)
                    {
                        dwarf.x++;
                    }
                }
            }

            // Moving the rocks
            List<Object> newList = new List<Object>();
            for (int i = 0; i < rockList.Count; i++)
            {
                Object oldRock = rockList[i];
                Object fallingRock = new Object();
                fallingRock.x = oldRock.x;
                fallingRock.y = oldRock.y + 1;
                fallingRock.color = oldRock.color;
                fallingRock.symbol = oldRock.symbol;

                for (int j = 0; j < typesOfRocks.Length; j++)
                {
                    if (fallingRock.symbol != '\u00A9' && fallingRock.symbol != '\u00D5' && fallingRock.x == dwarf.x && fallingRock.y == dwarf.y)
                    {
                        hitted = true;
                    }
                    if (fallingRock.symbol == '\u00A9' && fallingRock.x == dwarf.x && fallingRock.y == dwarf.y)
                    {
                        liveUp = true;
                    }
                    if (fallingRock.symbol == '\u00D5' && fallingRock.x == dwarf.x && fallingRock.y == dwarf.y)
                    {
                        speedDown = true;
                    }
                   
                    if (fallingRock.y == dwarf.y && fallingRock.x != dwarf.x)
                    {
                        score += 1;
                        if (speed > 190)
                        {
                            score += 5;
                        }
                    }
                }
                if (speed > 50 && fallingRock.symbol == '\u00D5' && fallingRock.x == dwarf.x && fallingRock.y == dwarf.y)
                {
                    speed = speed - 50;
                }
                if (fallingRock.symbol == '\u00A9' && fallingRock.x == dwarf.x && fallingRock.y == dwarf.y)
                {
                    int livesChange = initLives + 1;
                    initLives = livesChange;
                }
                if (fallingRock.y < Console.WindowHeight)
                {
                    newList.Add(fallingRock);
                }
            }
            rockList = newList;

            // Clear console
            Console.Clear();

            PrintStringOnPosition(19, 1, "FALLING ROCKS GAME", ConsoleColor.Blue);
            //Draw gamefield
                // Draw '*' box
            for (int i = 0; i < Console.WindowWidth/2 + 5; i++)
            {
                PrintOnPosition(i, 5, '*', ConsoleColor.Gray);
            }

            for (int i = 5; i < Console.WindowHeight; i++)
            {
                PrintOnPosition(Console.WindowWidth/2 + 5, i, '*', ConsoleColor.Gray);
                //PrintOnPosition(Console.WindowWidth - 2, i, '*', ConsoleColor.Gray);
            }

                 // Draw Dwarf
            if (hitted)
            {
                int livesChange = initLives - 1;
                initLives = livesChange;
                rockList.Clear();
                speed = 0;
                score = 0;
                PrintOnPosition(dwarf.x, dwarf.y, 'X', ConsoleColor.Red);
                PrintStringOnPosition(22, 3, "YOU WERE HIT!", ConsoleColor.Red);
                PrintStringOnPosition(15, 4, "Press any key to continue", ConsoleColor.Red);
                Console.ReadKey();
            }
            if (liveUp)
            {
                PrintStringOnPosition(dwarf.x, dwarf.y - 1, "1 Up", ConsoleColor.Cyan);
            }
            if (speedDown)
            {
                PrintStringOnPosition(dwarf.x, dwarf.y-1, "Speed", ConsoleColor.Yellow); 
            }
            else
            {
                PrintOnPosition(dwarf.x, dwarf.y, dwarf.symbol, dwarf.color);
            }

                  // Draw the falling rocks
            foreach (Object rock in rockList)
            {
                PrintOnPosition(rock.x, rock.y, rock.symbol, rock.color);
            }

                // Draw info
            PrintStringOnPosition(38, 7, "Speed: " + speed, ConsoleColor.Red);
            PrintStringOnPosition(38, 8, "Lives: " + initLives, ConsoleColor.Cyan);
            PrintStringOnPosition(38, 9, "Score: ", ConsoleColor.Magenta);
            PrintStringOnPosition(38, 10, " "+ score, ConsoleColor.Magenta);
            PrintStringOnPosition(38, 11, "Best Score: ", ConsoleColor.Yellow);
            PrintStringOnPosition(38, 12, " " + bestScore, ConsoleColor.Yellow);
            PrintStringOnPosition(38, 15, "Collect: ", ConsoleColor.DarkYellow);
            PrintStringOnPosition(38, 16, " \u00D5 - Speed Slow Down", ConsoleColor.Red);
            PrintStringOnPosition(38, 17, " \u00A9 - Additional Lives", ConsoleColor.Red);

            //Slowdown console
            Thread.Sleep(250 - speed);

            // Speed and lives condition
            if (initLives == 0)
            {
                PrintStringOnPosition(22, 3, "GAME OVER !!!", ConsoleColor.Red);
                Environment.Exit(0);
            }
            if (speed < 230)
            {
                speed += 1;
            }
            if (score > bestScore)
            {
                bestScore = score;
            }
        }
    }
}