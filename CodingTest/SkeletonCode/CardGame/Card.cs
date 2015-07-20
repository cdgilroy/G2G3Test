using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkeletonCode.CardGame
{
	public enum Suit
	{
		Clubs = 1,
		Diamonds = 2,
		Hearts = 3,
		Spades = 4
	}

	class Card : ICard
	{
		int faceValue;
		Suit suit;

		public Card(int value, Suit suit)
		{
			faceValue = value;
			this.suit = suit;
		}

		public string PrintCard()
		{
			string output = "";

			// Value
			switch(faceValue)
			{
				case 1:
					output += "Ace";
					break;
				case 11:
					output += "Jack";
					break;
				case 12:
					output += "Queen";
					break;
				case 13:
					output += "King";
					break;
				default:
					output += faceValue;
					break;
			}

			output += " of ";

			// Face
			switch(suit)
			{
				case Suit.Clubs:
					output += "Clubs";
					break;
				case Suit.Diamonds:
					output += "Diamonds";
					break;
				case Suit.Hearts:
					output += "Hearts";
					break;
				case Suit.Spades:
					output += "Spades";
					break;
				default:
					output += "Joker";
					break;
			}

			return output;
		}
	}
}
