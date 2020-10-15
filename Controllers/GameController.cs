using System;
using Game.Services;

namespace Game.Controllers
{
    class GameController
    {
        private GameService _Service { get; set; } = new GameService();
        public bool _Running { get; set; } = true;

        public bool _Playing { get; set; }
        public bool _HasPlayed { get; set; } = false;

        public void Run()
        {
            while (_Running)
            {
                GetUserInput();
            }
        }

        private void GetUserInput()
        {
            if (_HasPlayed)
            {
                Console.WriteLine("Want to play again? y/n");
            }
            else
            {
                Console.WriteLine("Want to play a guessing game? y/n");
            }
            string input = Console.ReadLine().ToLower();
            Console.Clear();
            switch (input)
            {
                case "y":
                    Play();
                    break;
                case "n":
                    Quit();
                    break;
                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }
        }

        private void Play()
        {
            Random rnd = new Random();
            var gameNumber = rnd.Next(1, 100);
            Console.WriteLine("Pick a number from 1 to 100: ");
            _Playing = true;
            _HasPlayed = true;

            while (_Playing)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int index))
                {
                    if (index == gameNumber)
                    {
                        Console.WriteLine("Congratulations! You guessed it!!!");
                        _Playing = false;
                    }
                    else if (index > gameNumber)
                    {
                        Console.WriteLine("Lower, try again");
                    }
                    else
                    {
                        Console.WriteLine("Higher, try again");
                    }
                }
            }

        }
        private void Quit()
        {
            Console.WriteLine("Thank you for playing!");
            _Running = false;
        }
    }

}