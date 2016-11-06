using System.Collections.Generic;

namespace PokerCalculator
{
    public interface IDeckManipulation
    {
        List<Cards> InitializeDeckOfCards();

        List<Cards> RemainingCards(List<Cards> cardsNotIncluded);
    }
}