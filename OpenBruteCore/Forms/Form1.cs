using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;

namespace OpenBruteCore
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml("#2d2d30");
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml("#414144");
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml("#414144");
        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml("#414144");
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml("#2d2d30");
        }

        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            panel7.BackColor = ColorTranslator.FromHtml("#414144");
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = ColorTranslator.FromHtml("#2d2d30");
        }

        private void panel8_MouseEnter(object sender, EventArgs e)
        {
            panel8.BackColor = ColorTranslator.FromHtml("#414144");
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = ColorTranslator.FromHtml("#2d2d30");
        }

      

        private void lbProxy_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml("#414144");
        }

        private void lbSettings_MouseEnter(object sender, EventArgs e)
        {
            panel7.BackColor = ColorTranslator.FromHtml("#414144");
        }

        private void label2_MouseEnter_1(object sender, EventArgs e)
        {
            panel8.BackColor = ColorTranslator.FromHtml("#414144");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (GlobalList.set == null)
            {
                GlobalList.set = new Settings();
                GlobalList.set.Show();
            }
            else
            {
                GlobalList.set.Show();
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            AllMechanic.LoadSource();
        }
        private void lbSource_Click(object sender, EventArgs e)
        {
            AllMechanic.LoadSource();
        }

        private void lbProxy_Click(object sender, EventArgs e)
        {
            AllMechanic.LoadProxy();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            AllMechanic.LoadProxy();
        }

        private void lbSettings_Click(object sender, EventArgs e)
        {
            if (GlobalList.set == null)
            {
                GlobalList.set = new Settings();
                GlobalList.set.Show();
            }
            else
            {
                GlobalList.set.Show();
            }
            

        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (cbProxyUpdate.Checked)
            {
                proxyTimer.Enabled = true;
                GlobalList.proxyUrl = tbProxy.Text;
                proxyTimer.Interval = Convert.ToInt32(nudProxyInterval.Value * 1000);
                proxyTimer.Start();
                AllMechanic.RefreshProxy();
                lbProxy.Text = GlobalList.ProxyList.Count.ToString();
            }else
            {
                AllMechanic.RefreshProxy();
            }
            

        }

        private void proxyTimer_Tick(object sender, EventArgs e)
        {
            
            AllMechanic.RefreshProxy();
        }

        

        private void label11_Click(object sender, EventArgs e)
        {
            AllMechanic.StartWork();
            statTimer.Enabled = true;
            statTimer.Start();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (cbProxyUpdate.Checked)
            {
                proxyTimer.Enabled = true;
                GlobalList.proxyUrl = tbProxy.Text;
                proxyTimer.Interval = Convert.ToInt32(nudProxyInterval.Value * 1000);
                proxyTimer.Start();
                AllMechanic.RefreshProxy();
                lbProxy.Text = GlobalList.ProxyList.Count.ToString();
            }
            else
            {
                AllMechanic.RefreshProxy();
            }
        }

        private void lbGood_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lbGood, "Count of good combinations");
        }

        private void lbBad_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lbBad, "Count of bad combinations");
        }

        private void lbError_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lbError, "Count of httpError/projectError/coreError");
        }

        private void tbProxy_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(tbProxy, "Write here url for auto updatable proxies");
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            AllMechanic.StartWork();
            statTimer.Enabled = true;
            statTimer.Start();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            AllMechanic.StopWork();
            statTimer.Enabled = false;
            statTimer.Stop();
        }

        private void statTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                lbGood.Text = GlobalList.good.ToString();
                lbBad.Text = GlobalList.bad.ToString();
                lbError.Text = GlobalList.error + "/" + GlobalList.projecterror + "/" + GlobalList.corerror;
                lbSource.Text = GlobalList.sourceList.Count.ToString();
                lbProxy.Text = GlobalList.ProxyList.Count.ToString();
            }
            catch { }
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            AllMechanic.StopWork();
            statTimer.Enabled = false;
            statTimer.Stop();
        }
       

        private void panel7_Click(object sender, EventArgs e)
        {
            if (GlobalList.set == null)
            {
                GlobalList.set = new Settings();
                GlobalList.set.Show();
            }
            else
            {
                GlobalList.set.Show();
            }
        }
    }
}
