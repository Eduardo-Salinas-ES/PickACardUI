using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    internal class CardPicker
    {
        // Sudo random number generator
        static Random random = new Random();

        private static string RandomSuit()
        {
            // get a random number from 1 to 4
            int value = random.Next(1, 5);

            // if it's 1 return the string Spades
            if (value == 1) return "Spades";

            // if it's 2 return the string Hearts
            if(value == 2) return "Hearts";

            // if it's 3 return the string Clubs
            if(value == 3) return "Clubs";

            // if we have not returned yet, return the string diamonds
            return "Diamonds";
        }

        private static string RandomValue()
        {
            // get a random number from 1 to 13
            int value = random.Next(1, 14);
            // if it's 1 return Ace
            if (value == 1) return "Ace";
            // if it's 11 return Jack
            if (value == 11) return "Jack";
            // if it's 12 return Queen
            if (value == 12) return "Queen";
            // if it's 13 return King
            if (value == 13) return "King";
            
            // if we have not returned yet, return the value as a string
            return value.ToString();
        }
        public static string[] PickSomeCards(int numberOfCards)
        {
            // Create dynamic array of strings for our cards
            string[] pickedCards = new string[numberOfCards];
            for(int i = 0; i < numberOfCards; i++)
            {
                // Create the string value for each card with a value and suit
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }

            //return the array of cards
            return pickedCards;
        }
    
    }
}
