namespace PokerCalculator
{
    public struct Cards
    {
        public CardSuits Suit { get; set; }

        public int Number { get; set; }

        public Cards(CardSuits suit, int number) : this()
        {
            Suit = suit;
            Number = number;
        }
    }
}