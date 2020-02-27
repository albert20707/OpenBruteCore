using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBruteCore.Class
{
    public class Helper
    {
        public static Random Rand = new Random();
        public static string GetProxy()
        {
            return Convert.ToString(globalList.proxyList[Rand.Next(0, globalList.proxyList.Count)]);
        }
    }
}
