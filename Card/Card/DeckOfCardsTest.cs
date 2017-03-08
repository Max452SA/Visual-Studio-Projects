// DeckOfCardsTest.cs
// Card-shuffling and dealing app
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    class DeckOfCardsTest
    {
        static void Main(string[] args)
        {
            var myDeckOfCards = new DeckOfCards();
            myDeckOfCards.Shuffle();        //place all cards in random order

            Console.WriteLine();
            //display all 52 cards in the order in which they are dealt
            for (var i = 0; i < 52; i++)
            {
                Console.Write($"  {myDeckOfCards.DealCard(),-19}");

                if ((i + 1) % 4 == 0)
                {
                    Console.WriteLine();
                }
            }//end for loop
            Console.WriteLine();
        }//end Main

    }//end class DeckOfCardsTest
}//end namespace Card
