using System.Collections.Generic;
using Blef.GameLogic.PokerHands;
using Xunit;

namespace Blef.GameLogic.Tests.PokerHands
{
    public class HighCardOnTableTester
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
    }
}