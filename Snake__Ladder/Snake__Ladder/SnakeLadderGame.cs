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
            Console.WriteLine("Snake and Ladder game played with single player at position is"+" "+StartPosition);
        }

        ///UC2-ToGetNumber
        public void ToGetNumber()
        {
            Random random = new Random();
            int DieNumber = random.Next(0, 7);
            Console.WriteLine("After roll we get the number="+" "+DieNumber);
        }



    }
}
