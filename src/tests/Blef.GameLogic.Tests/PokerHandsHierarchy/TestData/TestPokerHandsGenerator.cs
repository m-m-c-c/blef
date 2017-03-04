using System.Collections.Generic;
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
            foreach (var rank in AllRanksByHierarchy) yield return new TwoPairs(rank, rank);
        }

        public static IEnumerable<PokerHand> GenerateAllLowStraights()
        {
            yield return new LowStraight();
        }

        public static IEnumerable<PokerHand> GenerateAllHighStraights()
        {
            yield return new HighStraight();
        }

        public static IEnumerable<PokerHand> GenerateAllThreeOfKind()
        {
            foreach (var rank in AllRanksByHierarchy) yield return new ThreeOfKind(rank);
        }

        public static IEnumerable<PokerHand> GenerateAllFullHouses()
        {
            foreach (var rank1 in AllRanksByHierarchy)
                foreach (var rank2 in AllRanksByHierarchy)
                    yield return new FullHouse(rank1, rank2);
        }

        public static IEnumerable<PokerHand> GenerateAllFlushes()
        {
            foreach (var suit in AllSuitsByHierarchy) yield return new Flush(suit);
        }

        public static IEnumerable<PokerHand> GenerateAllFourOfKinds()
        {
            foreach (var rank in AllRanksByHierarchy) yield return new FourOfKind(rank);
        }

        public static IEnumerable<PokerHand> GenerateLowStraightFlushes()
        {
            foreach (var suit in AllSuitsByHierarchy) yield return new LowStraightFlush(suit);
        }

        public static IEnumerable<PokerHand> GenerateHighStraightFlushes()
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
    }
}