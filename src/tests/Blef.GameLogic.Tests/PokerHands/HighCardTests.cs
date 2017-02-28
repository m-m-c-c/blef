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
            HighCard highCard = new HighCard(new Card(Rank.Jack, Suit.Clubs));

            IEnumerable<Card> cardsOnTable = new[] { new Card(Rank.Ace, Suit.Clubs) };

            bool isOnTable = highCard.IsOnTable(cardsOnTable);

            Assert.False(isOnTable);
        }

        [Fact]
        public void Given_table_with_high_card_Then_result_is_True()
        {
            HighCard highCard = new HighCard(new Card(Rank.Jack, Suit.Diamonds));

            IEnumerable<Card> cardsOnTable = new[] { new Card(Rank.Jack, Suit.Diamonds) };

            bool isOnTable = highCard.IsOnTable(cardsOnTable);

            Assert.True(isOnTable);
        }

        [Fact]
        public void Given_table_with_many_high_cards_Then_result_is_True()
        {
            HighCard highCard = new HighCard(new Card(Rank.Jack, Suit.Diamonds));

            IEnumerable<Card> cardsOnTable = new[]
            {
                new Card(Rank.Jack, Suit.Diamonds),
                new Card(Rank.Jack, Suit.Clubs),
                new Card(Rank.Ace, Suit.Diamonds)
            };

            bool isOnTable = highCard.IsOnTable(cardsOnTable);

            Assert.True(isOnTable);
        }

        [Fact]
        public void When_comparing_better_hand_to_worse_hand_then_result_is_bigger_than_zero()
        {
            HighCard betterHand = new HighCard(new Card(Rank.Jack, Suit.Diamonds));
            HighCard worseHand = new HighCard(new Card(Rank.Nine, Suit.Diamonds));

            int result = betterHand.CompareTo(worseHand);

            Assert.True(result > 0);
        }
    }
}