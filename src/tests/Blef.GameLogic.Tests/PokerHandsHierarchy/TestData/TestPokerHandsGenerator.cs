using System.Collections.Generic;
using System.Linq;
using Blef.GameLogic.PokerHands;

namespace Blef.GameLogic.Tests.TestData
{
    public static class TestPokerHandsGenerator
    {
        private static readonly IReadOnlyList<Rank> AllRanksByHierarchy = new List<Rank>() { Rank.Nine, Rank.Ten,Rank.Jack, Rank.Queen, Rank.King, Rank.Ace };
        private static readonly IReadOnlyList<Suit> AllSuitsByHierarchy = new List<Suit>() { Suit.Clubs, Suit.Diamonds, Suit.Hearts, Suit.Spades };

        public static IEnumerable<PokerHand> GenerateAllHighCardsByHierarchy()
        {
            foreach (var rank in AllRanksByHierarchy) yield return new HighCard(rank);
        }

        public static IEnumerable<PokerHand> GenerateAllPairsByHierarchy()
        {
            foreach (var rank in AllRanksByHierarchy) yield return new Pair(rank);
        }

        public static IEnumerable<PokerHand> GenerateAllTwoPairsByHierarchy()
        {
            foreach (var rank1 in AllRanksByHierarchy)
                foreach (var rank2 in AllRanksByHierarchy)
                    if(rank2 < rank1)
                        yield return new TwoPairs(rank1, rank2);
        }

        public static IEnumerable<PokerHand> GenerateAllLowStraights()
        {
            yield return new LowStraight();
        }

        public static IEnumerable<PokerHand> GenerateAllHighStraights()
        {
            yield return new HighStraight();
        }

        public static IEnumerable<PokerHand> GenerateAllThreeOfKindByHierarchy()
        {
            foreach (var rank in AllRanksByHierarchy) yield return new ThreeOfKind(rank);
        }

        public static IEnumerable<PokerHand> GenerateAllFullHousesByHierarchy()
        {
            foreach (var rank1 in AllRanksByHierarchy)
                foreach (var rank2 in AllRanksByHierarchy)
                    if(rank1!=rank2)
                        yield return new FullHouse(rank1, rank2);
        }

        public static IEnumerable<PokerHand> GenerateAllFlushesByHierarchy()
        {
            foreach (var suit in AllSuitsByHierarchy) yield return new Flush(suit);
        }

        public static IEnumerable<PokerHand> GenerateAllFourOfKindsByHierarchy()
        {
            foreach (var rank in AllRanksByHierarchy) yield return new FourOfKind(rank);
        }

        public static IEnumerable<PokerHand> GenerateLowStraightFlushesByHierarchy()
        {
            foreach (var suit in AllSuitsByHierarchy) yield return new LowStraightFlush(suit);
        }

        public static IEnumerable<PokerHand> GenerateHighStraightFlushesByHierarchy()
        {
            foreach (var suit in AllSuitsByHierarchy) yield return new HighStraightFlush(suit);
        }


        public static IEnumerable<PokerHand> GeneratePokerHands(params IEnumerable<PokerHand>[] pokerHandsGenerators)
        {
            foreach (var generator in pokerHandsGenerators)
            {
                foreach (var pokerHand in generator)
                {
                    yield return pokerHand;
                }
            }
        }

        private static readonly IEnumerable<PokerHand> AllPokerHandsByHierarchy =
            GeneratePokerHands(
                GenerateAllHighCardsByHierarchy(),
                GenerateAllPairsByHierarchy(),
                GenerateAllTwoPairsByHierarchy(),
                GenerateAllLowStraights(),
                GenerateAllHighStraights(),
                GenerateAllThreeOfKindByHierarchy(),
                GenerateAllFullHousesByHierarchy(),
                GenerateAllFlushesByHierarchy(),
                GenerateAllFourOfKindsByHierarchy(),
                GenerateLowStraightFlushesByHierarchy(),
                GenerateHighStraightFlushesByHierarchy()
            );

        public static IEnumerable<object[]> GeneratePokerHandsMatrix()
        {
            var i = 0;
            foreach (var first in AllPokerHandsByHierarchy)
            {
                var j = 0;
                foreach (var second in AllPokerHandsByHierarchy)
                {
                    yield return new object[] { i, j, first, second };
                    j++;
                }
                i++;

            }
        }
    }
}