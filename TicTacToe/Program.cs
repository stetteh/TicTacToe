using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe2.app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Tic Tac Toe\n");

            char currentPlayer = 'X';
           

            var board = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8' };

            while (true)
            {
                //Console.Clear();
                Console.WriteLine(" {0} | {1} | {2}", board[0], board[1], board[2]);
                Console.WriteLine("---------------");
                Console.WriteLine(" {0} | {1} | {2}", board[3], board[4], board[5]);
                Console.WriteLine("---------------");
                Console.WriteLine(" {0} | {1} | {2}", board[6], board[7], board[8]);

                Console.WriteLine($"Player {currentPlayer}, please enter a move");

                string userInput = Console.ReadLine();
                var move = int.Parse(userInput);

                //check for 
                if (move <= 0 || move <= 8)
                {
                    board[move] = currentPlayer; ///check to make sure that the spot is not taken.
                }
                else
                {
                    //Console.WriteLine("enter a numnber within range");
                    continue;
                }

                //check for win
                if (board[0] == board[1] && board[1] == board[2])
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                }
                if (board[3] == board[4] && board[4] == board[5])
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                }
                if (board[6] == board[7] && board[7] == board[8])
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                }
                //column
                if (board[0] == board[3] && board[3] == board[6])
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                }
                if (board[1] == board[4] && board[4] == board[7])
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                }
                if (board[2] == board[5] && board[5] == board[8])
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                }
                //diagonal
                if (board[0] == board[4] && board[4] == board[8])
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                }
                if (board[2] == board[4] && board[4] == board[6])
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                }

                if (currentPlayer == 'X')
                {
                    currentPlayer = 'O';
                }
                else
                {
                    currentPlayer = 'X';
                }
            }

        }
    }
}
