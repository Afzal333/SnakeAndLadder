using System;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SnakeAndLadder Problem Statement");
            GamePlay gameplay = new GamePlay();
            gameplay.DieRoll();
            gameplay.Play();
        }
    }
}
