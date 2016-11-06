using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerCalculator
{
    public class Calculation : ICalculation
    {
        private List<Cards> _deck;
        private const int MaxNumberOfCards = 5;
        private const int Runs = 1000;
        private readonly IDeckManipulation _deckManipulation;

        private int _royalFlushCount;
        private int _straightFlush;
        private int _foudOfAKind;
        private int _fullHouse;
        private int _flush;
        private int _straight;
        private int _threeOfAKind;
        private int _twoPair;
        private int _pair;
        private int _highCard;

        public Calculation()
        {
            _deckManipulation = new DeckManipulation();
            _deck = _deckManipulation.InitializeDeckOfCards();

            InitializeCounters();
        }

        private void InitializeCounters()
        {
            _royalFlushCount = 0;
            _straightFlush = 0;
            _foudOfAKind = 0;
            _fullHouse = 0;
            _flush = 0;
            _straight = 0;
            _threeOfAKind = 0;
            _twoPair = 0;
            _pair = 0;
            _highCard = 0;
        }

        public List<Probability> Probability(List<Cards> givenCards, int numberOfCards)
        {
            var remainingCards = _deckManipulation.RemainingCards(givenCards);
            var cardsToGenerate = MaxNumberOfCards - numberOfCards;
            
            for (var i = 0; i < Runs; i++)
            {
                var generatedCards = GenerateRandomCards(remainingCards, cardsToGenerate);
                var hand = new List<Cards>(givenCards.Count + generatedCards.Count);
                hand.AddRange(givenCards);
                hand.AddRange(generatedCards);

                UpdateCounters(hand);
            }

            var probabilityList = new List<Probability>
            {
                new Probability(HandRanking.RoyalFlush, (double)_royalFlushCount/Runs)
            };
            return probabilityList;
        }

        private static List<Cards> GenerateRandomCards(List<Cards> remainingCards, int cardsToGenerate)
        {
            var remainingCardList = new List<Cards>();
            foreach (var card in remainingCards)
            {
                remainingCardList.Add(card);
            }
            var random = new Random();
            var cardsGenerated = new List<Cards>();
            var value = Enum.GetValues(typeof(CardSuits));

            var counter = 0;
            while (counter < cardsToGenerate)
            {
                var suit = (CardSuits)value.GetValue(random.Next(value.Length));
                var number = random.Next(1, 14);
                var card = new Cards(suit, number);

                if (!remainingCardList.Contains(card)) continue;

                remainingCardList.Remove(card);
                cardsGenerated.Add(card);
                counter++;
            }

            return cardsGenerated;
        }

        private void UpdateCounters(List<Cards> hand)
        {
            if (IsRoyalFlush(hand)) _royalFlushCount++;
            if (IsStraightFlush(hand)) _straightFlush++;
            if (IsFoudOfAKind(hand)) _foudOfAKind++;
            if (IsFullHouse(hand)) _fullHouse++;
            if (IsFlush(hand)) _flush++;
            if (IsStraight(hand)) _straight++;
            if (IsThreeOfAKind(hand)) _threeOfAKind++;
            if (IsTwoPair(hand)) _twoPair++;
            if (IsPair(hand)) _pair++;
            if (IsHighCard(hand)) _highCard++;
        }

        private static bool IsRoyalFlush(List<Cards> hand)
        {
            if (!HasSameSuit(hand)) return false;
            var numbers = hand.Select(x => x.Number).ToList();
            numbers.Sort();

            var royalFlush = new List<int> {1, 10, 11, 12, 13};
            return numbers.Equals(royalFlush);
        }

        private static bool HasSameSuit(List<Cards> hand)
        {
            return hand.All(x => x.Suit == CardSuits.Clubs) || hand.All(x => x.Suit == CardSuits.Diamonds) || hand.All(x => x.Suit == CardSuits.Hearts) || hand.All(x => x.Suit == CardSuits.Spades);
        }

        private static bool IsStraightFlush(List<Cards> hand)
        { 
            // not implemented
            return false;
        }

        private static bool IsFoudOfAKind(List<Cards> hand)
        {
            // not implemented
            return false;
        }

        private static bool IsFullHouse(List<Cards> hand)
        {
            // not implemented
            return false;
        }

        private static bool IsFlush(List<Cards> hand)
        {
            // not implemented
            return false;
        }

        private static bool IsStraight(List<Cards> hand)
        {
            // not implemented
            return false;
        }

        private static bool IsThreeOfAKind(List<Cards> hand)
        {
            // not implemented
            return false;
        }

        private static bool IsTwoPair(List<Cards> hand)
        {
            // not implemented
            return false;
        }

        private static bool IsPair(List<Cards> hand)
        {
            // not implemented
            return false;
        }

        private static bool IsHighCard(List<Cards> hand)
        {
            // not implemented
            return false;
        }
    }
}
