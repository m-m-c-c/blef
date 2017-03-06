using Newtonsoft.Json;

namespace Blef.GameLogic.Tests.Serialization
{
    public class SerializationTestHelper
    {
        public static T SerializeAndDeserialize<T>(T value)
        {
            JsonSerializerSettings jss = new JsonSerializerSettings
            {
                // It is important for serializing PokerHand derived types
                TypeNameHandling = TypeNameHandling.All
            };

            string serialized = JsonConvert.SerializeObject(value, jss);

            return JsonConvert.DeserializeObject<T>(serialized, jss);
        }
    }
}