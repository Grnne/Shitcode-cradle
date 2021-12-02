using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ебаный_крестикнолик
{
    class Game
    {
        Board board = new Board();
        public  void Run()
        {
            Console.WriteLine("Use numpad to choose ur cell");
            for (int i = 0; i < 9; i++)
            {
                int roundCount = i;
                PlayerInteractions.PlayersInput(board, i);
                Console.Clear();
                board.DrawBoard(board);
                i = CheckWinDraw(board, i);
            }
        }
        {
            //rows and columns
            for (int x = 0; x < 3; x++)
            { if (board._cells[x, 0] == PlayerInteractions.PlayerSelection(i) &&
                  board._cells[x, 1] == PlayerInteractions.PlayerSelection(i) &&
                  board._cells[x, 2] == PlayerInteractions.PlayerSelection(i))
                {
                    Console.WriteLine($"Player {PlayerInteractions.PlayerSelection(i)} won");
                    return 9;
                }
                if (board._cells[0, x] == PlayerInteractions.PlayerSelection(i) &&
                    board._cells[1, x] == PlayerInteractions.PlayerSelection(i) &&
                    board._cells[2, x] == PlayerInteractions.PlayerSelection(i))
                { Console.WriteLine($"Player {PlayerInteractions.PlayerSelection(i)} won");
                    return 9;
                }
            }
            //diags
            if (board._cells[0, 0] == PlayerInteractions.PlayerSelection(i) &&
                board._cells[1, 1] == PlayerInteractions.PlayerSelection(i) &&
                board._cells[2, 2] == PlayerInteractions.PlayerSelection(i))
            { Console.WriteLine($"Player {PlayerInteractions.PlayerSelection(i)} won");
                return 9;
            }

            if (board._cells[0, 2] == PlayerInteractions.PlayerSelection(i) &&
                board._cells[1, 1] == PlayerInteractions.PlayerSelection(i) &&
                board._cells[2, 0] == PlayerInteractions.PlayerSelection(i))
            {
                Console.WriteLine($"Player {PlayerInteractions.PlayerSelection(i)} won");
                return 9;
            }

            else if (i == 8)
            {
                Console.WriteLine("Draw");
                return i;
            }
            else
                return i;
        }
    }
}


