namespace D42OpenDisc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Windows = new System.Windows.Forms.TabPage();
            this.wintolabel = new System.Windows.Forms.Label();
            this.winfromlabel = new System.Windows.Forms.Label();
            this.winrange = new System.Windows.Forms.RadioButton();
            this.winto = new System.Windows.Forms.TextBox();
            this.winfrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.winpass = new System.Windows.Forms.TextBox();
            this.winuser = new System.Windows.Forms.TextBox();
            this.winrunnow = new System.Windows.Forms.Button();
            this.wincomputers = new System.Windows.Forms.RichTextBox();
            this.allinlist = new System.Windows.Forms.RadioButton();
            this.alladservers = new System.Windows.Forms.RadioButton();
            this.alladcomputers = new System.Windows.Forms.RadioButton();
            this.Linux = new System.Windows.Forms.TabPage();
            this.linuxrun = new System.Windows.Forms.Button();
            this.linuxtolabel = new System.Windows.Forms.Label();
            this.linuxfromlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linuxto = new System.Windows.Forms.TextBox();
            this.linuxfrom = new System.Windows.Forms.TextBox();
            this.linuxrange = new System.Windows.Forms.RadioButton();
            this.linuxpass = new System.Windows.Forms.TextBox();
            this.linuxuser = new System.Windows.Forms.TextBox();
            this.linuxlist = new System.Windows.Forms.RichTextBox();
            this.linuxlistradio = new System.Windows.Forms.RadioButton();
            this.log = new System.Windows.Forms.TabPage();
            this.logbox = new System.Windows.Forms.RichTextBox();
            this.Help = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.Windows.SuspendLayout();
            this.Linux.SuspendLayout();
            this.log.SuspendLayout();
            this.Help.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Windows);
            this.tabControl1.Controls.Add(this.Linux);
            this.tabControl1.Controls.Add(this.log);
            this.tabControl1.Controls.Add(this.Help);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(580, 339);
            this.tabControl1.TabIndex = 0;
            // 
            // Windows
            // 
            this.Windows.Controls.Add(this.wintolabel);
            this.Windows.Controls.Add(this.winfromlabel);
            this.Windows.Controls.Add(this.winrange);
            this.Windows.Controls.Add(this.winto);
            this.Windows.Controls.Add(this.winfrom);
            this.Windows.Controls.Add(this.label6);
            this.Windows.Controls.Add(this.label5);
            this.Windows.Controls.Add(this.winpass);
            this.Windows.Controls.Add(this.winuser);
            this.Windows.Controls.Add(this.winrunnow);
            this.Windows.Controls.Add(this.wincomputers);
            this.Windows.Controls.Add(this.allinlist);
            this.Windows.Controls.Add(this.alladservers);
            this.Windows.Controls.Add(this.alladcomputers);
            this.Windows.Location = new System.Drawing.Point(4, 22);
            this.Windows.Name = "Windows";
            this.Windows.Padding = new System.Windows.Forms.Padding(3);
            this.Windows.Size = new System.Drawing.Size(572, 313);
            this.Windows.TabIndex = 0;
            this.Windows.Text = "Windows";
            this.Windows.UseVisualStyleBackColor = true;
            // 
            // wintolabel
            // 
            this.wintolabel.AutoSize = true;
            this.wintolabel.Location = new System.Drawing.Point(256, 91);
            this.wintolabel.Name = "wintolabel";
            this.wintolabel.Size = new System.Drawing.Size(20, 13);
            this.wintolabel.TabIndex = 13;
            this.wintolabel.Text = "To";
            this.wintolabel.Visible = false;
            // 
            // winfromlabel
            // 
            this.winfromlabel.AutoSize = true;
            this.winfromlabel.Location = new System.Drawing.Point(65, 90);
            this.winfromlabel.Name = "winfromlabel";
            this.winfromlabel.Size = new System.Drawing.Size(30, 13);
            this.winfromlabel.TabIndex = 12;
            this.winfromlabel.Text = "From";
            this.winfromlabel.Visible = false;
            // 
            // winrange
            // 
            this.winrange.AutoSize = true;
            this.winrange.Location = new System.Drawing.Point(30, 64);
            this.winrange.Name = "winrange";
            this.winrange.Size = new System.Drawing.Size(98, 17);
            this.winrange.TabIndex = 11;
            this.winrange.TabStop = true;
            this.winrange.Text = "IP Range(IPv4)";
            this.winrange.UseVisualStyleBackColor = true;
            this.winrange.CheckedChanged += new System.EventHandler(this.winrange_CheckedChanged);
            // 
            // winto
            // 
            this.winto.Location = new System.Drawing.Point(277, 85);
            this.winto.Name = "winto";
            this.winto.Size = new System.Drawing.Size(100, 20);
            this.winto.TabIndex = 10;
            this.winto.Visible = false;
            // 
            // winfrom
            // 
            this.winfrom.Location = new System.Drawing.Point(101, 87);
            this.winfrom.Name = "winfrom";
            this.winfrom.Size = new System.Drawing.Size(100, 20);
            this.winfrom.TabIndex = 9;
            this.winfrom.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "UserName";
            // 
            // winpass
            // 
            this.winpass.Location = new System.Drawing.Point(279, 18);
            this.winpass.Name = "winpass";
            this.winpass.Size = new System.Drawing.Size(100, 20);
            this.winpass.TabIndex = 6;
            this.winpass.UseSystemPasswordChar = true;
            // 
            // winuser
            // 
            this.winuser.Location = new System.Drawing.Point(101, 18);
            this.winuser.Name = "winuser";
            this.winuser.Size = new System.Drawing.Size(100, 20);
            this.winuser.TabIndex = 5;
            // 
            // winrunnow
            // 
            this.winrunnow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.winrunnow.Location = new System.Drawing.Point(490, 285);
            this.winrunnow.Name = "winrunnow";
            this.winrunnow.Size = new System.Drawing.Size(77, 23);
            this.winrunnow.TabIndex = 4;
            this.winrunnow.Text = "Start";
            this.winrunnow.UseVisualStyleBackColor = true;
            this.winrunnow.Click += new System.EventHandler(this.winrunnow_Click);
            // 
            // wincomputers
            // 
            this.wincomputers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wincomputers.Location = new System.Drawing.Point(101, 128);
            this.wincomputers.Name = "wincomputers";
            this.wincomputers.Size = new System.Drawing.Size(447, 152);
            this.wincomputers.TabIndex = 3;
            this.wincomputers.Text = "";
            this.wincomputers.Visible = false;
            // 
            // allinlist
            // 
            this.allinlist.AutoSize = true;
            this.allinlist.Location = new System.Drawing.Point(31, 110);
            this.allinlist.Name = "allinlist";
            this.allinlist.Size = new System.Drawing.Size(233, 17);
            this.allinlist.TabIndex = 2;
            this.allinlist.Text = "Following Computers(Separated by new line)";
            this.allinlist.UseVisualStyleBackColor = true;
            this.allinlist.CheckedChanged += new System.EventHandler(this.allinlist_CheckedChanged);
            // 
            // alladservers
            // 
            this.alladservers.AutoSize = true;
            this.alladservers.Checked = true;
            this.alladservers.Location = new System.Drawing.Point(221, 46);
            this.alladservers.Name = "alladservers";
            this.alladservers.Size = new System.Drawing.Size(164, 17);
            this.alladservers.TabIndex = 1;
            this.alladservers.TabStop = true;
            this.alladservers.Text = "All Servers in Active Directory";
            this.alladservers.UseVisualStyleBackColor = true;
            this.alladservers.CheckedChanged += new System.EventHandler(this.alladservers_CheckedChanged);
            // 
            // alladcomputers
            // 
            this.alladcomputers.AutoSize = true;
            this.alladcomputers.Location = new System.Drawing.Point(30, 46);
            this.alladcomputers.Name = "alladcomputers";
            this.alladcomputers.Size = new System.Drawing.Size(178, 17);
            this.alladcomputers.TabIndex = 0;
            this.alladcomputers.Text = "All Computers in Active Directory";
            this.alladcomputers.UseVisualStyleBackColor = true;
            this.alladcomputers.CheckedChanged += new System.EventHandler(this.alladcomputers_CheckedChanged);
            // 
            // Linux
            // 
            this.Linux.Controls.Add(this.linuxrun);
            this.Linux.Controls.Add(this.linuxtolabel);
            this.Linux.Controls.Add(this.linuxfromlabel);
            this.Linux.Controls.Add(this.label2);
            this.Linux.Controls.Add(this.label1);
            this.Linux.Controls.Add(this.linuxto);
            this.Linux.Controls.Add(this.linuxfrom);
            this.Linux.Controls.Add(this.linuxrange);
            this.Linux.Controls.Add(this.linuxpass);
            this.Linux.Controls.Add(this.linuxuser);
            this.Linux.Controls.Add(this.linuxlist);
            this.Linux.Controls.Add(this.linuxlistradio);
            this.Linux.Location = new System.Drawing.Point(4, 22);
            this.Linux.Name = "Linux";
            this.Linux.Padding = new System.Windows.Forms.Padding(3);
            this.Linux.Size = new System.Drawing.Size(572, 313);
            this.Linux.TabIndex = 1;
            this.Linux.Text = "Linux";
            this.Linux.UseVisualStyleBackColor = true;
            // 
            // linuxrun
            // 
            this.linuxrun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linuxrun.Location = new System.Drawing.Point(463, 284);
            this.linuxrun.Name = "linuxrun";
            this.linuxrun.Size = new System.Drawing.Size(75, 23);
            this.linuxrun.TabIndex = 11;
            this.linuxrun.Text = "Start";
            this.linuxrun.UseVisualStyleBackColor = true;
            this.linuxrun.Click += new System.EventHandler(this.linuxrun_Click);
            // 
            // linuxtolabel
            // 
            this.linuxtolabel.AutoSize = true;
            this.linuxtolabel.Location = new System.Drawing.Point(242, 75);
            this.linuxtolabel.Name = "linuxtolabel";
            this.linuxtolabel.Size = new System.Drawing.Size(20, 13);
            this.linuxtolabel.TabIndex = 10;
            this.linuxtolabel.Text = "To";
            this.linuxtolabel.Visible = false;
            // 
            // linuxfromlabel
            // 
            this.linuxfromlabel.AutoSize = true;
            this.linuxfromlabel.Location = new System.Drawing.Point(63, 75);
            this.linuxfromlabel.Name = "linuxfromlabel";
            this.linuxfromlabel.Size = new System.Drawing.Size(30, 13);
            this.linuxfromlabel.TabIndex = 9;
            this.linuxfromlabel.Text = "From";
            this.linuxfromlabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "UserName";
            // 
            // linuxto
            // 
            this.linuxto.Location = new System.Drawing.Point(268, 72);
            this.linuxto.Name = "linuxto";
            this.linuxto.Size = new System.Drawing.Size(100, 20);
            this.linuxto.TabIndex = 6;
            this.linuxto.Visible = false;
            // 
            // linuxfrom
            // 
            this.linuxfrom.Location = new System.Drawing.Point(99, 72);
            this.linuxfrom.Name = "linuxfrom";
            this.linuxfrom.Size = new System.Drawing.Size(100, 20);
            this.linuxfrom.TabIndex = 5;
            this.linuxfrom.Visible = false;
            // 
            // linuxrange
            // 
            this.linuxrange.AutoSize = true;
            this.linuxrange.Location = new System.Drawing.Point(39, 46);
            this.linuxrange.Name = "linuxrange";
            this.linuxrange.Size = new System.Drawing.Size(125, 17);
            this.linuxrange.TabIndex = 4;
            this.linuxrange.Text = "IP Range (IPv4 Only)";
            this.linuxrange.UseVisualStyleBackColor = true;
            this.linuxrange.CheckedChanged += new System.EventHandler(this.linuxrange_CheckedChanged);
            // 
            // linuxpass
            // 
            this.linuxpass.Location = new System.Drawing.Point(269, 19);
            this.linuxpass.Name = "linuxpass";
            this.linuxpass.Size = new System.Drawing.Size(100, 20);
            this.linuxpass.TabIndex = 3;
            this.linuxpass.UseSystemPasswordChar = true;
            // 
            // linuxuser
            // 
            this.linuxuser.Location = new System.Drawing.Point(99, 19);
            this.linuxuser.Name = "linuxuser";
            this.linuxuser.Size = new System.Drawing.Size(100, 20);
            this.linuxuser.TabIndex = 2;
            // 
            // linuxlist
            // 
            this.linuxlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.linuxlist.Location = new System.Drawing.Point(86, 124);
            this.linuxlist.Name = "linuxlist";
            this.linuxlist.Size = new System.Drawing.Size(453, 154);
            this.linuxlist.TabIndex = 1;
            this.linuxlist.Text = "";
            // 
            // linuxlistradio
            // 
            this.linuxlistradio.AutoSize = true;
            this.linuxlistradio.Checked = true;
            this.linuxlistradio.Location = new System.Drawing.Point(40, 101);
            this.linuxlistradio.Name = "linuxlistradio";
            this.linuxlistradio.Size = new System.Drawing.Size(155, 17);
            this.linuxlistradio.TabIndex = 0;
            this.linuxlistradio.TabStop = true;
            this.linuxlistradio.Text = "List (Separated by new line)";
            this.linuxlistradio.UseVisualStyleBackColor = true;
            // 
            // log
            // 
            this.log.Controls.Add(this.logbox);
            this.log.Location = new System.Drawing.Point(4, 22);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(572, 313);
            this.log.TabIndex = 3;
            this.log.Text = "Log";
            this.log.UseVisualStyleBackColor = true;
            // 
            // logbox
            // 
            this.logbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.logbox.Location = new System.Drawing.Point(-4, 3);
            this.logbox.Name = "logbox";
            this.logbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.logbox.ShowSelectionMargin = true;
            this.logbox.Size = new System.Drawing.Size(576, 310);
            this.logbox.TabIndex = 0;
            this.logbox.Text = "";
            // 
            // Help
            // 
            this.Help.Controls.Add(this.label3);
            this.Help.Controls.Add(this.linkLabel1);
            this.Help.Location = new System.Drawing.Point(4, 22);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(572, 313);
            this.Help.TabIndex = 4;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Documentation available at:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(156, 50);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(236, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://docs.device42.com/open-discovery-client";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 335);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Device42 - Open Discovery v1.0.1";
            this.tabControl1.ResumeLayout(false);
            this.Windows.ResumeLayout(false);
            this.Windows.PerformLayout();
            this.Linux.ResumeLayout(false);
            this.Linux.PerformLayout();
            this.log.ResumeLayout(false);
            this.Help.ResumeLayout(false);
            this.Help.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Windows;
        private System.Windows.Forms.TabPage Linux;
        private System.Windows.Forms.RichTextBox wincomputers;
        private System.Windows.Forms.RadioButton allinlist;
        private System.Windows.Forms.RadioButton alladservers;
        private System.Windows.Forms.RadioButton alladcomputers;
        private System.Windows.Forms.Button winrunnow;
        private System.Windows.Forms.TabPage log;
        private System.Windows.Forms.RichTextBox logbox;
        private System.Windows.Forms.RichTextBox linuxlist;
        private System.Windows.Forms.RadioButton linuxlistradio;
        private System.Windows.Forms.TextBox linuxpass;
        private System.Windows.Forms.TextBox linuxuser;
        private System.Windows.Forms.RadioButton linuxrange;
        private System.Windows.Forms.Button linuxrun;
        private System.Windows.Forms.Label linuxtolabel;
        private System.Windows.Forms.Label linuxfromlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox linuxto;
        private System.Windows.Forms.TextBox linuxfrom;
        private System.Windows.Forms.TextBox winpass;
        private System.Windows.Forms.TextBox winuser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label wintolabel;
        private System.Windows.Forms.Label winfromlabel;
        private System.Windows.Forms.RadioButton winrange;
        private System.Windows.Forms.TextBox winto;
        private System.Windows.Forms.TextBox winfrom;
        private System.Windows.Forms.TabPage Help;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

