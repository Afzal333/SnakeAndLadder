using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    public class GamePlay
    {
        int playerPosition = 0;
        Random random = new Random();
        public void DieRoll()
        {
            int die = random.Next(1, 7);
            Console.WriteLine(die);
        }
    }
}
