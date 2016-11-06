using System.Collections.Generic;

namespace PokerCalculator
{
    public interface ICalculation
    {
        List<Probability> Probability(List<Cards> givenCards, int numberOfCards);
    }
}
