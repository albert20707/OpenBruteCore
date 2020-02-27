namespace OpenBruteCore
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbSettings = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbProxy = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbSource = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.nudProxyInterval = new System.Windows.Forms.NumericUpDown();
            this.cbProxyUpdate = new System.Windows.Forms.CheckBox();
            this.tbProxy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lbBad = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.lbGood = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.proxyTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProxyInterval)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(9, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 231);
            this.panel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel8.Controls.Add(this.label2);
            this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel8.Location = new System.Drawing.Point(7, 173);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(288, 49);
            this.panel8.TabIndex = 6;
            this.panel8.MouseEnter += new System.EventHandler(this.panel8_MouseEnter);
            this.panel8.MouseLeave += new System.EventHandler(this.panel8_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(105, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "ABOUT";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter_1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel7.Controls.Add(this.lbSettings);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(7, 118);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(288, 49);
            this.panel7.TabIndex = 5;
            this.panel7.Click += new System.EventHandler(this.panel7_Click);
            this.panel7.MouseEnter += new System.EventHandler(this.panel7_MouseEnter);
            this.panel7.MouseLeave += new System.EventHandler(this.panel7_MouseLeave);
            // 
            // lbSettings
            // 
            this.lbSettings.AutoSize = true;
            this.lbSettings.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSettings.Location = new System.Drawing.Point(98, 13);
            this.lbSettings.Name = "lbSettings";
            this.lbSettings.Size = new System.Drawing.Size(90, 23);
            this.lbSettings.TabIndex = 3;
            this.lbSettings.Text = "SETTINGS";
            this.lbSettings.Click += new System.EventHandler(this.lbSettings_Click);
            this.lbSettings.MouseEnter += new System.EventHandler(this.lbSettings_MouseEnter);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel6.Controls.Add(this.lbProxy);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Location = new System.Drawing.Point(7, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(288, 49);
            this.panel6.TabIndex = 4;
            this.panel6.Click += new System.EventHandler(this.panel6_Click);
            this.panel6.MouseEnter += new System.EventHandler(this.panel6_MouseEnter);
            this.panel6.MouseLeave += new System.EventHandler(this.panel6_MouseLeave);
            // 
            // lbProxy
            // 
            this.lbProxy.AutoSize = true;
            this.lbProxy.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbProxy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbProxy.Location = new System.Drawing.Point(105, 13);
            this.lbProxy.Name = "lbProxy";
            this.lbProxy.Size = new System.Drawing.Size(67, 23);
            this.lbProxy.TabIndex = 3;
            this.lbProxy.Text = "PROXY";
            this.lbProxy.Click += new System.EventHandler(this.lbProxy_Click);
            this.lbProxy.MouseEnter += new System.EventHandler(this.lbProxy_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.lbSource);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(7, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 49);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // lbSource
            // 
            this.lbSource.AutoSize = true;
            this.lbSource.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSource.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSource.Location = new System.Drawing.Point(98, 13);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(78, 23);
            this.lbSource.TabIndex = 3;
            this.lbSource.Text = "SOURCE";
            this.lbSource.Click += new System.EventHandler(this.lbSource_Click);
            this.lbSource.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "OpenBruteCore";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.nudProxyInterval);
            this.panel3.Controls.Add(this.cbProxyUpdate);
            this.panel3.Controls.Add(this.tbProxy);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel3.Location = new System.Drawing.Point(328, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 231);
            this.panel3.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel5.Controls.Add(this.label10);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(20, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 24);
            this.panel5.TabIndex = 4;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(93, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "GET FROM URL";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // nudProxyInterval
            // 
            this.nudProxyInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nudProxyInterval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudProxyInterval.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudProxyInterval.ForeColor = System.Drawing.SystemColors.Window;
            this.nudProxyInterval.Location = new System.Drawing.Point(262, 9);
            this.nudProxyInterval.Name = "nudProxyInterval";
            this.nudProxyInterval.Size = new System.Drawing.Size(51, 19);
            this.nudProxyInterval.TabIndex = 8;
            this.nudProxyInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudProxyInterval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // cbProxyUpdate
            // 
            this.cbProxyUpdate.AutoSize = true;
            this.cbProxyUpdate.Checked = true;
            this.cbProxyUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbProxyUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProxyUpdate.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbProxyUpdate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbProxyUpdate.Location = new System.Drawing.Point(20, 13);
            this.cbProxyUpdate.Name = "cbProxyUpdate";
            this.cbProxyUpdate.Size = new System.Drawing.Size(12, 11);
            this.cbProxyUpdate.TabIndex = 7;
            this.cbProxyUpdate.UseVisualStyleBackColor = true;
            // 
            // tbProxy
            // 
            this.tbProxy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tbProxy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProxy.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbProxy.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbProxy.Location = new System.Drawing.Point(37, 9);
            this.tbProxy.Name = "tbProxy";
            this.tbProxy.Size = new System.Drawing.Size(222, 19);
            this.tbProxy.TabIndex = 6;
            this.tbProxy.Text = "https://api.good-proxies.ru/get.php?type%5Bsocks4%5D=on&count=&ping=5000&time=600" +
    "&works=100&key=728c5dd493b47f0fa9dbc048b5e4bb7d";
            this.tbProxy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbProxy.MouseEnter += new System.EventHandler(this.tbProxy_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(112, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "@Pirate2110";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.lbBad);
            this.panel4.Controls.Add(this.lbError);
            this.panel4.Controls.Add(this.lbGood);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 140);
            this.panel4.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel11.Controls.Add(this.label13);
            this.panel11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel11.Location = new System.Drawing.Point(226, 83);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(87, 26);
            this.panel11.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(21, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "PAUSE";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel10.Controls.Add(this.label12);
            this.panel10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel10.Location = new System.Drawing.Point(226, 51);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(87, 26);
            this.panel10.TabIndex = 5;
            this.panel10.Click += new System.EventHandler(this.panel10_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(25, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "STOP";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel9.Controls.Add(this.label11);
            this.panel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel9.Location = new System.Drawing.Point(226, 20);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(87, 26);
            this.panel9.TabIndex = 4;
            this.panel9.Click += new System.EventHandler(this.panel9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(22, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "START";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lbBad
            // 
            this.lbBad.AutoSize = true;
            this.lbBad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lbBad.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbBad.Location = new System.Drawing.Point(84, 59);
            this.lbBad.Name = "lbBad";
            this.lbBad.Size = new System.Drawing.Size(16, 18);
            this.lbBad.TabIndex = 11;
            this.lbBad.Text = "0";
            this.lbBad.MouseEnter += new System.EventHandler(this.lbBad_MouseEnter);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lbError.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbError.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbError.Location = new System.Drawing.Point(84, 91);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(40, 18);
            this.lbError.TabIndex = 10;
            this.lbError.Text = "0/0/0";
            this.lbError.MouseEnter += new System.EventHandler(this.lbError_MouseEnter);
            // 
            // lbGood
            // 
            this.lbGood.AutoSize = true;
            this.lbGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lbGood.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGood.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbGood.Location = new System.Drawing.Point(84, 28);
            this.lbGood.Name = "lbGood";
            this.lbGood.Size = new System.Drawing.Size(16, 18);
            this.lbGood.TabIndex = 9;
            this.lbGood.Text = "0";
            this.lbGood.MouseEnter += new System.EventHandler(this.lbGood_MouseEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(19, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Error : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(26, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bad : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(17, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Good : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // proxyTimer
            // 
            this.proxyTimer.Tick += new System.EventHandler(this.proxyTimer_Tick);
            // 
            // statTimer
            // 
            this.statTimer.Interval = 10;
            this.statTimer.Tick += new System.EventHandler(this.statTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(665, 288);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProxyInterval)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbSource;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbProxy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbBad;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label lbGood;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbProxyUpdate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudProxyInterval;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label lbProxy;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbSettings;
        private System.Windows.Forms.Panel panel11;
        public System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel10;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer proxyTimer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer statTimer;
    }
}

