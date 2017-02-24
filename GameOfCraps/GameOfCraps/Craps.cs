// Craps.cs
// A Craps class that simulates a game of the popular Casino game Craps

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfCraps
{
    class Craps
    {
        //creates a new private static instance of Random Number object  
        private static Random randomNumbers = new Random();

        private enum Status     //enumerated constants displaying the games current status
        {
            Continue,
            Won,
            Lost,
        }

        private enum DiceNames      //enumerated constants - common rolls of dice in craps
        {
            SnakeEyes = 2,
            Trey = 3,
            Seven = 7,
            YoLeven = 11,
            BoxCars = 12,
        }
        static void Main(string[] args)
        {
            Status gameStatus = Status.Continue;

            //Players point if no win or loss on 1st Roll
            int myPoint = 0;     

            //1st Roll of dice calls method RollDice()
            int sumOfDice = RollDice(); 

            switch ((DiceNames) sumOfDice)
            {
                case DiceNames.Seven:       //win on 1st roll with a 7 or
                case DiceNames.YoLeven:     //win on first roll with an 11
                    gameStatus = Status.Won;
                    break;

                case DiceNames.SnakeEyes:   //lose on 1st roll with a 2 or
                case DiceNames.Trey:        //lose on 1st roll with a 3 or
                case DiceNames.BoxCars:     //lose on 1st roll with a 12
                    gameStatus = Status.Lost;
                    break;

                default:    //if you don't win or lose, player gets point = face of dice
                    gameStatus = Status.Continue;       //game isn't over
                    myPoint = sumOfDice;
                    Console.WriteLine();
                    Console.WriteLine($" Point is:  {myPoint}");
                    break;
            }

            while (gameStatus == Status.Continue)
            {
                //roll dice again with method call RollDice()
                sumOfDice = RollDice(); 

                if (sumOfDice == myPoint)
                {
                    gameStatus = Status.Won;
                }
                else
                {
                    if (sumOfDice == (int) DiceNames.Seven)
                    {
                        gameStatus = Status.Lost;
                    }
                }
            }//end while

            //displays the players game status message (either won or lost)
            if (gameStatus == Status.Won)
            {
                Console.WriteLine();
                Console.WriteLine("  The Player Wins! ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("  The player loses - Please try again ");
                Console.WriteLine();
            }

        }//end Main

        //static method RollDice() - rolls dice, calculates sum of die values
        // and displays the results
        static int RollDice()
        {
            int die1 = randomNumbers.Next(1, 7);
            int die2 = randomNumbers.Next(1, 7);

            int sum = die1 + die2; //sum of both Dice

            Console.WriteLine();
            Console.WriteLine($"  The player rolled: {die1} + {die2} = {sum}");

            return sum;
        }//end RollDice() 

    }//end class Craps
}//end Namespace GameOfCraps
