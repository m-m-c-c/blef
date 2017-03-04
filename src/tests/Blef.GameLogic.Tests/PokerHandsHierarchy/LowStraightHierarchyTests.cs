using System.Collections.Generic;
using Blef.GameLogic.PokerHands;
using Blef.GameLogic.Tests.TestData;
using NUnit.Framework;

namespace Blef.GameLogic.Tests
{
    public class LowStraightHierarchyTests
    {
        public static IEnumerable<PokerHand> StrongerThanLowStraight =
            TestPokerHandsGenerator.GeneratePokerHands(
                TestPokerHandsGenerator.GenerateAllHighStraights(),
                TestPokerHandsGenerator.GenerateAllThreeOfKind(),
                TestPokerHandsGenerator.GenerateAllFullHouses(),
                TestPokerHandsGenerator.GenerateAllFlushes(),
                TestPokerHandsGenerator.GenerateAllFourOfKinds(),
                TestPokerHandsGenerator.GenerateLowStraightFlushes(),
                TestPokerHandsGenerator.GenerateHighStraightFlushes()
            );


        [Test]
        public void should_be_able_to_tell_that_which_pokerhands_are_stronger_than_any_pair(
            [ValueSource(typeof(TestPokerHandsGenerator), nameof(TestPokerHandsGenerator.GenerateAllLowStraights))]
            PokerHand lowStraight,
            [ValueSource(nameof(StrongerThanLowStraight))]PokerHand stronger)
        {

            //ACT
            var result = stronger.IsStrongerThan(lowStraight);

            //ASSERT
            Assert.True(result);
        }

        public static IEnumerable<PokerHand> WeakerThanLowStraight =
            TestPokerHandsGenerator.GeneratePokerHands(
                TestPokerHandsGenerator.GenerateAllHighCardsByHierarchy(),
                TestPokerHandsGenerator.GenerateAllPairsByHierarchy(),
                TestPokerHandsGenerator.GenerateAllTwoPairsByHierarchy()
            );

        [Test]
        public void should_be_able_to_tell_that_which_pokerhands_are_weaker_than_any_pair(
            [ValueSource(typeof(TestPokerHandsGenerator), nameof(TestPokerHandsGenerator.GenerateAllLowStraights))]
            PokerHand lowStraight,
            [ValueSource(nameof(WeakerThanLowStraight))]PokerHand weaker)
        {

            //ACT
            var result = weaker.IsStrongerThan(lowStraight);

            //ASSERT
            Assert.False(result);
        }
    }
}