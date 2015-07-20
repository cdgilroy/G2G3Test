using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkeletonCode.CardGame
{
	class PackOfCards : IPackOfCards
	{
		List<Card> cards = new List<Card>();
		Random random = new Random();

		public PackOfCards()
		{
			
		}

		public ICard TakeCardFromTopOfPack()
		{
			Card tempCard = cards.FirstOrDefault();
			cards.Remove(tempCard);

			return tempCard;
		}

		public void AddCard(Card newCard)
		{
			cards.Add(newCard);
		}

		public void Shuffle()
		{
			// Uses the Fisher-Yates shuffle method
			for (int i = 0; i < cards.Count; i++)
			{
				int r = random.Next(i + 1);
				Card temp = cards[r];
				cards[r] = cards[i];
				cards[i] = temp;
			}
		}

		public void PrintDeck()
		{
			foreach(Card c in cards)
			{
				Console.WriteLine(c.PrintCard());
			}
		}

		public int Count
		{
			get { return cards.Count(); }
		}

		public IEnumerator<ICard> GetEnumerator()
		{
			return cards.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return cards.GetEnumerator();
		}
	}
}