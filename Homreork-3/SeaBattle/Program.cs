using System;

namespace SeaBattle
{
    class Program
    {
        private const int BoardSize = 10;
        private const char Ship = 'X';
        static void Main(string[] args)
        {
            PrintBoeard(SetupBoard());
        }

        private static void PrintBoeard(char [,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write($"{board[i, j]}  ");
                }
                Console.WriteLine();
            }
        }

        private static char[,] SetupBoard()
        {
            var boardArray = new char[BoardSize, BoardSize];
            
            // 4 deck
            SetupFourDeckShip(boardArray);
            
            // 3 deck
            SetupThreeDeckShops(boardArray);
            
            // 2 deck
            SetupTwoDeckShips(boardArray);
            
            // 1 deck
            SetupSingleDeckShips(boardArray);

            for (int i = 0; i < boardArray.GetLength(0); i++)
            {
                for (int j = 0; j < boardArray.GetLength(1); j++)
                {
                    if (boardArray[i, j] != 'X')
                    {
                        boardArray[i, j] = '·';
                    }
                }
            }
            
            return boardArray;
        }

        private static void SetupFourDeckShip(char[,] board)
        {
            board[1, 1] = Ship;
            board[1, 2] = Ship;
            board[1, 3] = Ship;
            board[1, 4] = Ship;
        }

        private static void SetupThreeDeckShops(char[,] board)
        {
            board[1, 6] = Ship;
            board[2, 6] = Ship;
            board[3, 6] = Ship;

            board[6, 6] = Ship;
            board[6, 7] = Ship;
            board[6, 8] = Ship;
        }

        private static void SetupTwoDeckShips(char[,] board)
        {
            board[5, 1] = Ship;
            board[5, 2] = Ship;
            
            board[7, 4] = Ship;
            board[8, 4] = Ship;
            
            board[2, 9] = Ship;
            board[3, 9] = Ship;
        }

        private static void SetupSingleDeckShips(char[,] board)
        {
            board[0, 9] = Ship;
            
            board[3, 0] = Ship;
            
            board[7, 1] = Ship;
            
            board[9, 0] = Ship;
            
            board[8, 7] = Ship;
        }
    }
}