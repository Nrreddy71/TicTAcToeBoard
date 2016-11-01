using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTAcToeBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            bool someoneWon = false;
            bool boardIsFull = false;
            int boardfull = 9;
            char[] pos = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            while (!someoneWon && !boardIsFull)
            {
                Console.Clear();
                Console.WriteLine(" " + pos[0] + " | " + pos[1] + " | " + pos[2] + " ");
                Console.WriteLine("---+---+---");
                Console.WriteLine(" " + pos[3] + " | " + pos[4] + " | " + pos[5] + " ");
                Console.WriteLine("---+---+---");
                Console.WriteLine(" " + pos[6] + " | " + pos[7] + " | " + pos[8] + " ");

                Console.WriteLine();
                Console.WriteLine("Press your available choice, 1 thru 9 ");
                string value = Console.ReadLine();
                int inp = Int32.Parse(value);
                if (inp > 0 && inp <= 9)
                {
                    if (pos[inp - 1] == 'X' || pos[inp - 1] == 'O')
                    {
                        Console.WriteLine("Invalid entry, select only available positions", inp);
                        Console.ReadLine();
                    }
                    else
                    {
                        pos[inp - 1] = 'X';
                    }
                }
                boardfull = boardfull - 1;
                if (boardfull == 0)
                {
                    boardIsFull = true;
                    break;
                }
                someoneWon = checkWinner(pos);
                if (someoneWon == true)
                {
                    Console.Clear();
                    Console.WriteLine(" " + pos[0] + " | " + pos[1] + " | " + pos[2] + " ");
                    Console.WriteLine("---+---+---");
                    Console.WriteLine(" " + pos[3] + " | " + pos[4] + " | " + pos[5] + " ");
                    Console.WriteLine("---+---+---");
                    Console.WriteLine(" " + pos[6] + " | " + pos[7] + " | " + pos[8] + " ");

                    Console.WriteLine("Player 1 wins");
                    break;
                }

                Random player2 = new Random(9);
                int inp2 = player2.Next(9);
                while (pos[inp2] == 'X' || pos[inp2] == 'O')
                {
                    inp2 = player2.Next(9);
                }
                pos[inp2] = 'O';
                Console.ReadLine();
                boardfull = boardfull - 1;
                if (boardfull == 0)
                {
                    boardIsFull = true;
                }
                someoneWon = checkWinner(pos);
                if (someoneWon == true)
                {
                    Console.Clear();
                    Console.WriteLine(" " + pos[0] + " | " + pos[1] + " | " + pos[2] + " ");
                    Console.WriteLine("---+---+---");
                    Console.WriteLine(" " + pos[3] + " | " + pos[4] + " | " + pos[5] + " ");
                    Console.WriteLine("---+---+---");
                    Console.WriteLine(" " + pos[6] + " | " + pos[7] + " | " + pos[8] + " ");

                    Console.WriteLine("Computer wins");
                    Console.ReadLine();
                    break;
                }
            }
            if (boardIsFull == true)
            {
                Console.WriteLine("Game is Tied");
                Console.ReadLine();
            }

        }
        static bool checkWinner(char[] testpos)
        {
                if (testpos[0] == testpos[1] && testpos[1] == testpos[2])
                {
                    return true;
                }
                else if (testpos[3] == testpos[4] && testpos[4] == testpos[5])
                {
                    return true;
                }
                else if (testpos[6] == testpos[7] && testpos[7] == testpos[8])
                {
                    return true;
                }
                else if (testpos[0] == testpos[3] && testpos[3] == testpos[6])
                {
                    return true;
                }
                else if (testpos[1] == testpos[4] && testpos[4] == testpos[7])
                {
                    return true;
                }
                else if (testpos[2] == testpos[5] && testpos[5] == testpos[8])
                {
                    return true;
                }
                else if (testpos[0] == testpos[4] && testpos[4] == testpos[8])
                {
                    return true;
                }
                else if (testpos[2] == testpos[4] && testpos[4] == testpos[6])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
