using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ебаный_крестикнолик
{
    class PlayerInteractions
    {



        static public void PlayersInput(Board board, int _roundCount)
        {
            Console.WriteLine($"Input ur cell, player {PlayerSelection(_roundCount)}");
            ConsoleKey key = Console.ReadKey().Key;
            Console.WriteLine(); Console.WriteLine();
            switch (key)
            {
                case ConsoleKey.NumPad7:
                    {
                        PlayerCellFilling(board, 0, 0, _roundCount);
                        break;
                    }

                case ConsoleKey.NumPad4:
                    {

                        PlayerCellFilling(board, 1, 0, _roundCount);
                        break;
                    }
                case ConsoleKey.NumPad1:
                    {
                        PlayerCellFilling(board, 2, 0, _roundCount);
                        break;
                    }
                case ConsoleKey.NumPad8:
                    {

                        PlayerCellFilling(board, 0, 1, _roundCount);
                        break;
                    }
                case ConsoleKey.NumPad5:
                    {

                        PlayerCellFilling(board, 1, 1, _roundCount);
                        break;
                    }
                case ConsoleKey.NumPad2:
                    {

                        PlayerCellFilling(board, 2, 1, _roundCount);
                        break;
                    }
                case ConsoleKey.NumPad9:
                    {

                        PlayerCellFilling(board, 0, 2, _roundCount);
                        break;
                    }
                case ConsoleKey.NumPad6:
                    {

                        PlayerCellFilling(board, 1, 2, _roundCount);
                        break;
                    }
                case ConsoleKey.NumPad3:
                    {PlayerCellFilling(board, 2, 2, _roundCount);
                        break;}

                default:
                    Console.WriteLine("Wrong button man");
                    PlayersInput(board, _roundCount);
                    break;
            }

        }

        public static Cell PlayerSelection(int x)
            {
                if (x % 2 == 0)
                    return Cell.X;
                else
                    return Cell.O;
            }



        public static void  PlayerCellFilling(Board board, int x, int y, int _roundCount)
        {

            if (board._cells[x, y] != Cell._)
            {
                Console.WriteLine("Cell is filled, man, try another.");
                PlayersInput(board,_roundCount);
            }
            else
                board._cells[x, y] = PlayerSelection(_roundCount);

        }

    }
}
