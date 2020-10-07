using System;
using System.Collections.Generic;
using System.Text;

namespace UI
{
    public class Engine
    {
        private List<Move> moves = new List<Move>();


        public bool MoveIsValid(int squareNumber)
        {
            bool validMove = true;

            //extract into some type of move validator/rules engine
            //create some type of rules interface and pass in rules using DI
            //Loop through each of the rules to check if move is valid
            //can use DI to iterate new rules etc
            if (moves.Count == 0)
            {
                validMove = true;
            }
            else
            {
                
                foreach (var move in moves)
                {
                    if (move.SquareNumber == squareNumber)
                    {
                        //square taken
                        validMove = false;
                    }

                }
            }

            if (validMove)
            {
                moves.Add(new Move(squareNumber, "X"));
            }

            return validMove;
        }
    }
}
