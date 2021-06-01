using System;

namespace Snake__Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake ladder game");
            SnakeLadderGame snakeLadderGame = new SnakeLadderGame();
            snakeLadderGame.Position();
        }
    }
}
