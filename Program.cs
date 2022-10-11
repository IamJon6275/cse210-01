using System;
using System.Collections.Generic;

namespace Cse210Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program: Tic-Tack-Toe
            // Author: Jonathan Wells
            // Write your code here
            List<string> board = new List<string>();

            for (int i = 1; i < 10; i++)
            {
                board.Add(i.ToString());
            }
            
            int input;
            string player;
            string gameOver = "no";
            while (gameOver == "no")
            {
                WriteBoard(board);
                Console.Write("x's turn to choose a square (1-9): ");
                player = "x";
                input = int.Parse(Console.ReadLine());
                board[input-1] = player;
                gameOver = WinCheck(board, player);
                WriteBoard(board);

                if (gameOver == "no")
                {
                    Console.Write("o's turn to choose a square (1-9): ");
                    player = "o";
                    input = int.Parse(Console.ReadLine());
                    board[input-1] = player;
                    gameOver = WinCheck(board, player);
                    WriteBoard(board);
                }
            }

            Console.WriteLine("Good game. Thanks for playing!");
            
        }

        static public void WriteBoard(List<string> board)
        {
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
        }

        static public string WinCheck(List<string> board, string player)
        {
            string gameOver;
            if ((board[0] == player && board[1] == player && board[2] == player)
                || (board[3] == player && board[4] == player && board[5] == player)
                || (board[6] == player && board[7] == player && board[8] == player)
                || (board[0] == player && board[3] == player && board[6] == player)
                || (board[1] == player && board[4] == player && board[7] == player)
                || (board[2] == player && board[5] == player && board[8] == player)
                || (board[0] == player && board[4] == player && board[8] == player)
                || (board[2] == player && board[4] == player && board[6] == player)
                )
            {
                gameOver = "yes";
            }
            else
            {
                gameOver = "no";
            }
            
            return gameOver;
        }
    }
}
