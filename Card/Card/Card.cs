// Card.cs
// Card class represents a playing card
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    class Card
    {
        //Properties
        private string Face { get; }        //A card's face eg. Ace, 2, Jack, King ...etc
        private string Suit { get; }        //A card's suit  eg. Hearts, Spades...etc

        //Constructor 
        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        //method ToString returns string representatives of a card
        public override string ToString() => $"{Face} of {Suit}";

    }//end class Card
}//end namespace Card
