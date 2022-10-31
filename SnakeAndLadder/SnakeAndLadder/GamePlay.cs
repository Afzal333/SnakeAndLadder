using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    public class GamePlay
    {
        const int No_Play=0,Ladder=1, Snake=2;
        int playerPosition = 0;
        Random random = new Random();
        public int DieRoll()
        {
            int die = random.Next(1, 7);
            Console.WriteLine(die);
            return die;
        }

        public void Play()
        {
            int option = random.Next(0, 3);
            switch (option)
            {
                case No_Play:
                    break;
                case Ladder: this.playerPosition+= DieRoll(); 
                    break;
                case Snake: this.playerPosition -= DieRoll();
                    break;
            }           
        }
    }
}
