using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenBruteCore
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Settings_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.Top = globalList.frm.Top;
            this.Left = globalList.frm.Left + 668;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            globalList.proxyType = comboBox1.Text;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            globalList.thCount = Convert.ToInt32(numericUpDown3.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            globalList.timeOut = Convert.ToInt32(numericUpDown2.Value);
        }
    }
}
