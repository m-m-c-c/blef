using System.Collections.Generic;
using Blef.GameLogic.PokerHands;
using Xunit;

namespace Blef.GameLogic.Tests.PokerHands
{
    public class HighCardTests
    {
        [Fact]
        public void Given_table_without_high_card_Then_result_is_False()
        {
            HighCard highCard = new HighCard(Card.Jack);

            IEnumerable<Card> cardsOnTable = new[] { Card.Ace };

            bool isOnTable = highCard.IsOnTable(cardsOnTable);

            Assert.False(isOnTable);
        }

        [Fact]
        public void Given_table_with_high_card_Then_result_is_True()
        {
            HighCard highCard = new HighCard(Card.Jack);

            IEnumerable<Card> cardsOnTable = new[] { Card.Jack };

            bool isOnTable = highCard.IsOnTable(cardsOnTable);

            Assert.True(isOnTable);
        }

        [Fact]
        public void Given_table_with_many_high_cards_Then_result_is_True()
        {
            HighCard highCard = new HighCard(Card.Jack);

            IEnumerable<Card> cardsOnTable = new[] { Card.Jack, Card.Jack, Card.Ace };

            bool isOnTable = highCard.IsOnTable(cardsOnTable);

            Assert.True(isOnTable);
        }
    }
}