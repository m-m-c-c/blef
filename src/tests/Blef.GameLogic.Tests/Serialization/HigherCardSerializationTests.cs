using Blef.GameLogic.PokerHands;
using Xunit;

namespace Blef.GameLogic.Tests.Serialization
{
    public class HigherCardSerializationTests
    {
        [Fact]
        public void HigherCard_should_be_serialized_and_deserialized_correctly_to_the_exact_type()
        {
            var pokerHand = new HighCard(Rank.Ace);

            var deserializedObject = SerializationTestHelper.SerializeAndDeserialize(pokerHand);

            Assert.IsType<HighCard>(deserializedObject);
        }
    }
}