using System.Collections.Generic;
using Blef.GameLogic.PokerHands;
using Blef.GameLogic.Tests.TestData;
using NUnit.Framework;

namespace Blef.GameLogic.Tests
{
    public class HighCardsHierarchyTests
    {
        public static IEnumerable<PokerHand> StrongerThanHighCard =
            TestPokerHandsGenerator.GeneratePokerHands(
                TestPokerHandsGenerator.GenerateAllPairsByHierarchy(),
                TestPokerHandsGenerator.GenerateAllTwoPairsByHierarchy(),
                TestPokerHandsGenerator.GenerateAllLowStraights(),
                TestPokerHandsGenerator.GenerateAllHighStraights(),
                TestPokerHandsGenerator.GenerateAllThreeOfKind(),
                TestPokerHandsGenerator.GenerateAllFullHouses(),
                TestPokerHandsGenerator.GenerateAllFlushes(),
                TestPokerHandsGenerator.GenerateAllFourOfKinds(),
                TestPokerHandsGenerator.GenerateLowStraightFlushes(),
                TestPokerHandsGenerator.GenerateHighStraightFlushes()
            );

        [Test]
        public void should_be_able_to_tell_that_any_pokerhand_is_stronger_than_any_highcard(
            [ValueSource(typeof(TestPokerHandsGenerator), nameof(TestPokerHandsGenerator.GenerateAllHighCardsByHierarchy))]
            PokerHand highCard,
            [ValueSource(nameof(StrongerThanHighCard))]PokerHand anyPokerHand)
        {
            
            //ACT
            var result = anyPokerHand.IsStrongerThan(highCard);

            //ASSERT
            Assert.True(result);
        }
    }
}