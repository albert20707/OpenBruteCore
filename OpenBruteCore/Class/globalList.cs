using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenBruteCore
{
    public class GlobalList
    {
        public static readonly List<string> sourceList = new List<string>();
        public static readonly List<string> ProxyList = new List<string>();
        public static Form1 frm;
        public static Settings set;
        public static bool worck;
        public static string proxyUrl;
        public static string proxyType = "NULL";
        public static string workStatus = "nothing";
        public static int thCount = 150;
        public static int timeOut = 20;
        public static List<Thread> threadList = new List<Thread>();
        public static int good = 0, bad = 0, error = 0, projecterror = 0, corerror = 0;
        public static string time = DateTime.Now.ToString("HH_mm_ss");
        public static string folderName = "RESULT-FOLDER/[" + GlobalList.time + "]";

    }
}
