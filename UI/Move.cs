using System;
using System.Collections.Generic;
using System.Text;

namespace UI
{
    public class Move
    {
        public int SquareNumber { get; set; }
        public string Player { get; set; }

        public Move(int squareNumber, string player)
        {
            SquareNumber = squareNumber;
            Player = player;
        }
    }
}
