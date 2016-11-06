namespace PokerCalculator
{
    public struct Probability
    {
        public HandRanking Ranking { get; set; }

        public double Percentage { get; set; }

        public Probability(HandRanking ranking, double percentage) : this()
        {
            Ranking = ranking;
            Percentage = percentage;
        }
    }
}