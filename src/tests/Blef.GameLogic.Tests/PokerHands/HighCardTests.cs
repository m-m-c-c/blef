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
            HighCard highCard = new HighCard(Rank.Jack);

            IEnumerable<Rank> cardsOnTable = new[] { Rank.Ace };

            bool isOnTable = highCard.IsOnTable(cardsOnTable);

            Assert.False(isOnTable);
        }

        [Fact]
        public void Given_table_with_high_card_Then_result_is_True()
        {
            HighCard highCard = new HighCard(Rank.Jack);

            IEnumerable<Rank> cardsOnTable = new[] { Rank.Jack };

            bool isOnTable = highCard.IsOnTable(cardsOnTable);

            Assert.True(isOnTable);
        }

        [Fact]
        public void Given_table_with_many_high_cards_Then_result_is_True()
        {
            HighCard highCard = new HighCard(Rank.Jack);

            IEnumerable<Rank> cardsOnTable = new[] { Rank.Jack, Rank.Jack, Rank.Ace };

            bool isOnTable = highCard.IsOnTable(cardsOnTable);

            Assert.True(isOnTable);
        }

        [Fact]
        public void When_comparing_better_hand_to_worse_hand_then_result_is_bigger_than_zero()
        {
            HighCard betterHand = new HighCard(Rank.Jack);
            HighCard worseHand = new HighCard(Rank.Nine);

            int result = betterHand.CompareTo(worseHand);

            Assert.True(result > 0);
        }
    }
}