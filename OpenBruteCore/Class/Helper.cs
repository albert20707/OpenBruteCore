using System;

namespace OpenBruteCore
{
    public static class Helper
    {
        public static string GetProxy()
        {
            return Convert.ToString(GlobalList.ProxyList[new Random().Next(0, GlobalList.ProxyList.Count)]);
        }
    }
}
