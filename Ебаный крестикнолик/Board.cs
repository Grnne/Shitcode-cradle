using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ебаный_крестикнолик
{
    class Board
   
    {
            public Cell[,] _cells { get; } = new Cell[3, 3] { { Cell._, Cell._, Cell._ }, { Cell._, Cell._, Cell._ }, { Cell._, Cell._, Cell._ } };







       public void DrawBoard(Board board)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" |{board._cells[i, j]}| ");
                }
                Console.WriteLine("");
                Console.WriteLine("");
            } 
            
            
        }


    }


}
