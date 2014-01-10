namespace MineSweeperGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MineSweeper
    {
        private static void Main(string[] args)
        {
            const int MaximumTurnsWithoutDying = 35;
            string inputPlayerCommand = string.Empty;
            char[,] minefield = CreateMinefield();
            char[,] mines = PlaceMinesInMinefield();
            int turnsCounter = 0;
            bool mineExplosion = false;
            List<PlayerDetails> highScorersList = new List<PlayerDetails>(6);
            int currentRow = 0;
            int currentColumn = 0;
            bool playerIsInMainMenu = true;
            bool turnsExceedMaxTurns = false;

            do
            {
                if (playerIsInMainMenu)
                {
                    Console.WriteLine("Lets play \"Minesweeper\". Try your luck and find all empty fields, without bomb explosion." +
                    "'top'- command shows high scores, 'restart' - starts a new game, 'exit' - exits game!");
                    MinefieldRenderer(minefield);
                    playerIsInMainMenu = false;
                }

                Console.Write("Input row and column: ");
                inputPlayerCommand = Console.ReadLine().Trim();

                if (inputPlayerCommand.Length >= 3)
                {
                    if (int.TryParse(inputPlayerCommand[0].ToString(), out currentRow) &&
                    int.TryParse(inputPlayerCommand[2].ToString(), out currentColumn) &&
                    currentRow <= minefield.GetLength(0) && currentColumn <= minefield.GetLength(1))
                    {
                        inputPlayerCommand = "turn";
                    }
                }

                switch (inputPlayerCommand)
                {
                    case "top":
                        RenderHighScoresOnConsole(highScorersList);
                        break;
                    case "restart":
                        minefield = CreateMinefield();
                        mines = PlaceMinesInMinefield();
                        MinefieldRenderer(minefield);
                        mineExplosion = false;
                        playerIsInMainMenu = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye, bye!");
                        break;
                    case "turn":
                        if (mines[currentRow, currentColumn] != '*')
                        {
                            if (mines[currentRow, currentColumn] == '-')
                            {
                                WorkPlayerInputCommand(minefield, mines, currentRow, currentColumn);
                                turnsCounter++;
                            }

                            if (MaximumTurnsWithoutDying == turnsCounter)
                            {
                                turnsExceedMaxTurns = true;
                            }
                            else
                            {
                                MinefieldRenderer(minefield);
                            }
                        }
                        else
                        {
                            mineExplosion = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command!\n");
                        break;
                }

                if (mineExplosion)
                {
                    MinefieldRenderer(mines);
                    Console.Write("\nToo bad! You died with score of: {0}. " + "Please input name: ", turnsCounter);
                    string nickname = Console.ReadLine();
                    PlayerDetails player = new PlayerDetails(nickname, turnsCounter);

                    if (highScorersList.Count < 5)
                    {
                        highScorersList.Add(player);
                    }
                    else
                    {
                        for (int scorer = 0; scorer < highScorersList.Count; scorer++)
                        {
                            if (highScorersList[scorer].Score < player.Score)
                            {
                                highScorersList.Insert(scorer, player);
                                highScorersList.RemoveAt(highScorersList.Count - 1);
                                break;
                            }
                        }
                    }

                    highScorersList.Sort((PlayerDetails firstPlayer, PlayerDetails secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    highScorersList.Sort((PlayerDetails firstPlayer, PlayerDetails secondPlayer) => secondPlayer.Score.CompareTo(firstPlayer.Score));
                    RenderHighScoresOnConsole(highScorersList);

                    minefield = CreateMinefield();
                    mines = PlaceMinesInMinefield();
                    turnsCounter = 0;
                    mineExplosion = false;
                    playerIsInMainMenu = true;
                }

                if (turnsExceedMaxTurns)
                {
                    Console.WriteLine("\nWell done! You've just cross 35 fields without dying.");
                    MinefieldRenderer(mines);
                    Console.WriteLine("Please, input your name: ");
                    string name = Console.ReadLine();
                    PlayerDetails score = new PlayerDetails(name, turnsCounter);
                    highScorersList.Add(score);
                    RenderHighScoresOnConsole(highScorersList);
                    minefield = CreateMinefield();
                    mines = PlaceMinesInMinefield();
                    turnsCounter = 0;
                    turnsExceedMaxTurns = false;
                    playerIsInMainMenu = true;
                }
            }
            while (inputPlayerCommand != "exit");

            Console.WriteLine("You are playing \"Minesweeper\"!");
            Console.WriteLine("Hope you're having fun.");
            Console.Read();
        }

        private static void RenderHighScoresOnConsole(List<PlayerDetails> players)
        {
            Console.WriteLine("\nSCORES:");

            if (players.Count > 0)
            {
                for (int player = 0; player < players.Count; player++)
                {
                    Console.WriteLine("{0}. {1} --> {2} empty fields", player + 1, players[player].Name, players[player].Score);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No scores!\n");
            }
        }

        private static void WorkPlayerInputCommand(char[,] gamefield, char[,] placedBombs, int row, int column)
        {
            char bombsCount = GetBombsCount(placedBombs, row, column);
            placedBombs[row, column] = bombsCount;
            gamefield[row, column] = bombsCount;
        }

        private static void MinefieldRenderer(char[,] board)
        {
            int minefieldRows = board.GetLength(0);
            int minefieldColumns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int row = 0; row < minefieldRows; row++)
            {
                Console.Write("{0} | ", row);
                for (int column = 0; column < minefieldColumns; column++)
                {
                    Console.Write(string.Format("{0} ", board[row, column]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateMinefield()
        {
            int minefieldRows = 5;
            int minefieldColums = 10;
            char[,] gamefield = new char[minefieldRows, minefieldColums];

            for (int row = 0; row < minefieldRows; row++)
            {
                for (int column = 0; column < minefieldColums; column++)
                {
                    gamefield[row, column] = '?';
                }
            }

            return gamefield;
        }

        private static char[,] PlaceMinesInMinefield()
        {
            int rows = 5;
            int columns = 10;
            char[,] gamefield = new char[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    gamefield[row, column] = '-';
                }
            }

            List<int> mineCoordinates = new List<int>();
            while (mineCoordinates.Count < 15)
            {
                Random randomGenerator = new Random();
                int currentMinePosition = randomGenerator.Next(50);

                if (!mineCoordinates.Contains(currentMinePosition))
                {
                    mineCoordinates.Add(currentMinePosition);
                }
            }

            foreach (int mine in mineCoordinates)
            {
                int column = mine / columns;
                int row = mine % columns;

                if (row == 0 && mine != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                gamefield[column, row - 1] = '*';
            }

            return gamefield;
        }

        private static void Calculations(char[,] gamefield)
        {
            int gamefieldColumns = gamefield.GetLength(0);
            int gamefieldRows = gamefield.GetLength(1);

            for (int column = 0; column < gamefieldColumns; column++)
            {
                for (int row = 0; row < gamefieldRows; row++)
                {
                    if (gamefield[column, row] != '*')
                    {
                        char bombsCount = GetBombsCount(gamefield, column, row);
                        gamefield[column, row] = bombsCount;
                    }
                }
            }
        }

        private static char GetBombsCount(char[,] gamefield, int row, int column)
        {
            int bombsCount = 0;
            int gamefieldRows = gamefield.GetLength(0);
            int gamefieldColumns = gamefield.GetLength(1);

            if (row - 1 >= 0)
            {
                if (gamefield[row - 1, column] == '*')
                {
                    bombsCount++;
                }
            }

            if (row + 1 < gamefieldRows)
            {
                if (gamefield[row + 1, column] == '*')
                {
                    bombsCount++;
                }
            }

            if (column - 1 >= 0)
            {
                if (gamefield[row, column - 1] == '*')
                {
                    bombsCount++;
                }
            }

            if (column + 1 < gamefieldColumns)
            {
                if (gamefield[row, column + 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (gamefield[row - 1, column - 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < gamefieldColumns))
            {
                if (gamefield[row - 1, column + 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((row + 1 < gamefieldRows) && (column - 1 >= 0))
            {
                if (gamefield[row + 1, column - 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((row + 1 < gamefieldRows) && (column + 1 < gamefieldColumns))
            {
                if (gamefield[row + 1, column + 1] == '*')
                {
                    bombsCount++;
                }
            }

            return char.Parse(bombsCount.ToString());
        }

        public class PlayerDetails
        {
            private string name;
            private int score;

            public PlayerDetails()
            {
            }

            public PlayerDetails(string name, int score)
            {
                this.name = name;
                this.score = score;
            }

            public string Name
            {
                get
                {
                    return this.name;
                }

                set
                {
                    this.name = value;
                }
            }

            public int Score
            {
                get
                {
                    return this.score;
                }

                set
                {
                    this.score = value;
                }
            }
        }
    }
}