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

        [Fact]
        public void When_comparing_better_hand_to_worse_hand_then_result_is_bigger_than_zero()
        {
            HighCard betterHand = new HighCard(Card.Jack);
            HighCard worseHand = new HighCard(Card.Nine);

            int result = betterHand.CompareTo(worseHand);

            Assert.True(result > 0);
        }
    }
}