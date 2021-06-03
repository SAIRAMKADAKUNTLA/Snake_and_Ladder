using System;
using System.Collections.Generic;
using System.Text;

namespace Snake__Ladder
{
    public class SnakeLadderGame
    {
        /// UC1-Position
        int StartPosition = 0;
        public void Position()
        {
            Console.WriteLine("Snake and Ladder game played with single player at position is" + " " + StartPosition);
        }

        ///UC2-ToGetNumber

        public void ToGetNumber()
        {
            Random random = new Random();
            int DieNumber = random.Next(0, 7);
            Console.WriteLine("After roll we get the number=" + " " + DieNumber);
        }

        ///UC3-CheckForOption
        int Iposition;
        int Player;
        public int DiceCount = 0;
        const int Ladder = 1;
        const int Snake = 2;
        public void CheckForOption()
        {
            while (Player <= 100) ///(UC4-checkupto position 100)
            { 
            Random random = new Random();
            int DieNumber = random.Next(0, 3);
            Iposition = DieNumber;
            if (Iposition == 0)
            {                                           /////Noplay condition
                Console.WriteLine("its a no play");
                Player += Iposition;
            }
            if (Player == 0 && Iposition < 0)
            {
                Console.WriteLine("its a snake bite ");
                Player = 0;                               ////Snake condition
            }
            if (Player > 0 && Iposition < 0)
            {
                Console.WriteLine("its a snake bite ");
                Player += Iposition;
            }
            if (Player > 0)
            {
                Player = 0;
            }
                if (Iposition > 0)                             ///Ladder condition
                {
                    Console.WriteLine("its a ladder");
                    Player += Iposition;
                }
            }
            DiceCount += 1;

            Console.WriteLine("player rolls die and get position "+Player);
            Console.WriteLine("total number of times"+DiceCount);
        }

        /// UC5-WinPosition

        int WinPosition=100;
        public void Wposition()
        {
            if (Iposition == WinPosition)
            {
                Console.WriteLine("-------Player Won!!!!-------");
            }
            if (Iposition > WinPosition)
            {
                Console.WriteLine("-- stays in previous position---");
            }
            else
                Console.WriteLine("continue the game");
            
        }
        


    }
}

    

