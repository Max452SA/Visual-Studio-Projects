// DeckOfCards.cs
// DeckOfCards class represents an entire deck (52) of playing cards
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    class DeckOfCards
    {
        //create a single Random object to share amongst the DeckOfCards objects
        private static Random randomNumbers = new Random();

        private const int NumberOfCards = 52;
        private Card[] deck = new Card[NumberOfCards];
        private int currentCard = 0;

        //constructor
        public DeckOfCards()
        {
            string[] faces = {"Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
            "Ten", "Jack", "Queen", "King"};
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            // Now we have to populate the deck with Card Objects
            for (var count = 0; count < deck.Length; count++)
            {
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
            }
        }//end Constructor

        //method to shuffle the pack of cards with a one-pass algorithm
        public void Shuffle()
        {
            currentCard = 0; //re-initializes currentCard

            //for each Card, pick another random Card and swap them
            for(var first = 0; first < deck.Length; first++)
            {
                //select a random number between 1 and 51
                var second = randomNumbers.Next(NumberOfCards);

                //swap current Card with randomly selected Card object
                Card tempArray = deck[first];
                deck[first] = deck[second];
                deck[second] = tempArray;
            }
        }//end method Shuffle

        //deal a single Card
        public Card DealCard()
        {
            //determine if any Cards remain to be dealt
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];     //returns the current Card in the array
            }
            else
            {
                return null;        //indicates that all Cards were dealt
            }
        }//end method DealCard

    }//end class DeckOfCards

}//end namespace Card
