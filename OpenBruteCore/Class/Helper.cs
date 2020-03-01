using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBruteCore
{
    public static class Helper
    {
        public static Random Rand = new Random();
        public static string GetProxy()
        {
            return Convert.ToString(GlobalList.ProxyList[Rand.Next(0, GlobalList.ProxyList.Count)]);
        }
    }
}
