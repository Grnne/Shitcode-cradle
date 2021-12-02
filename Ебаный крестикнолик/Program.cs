using System;

namespace Ебаный_крестикнолик
{
    
    class Program
    {
       
        
        static void Main(string[] args)
        {

            Board board = new Board();
            Game.Run(board);
        }
        
    }
}

public enum Cell { _, X, O }