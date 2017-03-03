using System.Collections.Generic;
using Blef.GameLogic.PokerHands;
using NUnit.Framework;

namespace Blef.GameLogic.Tests
{
    public class PokerHandsPresenceTests
    {
        [Test]
        public void should_be_able_to_tell_that_highcard_is_not_presence_when_table_is_empty(
            [Values(Rank.Nine, Rank.Ten, Rank.Jack, Rank.Queen, Rank.King, Rank.Ace)]Rank highCardRank)
        {
            //ARRANGE
            var table = new Table
            {
                PlayerHands = new[]
                {
                    new PlayerHand
                    {
                        Cards = new Card[0]
                    }
                }
            };
            var highCard = new HighCard(highCardRank);

            //ACT
            var isPresence = highCard.IsOnTable(table);

            //ASSERT
            Assert.False(isPresence);
        }

       [Test]
       [Pairwise]
        public void should_be_able_to_tell_that_highcard_is_presence_when_there_is_a_single_card_on_the_table(
           [Values(Rank.Nine, Rank.Ten, Rank.Jack, Rank.Queen, Rank.King, Rank.Ace)]Rank highCardRank, 
           [Values(Suit.Clubs, Suit.Diamonds, Suit.Hearts, Suit.Spades)]Suit suit)
        {
            //ARRANGE
            var table = new Table
            {
                PlayerHands = new[]
                {
                    new PlayerHand
                    {
                        Cards = new[]
                        {
                            new Card(highCardRank, suit)
                        }
                    }
                }
            };
            var highCard = new HighCard(highCardRank);

            //ACT
            var isPresence = highCard.IsOnTable(table);

            //ASSERT
            Assert.True(isPresence);
        }
    }
}