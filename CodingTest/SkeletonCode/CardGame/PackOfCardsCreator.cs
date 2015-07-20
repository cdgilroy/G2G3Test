using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkeletonCode.CardGame
{
	public class PackOfCardsCreator : IPackOfCardsCreator
	{
		public IPackOfCards Create()
		{
			PackOfCards newPack = new PackOfCards();
			Card newCard;

			// Clubs
			for (int i = 1; i <= 13; i++)
			{
				newCard = new Card(i, Suit.Clubs);
				newPack.AddCard(newCard);
			}

			// Diamonds
			for (int i = 1; i <= 13; i++)
			{
				newCard = new Card(i, Suit.Diamonds);
				newPack.AddCard(newCard);
			}

			// Hearts
			for (int i = 1; i <= 13; i++)
			{
				newCard = new Card(i, Suit.Hearts);
				newPack.AddCard(newCard);
			}

			// Spades
			for (int i = 1; i <= 13; i++)
			{
				newCard = new Card(i, Suit.Spades);
				newPack.AddCard(newCard);
			}

			return newPack;
		}
	}
}
