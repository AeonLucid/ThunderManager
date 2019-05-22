using System;

namespace ThunderManager.Core.Steam
{
    public class SteamLocatorException : Exception
    {
        public SteamLocatorException(string message) : base(message)
        {
        }
    }
}