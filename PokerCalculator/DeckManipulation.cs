using System;
using System.Collections.Generic;

namespace PokerCalculator
{
    public class DeckManipulation : IDeckManipulation
    {
        public List<Cards> InitializeDeckOfCards()
        {
            var cards = new List<Cards>();

            foreach (CardSuits suit in Enum.GetValues(typeof(CardSuits)))
                for (var i = 1; i < 14; i++)
                    cards.Add(new Cards(suit, i));

            return cards;
        }

        public List<Cards> RemainingCards(List<Cards> cardNotIncluded)
        {
            var deck = InitializeDeckOfCards();

            foreach (var card in cardNotIncluded)
                deck.Remove(card);

            return deck;
        }
    }
}