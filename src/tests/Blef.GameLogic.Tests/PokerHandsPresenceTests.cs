using System.Collections.Generic;
using Blef.GameLogic.PokerHands;
using Xunit;

namespace Blef.GameLogic.Tests
{
    public class PokerHandsPresenceTests
    {
        public static IReadOnlyList<Rank> AllRanks = new[]
            {Rank.Nine, Rank.Ten, Rank.Jack, Rank.Queen, Rank.King, Rank.Ace};

        [Theory]
        [InlineData(Rank.Nine)]
        [InlineData(Rank.Ten)]
        [InlineData(Rank.Jack)]
        [InlineData(Rank.Queen)]
        [InlineData(Rank.King)]
        [InlineData(Rank.Ace)]
        public void should_be_able_to_tell_that_highcard_is_not_presence_when_table_is_empty(Rank highCardRank)
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

        public static IEnumerable<object[]> GenerateAllRankSuitCombinations()
        {
            foreach (var suit in new[] {Suit.Clubs, Suit.Diamonds, Suit.Hearts, Suit.Spades})
            {
                foreach (var rank in AllRanks)
                    yield return new object[] { rank, suit };
            }
        }

        [Theory]
        [MemberData(nameof(GenerateAllRankSuitCombinations))]
        public void should_be_able_to_tell_that_highcard_is_presence_when_there_is_a_single_card_on_the_table(Rank highCardRank, Suit suit)
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