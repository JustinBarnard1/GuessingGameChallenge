using System;
using Game.Controllers;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            new GameController().Run();
        }
    }
}
