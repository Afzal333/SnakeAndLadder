using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    public class GamePlay
    {
        const int No_Play=0,Ladder=1, Snake=2,Winning_Position=100;
        int playerPosition = 0;
        Random random = new Random();
        public int DieRoll()
        {
            int die = random.Next(1, 7);
            //Console.WriteLine(die);
            return die;
        }

        public void Play()
        {
            for(int i = 0; i < Winning_Position; i++)
            {
                int option = random.Next(0, 3);
                switch (option)
                {
                    case No_Play:
                        break;
                    case Ladder:
                        int dieROll = DieRoll();
                        if((this.playerPosition+ dieROll) < Winning_Position)
                            this.playerPosition += dieROll;
                        break;
                    case Snake:
                        this.playerPosition -= DieRoll();
                        if(this.playerPosition < 0)
                            this.playerPosition = 0;
                        break;
                }
                if(this.playerPosition == Winning_Position)
                {
                    Console.WriteLine(this.playerPosition);
                    return;
                }
            }
                      
        }
    }
}
