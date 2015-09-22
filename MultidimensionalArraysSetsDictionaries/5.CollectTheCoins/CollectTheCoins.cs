using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CollectTheCoins
{
    class CollectTheCoins
    {
        static int x = 0;
        static int y = 0;

        static void Main(string[] args)
        {
            char[][] board = new char[4][];
            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();
                board[i] = new char[input.Length];
                board[i] = input.ToCharArray();
            }

            int coinsCollected = 0;
            int wallsHit = 0;

            char[] commands = Console.ReadLine().ToCharArray();
            foreach (char cmd in commands)
            {
                if (ValidCoords(cmd, board))
                {
                    switch (cmd)
                    {
                        case '^':
                            y--;
                            break;
                        case '>':
                            x++;
                            break;
                        case 'V':
                            y++;
                            break;
                        case '<':
                            x--;
                            break;
                    }
                    if (board[y][x] == '$')
                    {
                        coinsCollected++;
                    }
                }
                else
                {
                    wallsHit++;
                }
            }

            Console.WriteLine("Coins collected: {0}", coinsCollected);
            Console.WriteLine("Walls hit: {0}", wallsHit);
        }

        static bool ValidCoords(char cmd, char[][] board)
        {
            switch (cmd)
            {
                case '^':
                    if (y - 1 < 0 || board[y-1].Length < x)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case '>':
                    if (x > (board[y].Length - 1))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case 'V':
                    if (y > 3 || board[y+1].Length < x)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case '<':
                    if (x - 1 < 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                default:
                    Console.WriteLine("error");
                    return false;
            }
        }
    }
}
