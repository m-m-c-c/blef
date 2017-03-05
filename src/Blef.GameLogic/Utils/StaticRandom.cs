using System;

namespace Blef.GameLogic.Utils
{
    /// <summary>
    /// This class is used, cause we don't want to create Random class
    /// every time. It is possible that 'new Random' that are close in code
    /// and time will give the same random values.
    /// </summary>
    public static class StaticRandom
    {
        public static readonly Random Instance = new Random();
    }
}