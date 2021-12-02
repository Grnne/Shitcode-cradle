using System;

namespace Ебаный_крестикнолик
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Run();
        }
    }
}
public enum Cell { _, X, O }