using System.Collections.Generic;
using Blef.GameLogic.PokerHands;
using Blef.GameLogic.Tests.TestData;
using NUnit.Framework;

namespace Blef.GameLogic.Tests
{
    public class PairHierarchyTests
    {
        public static IEnumerable<PokerHand> StrongerThanPair =
            TestPokerHandsGenerator.GeneratePokerHands(
                TestPokerHandsGenerator.GenerateAllTwoPairsByHierarchy(),
                TestPokerHandsGenerator.GenerateAllLowStraights(),
                TestPokerHandsGenerator.GenerateAllHighStraights(),
                TestPokerHandsGenerator.GenerateAllThreeOfKindByHierarchy(),
                TestPokerHandsGenerator.GenerateAllFullHousesByHierarchy(),
                TestPokerHandsGenerator.GenerateAllFlushesByHierarchy(),
                TestPokerHandsGenerator.GenerateAllFourOfKindsByHierarchy(),
                TestPokerHandsGenerator.GenerateLowStraightFlushesByHierarchy(),
                TestPokerHandsGenerator.GenerateHighStraightFlushesByHierarchy()
            );

        public static IEnumerable<PokerHand> WeakerThanPair = TestPokerHandsGenerator.GenerateAllHighCardsByHierarchy();

        [Test]
        public void should_be_able_to_tell_that_which_pokerhands_are_stronger_than_any_pair(
            [ValueSource(typeof(TestPokerHandsGenerator), nameof(TestPokerHandsGenerator.GenerateAllPairsByHierarchy))]
            PokerHand pair,
            [ValueSource(nameof(StrongerThanPair))]PokerHand stronger)
        {
            
            //ACT
            var result = stronger.IsStrongerThan(pair);

            //ASSERT
            Assert.True(result);
        }

        [Test]
        public void should_be_able_to_tell_that_which_pokerhands_are_weaker_than_any_pair(
            [ValueSource(typeof(TestPokerHandsGenerator), nameof(TestPokerHandsGenerator.GenerateAllPairsByHierarchy))]
            PokerHand pair,
            [ValueSource(nameof(WeakerThanPair))]PokerHand weaker)
        {

            //ACT
            var result = weaker.IsStrongerThan(pair);

            //ASSERT
            Assert.False(result);
        }
    }
}