using System.Collections.Generic;
using Blef.GameLogic.PokerHands;
using Blef.GameLogic.Tests.TestData;
using NUnit.Framework;

namespace Blef.GameLogic.Tests
{
    public class HighStraightHierarchyTests
    {
        public static IEnumerable<PokerHand> StrongerThanHighStraight =
            TestPokerHandsGenerator.GeneratePokerHands(
                TestPokerHandsGenerator.GenerateAllThreeOfKind(),
                TestPokerHandsGenerator.GenerateAllFullHouses(),
                TestPokerHandsGenerator.GenerateAllFlushes(),
                TestPokerHandsGenerator.GenerateAllFourOfKinds(),
                TestPokerHandsGenerator.GenerateLowStraightFlushes(),
                TestPokerHandsGenerator.GenerateHighStraightFlushes()
            );


        [Test]
        public void should_be_able_to_tell_that_which_pokerhands_are_stronger_than_any_highstraight(
            [ValueSource(typeof(TestPokerHandsGenerator), nameof(TestPokerHandsGenerator.GenerateAllHighStraights))]
            PokerHand lowStraight,
            [ValueSource(nameof(StrongerThanHighStraight))]PokerHand stronger)
        {

            //ACT
            var result = stronger.IsStrongerThan(lowStraight);

            //ASSERT
            Assert.True(result);
        }

        public static IEnumerable<PokerHand> WeakerThanHighStraight =
            TestPokerHandsGenerator.GeneratePokerHands(
                TestPokerHandsGenerator.GenerateAllHighCardsByHierarchy(),
                TestPokerHandsGenerator.GenerateAllPairsByHierarchy(),
                TestPokerHandsGenerator.GenerateAllTwoPairsByHierarchy(),
                TestPokerHandsGenerator.GenerateAllLowStraights()
            );

        [Test]
        public void should_be_able_to_tell_that_which_pokerhands_are_weaker_than_any_highstraight(
            [ValueSource(typeof(TestPokerHandsGenerator), nameof(TestPokerHandsGenerator.GenerateAllHighStraights))]
            PokerHand lowStraight,
            [ValueSource(nameof(WeakerThanHighStraight))]PokerHand weaker)
        {

            //ACT
            var result = weaker.IsStrongerThan(lowStraight);

            //ASSERT
            Assert.False(result);
        }
    }
}