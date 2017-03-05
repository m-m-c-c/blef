using Blef.GameLogic.PokerHands;
using Blef.GameLogic.Tests.TestData;
using NUnit.Framework;

namespace Blef.GameLogic.Tests
{
    public class PokerHandHierarchyTest
    {
        [TestCaseSource(typeof(TestPokerHandsGenerator), nameof(TestPokerHandsGenerator.GeneratePokerHandsMatrix))]
        public static void should_be_able_to_tell_which_one_pokerhand_is_stronger_than_another(int i, int j,
            PokerHand firstPokerHand, PokerHand secondPokerHand)
        {
            var result = firstPokerHand.IsStrongerThan(secondPokerHand);
            if (i > j)
            {
                Assert.True(result);
            }
            else
            {
                Assert.False(result);
            }
        }
    }
}