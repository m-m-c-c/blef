using System.Collections.Generic;
using Blef.GameLogic.PokerHands;
using Blef.GameLogic.Tests.TestData;
using NUnit.Framework;

namespace Blef.GameLogic.Tests
{
    public class TwoPairsHierarchyTests
    {
        public static IEnumerable<PokerHand> StrongerThanTwoPairs =
            TestPokerHandsGenerator.GeneratePokerHands(
                TestPokerHandsGenerator.GenerateAllLowStraights(),
                TestPokerHandsGenerator.GenerateAllHighStraights(),
                TestPokerHandsGenerator.GenerateAllThreeOfKindByHierarchy(),
                TestPokerHandsGenerator.GenerateAllFullHousesByHierarchy(),
                TestPokerHandsGenerator.GenerateAllFlushesByHierarchy(),
                TestPokerHandsGenerator.GenerateAllFourOfKindsByHierarchy(),
                TestPokerHandsGenerator.GenerateLowStraightFlushesByHierarchy(),
                TestPokerHandsGenerator.GenerateHighStraightFlushesByHierarchy()
            );

        [Test]
        public void should_be_able_to_tell_that_which_pokerhands_are_stronger_than_any_twopair(
            [ValueSource(typeof(TestPokerHandsGenerator), nameof(TestPokerHandsGenerator.GenerateAllTwoPairsByHierarchy))]
            PokerHand twoPair,
            [ValueSource(nameof(StrongerThanTwoPairs))]PokerHand stronger)
        {
            
            //ACT
            var result = stronger.IsStrongerThan(twoPair);

            //ASSERT
            Assert.True(result);
        }


        public static IEnumerable<PokerHand> WeakerThanTwoPair = TestPokerHandsGenerator.GeneratePokerHands(
            TestPokerHandsGenerator.GenerateAllHighCardsByHierarchy(),
            TestPokerHandsGenerator.GenerateAllPairsByHierarchy()
        );

        [Test]
        public void should_be_able_to_tell_that_which_pokerhands_are_weaker_than_any_twopair(
            [ValueSource(typeof(TestPokerHandsGenerator), nameof(TestPokerHandsGenerator.GenerateAllTwoPairsByHierarchy))]
            PokerHand twoPairs,
            [ValueSource(nameof(WeakerThanTwoPair))]PokerHand weaker)
        {

            //ACT
            var result = weaker.IsStrongerThan(twoPairs);

            //ASSERT
            Assert.False(result);
        }
    }
}