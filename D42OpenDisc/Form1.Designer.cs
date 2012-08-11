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
            this.win_progressbar = new System.Windows.Forms.ProgressBar();
            this.win_cancel = new System.Windows.Forms.Button();
            this.win_progress_label = new System.Windows.Forms.Label();
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
            this.winlist = new System.Windows.Forms.RichTextBox();
            this.allinlist = new System.Windows.Forms.RadioButton();
            this.Linux = new System.Windows.Forms.TabPage();
            this.linux_cancel = new System.Windows.Forms.Button();
            this.linux_progress_label = new System.Windows.Forms.Label();
            this.linux_progressbar = new System.Windows.Forms.ProgressBar();
            this.ignoreDomain = new System.Windows.Forms.CheckBox();
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
            this.Settings = new System.Windows.Forms.TabPage();
            this.file_path_button = new System.Windows.Forms.Button();
            this.file_path = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.LabelD42 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.About = new System.Windows.Forms.TabPage();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.Windows.SuspendLayout();
            this.Linux.SuspendLayout();
            this.log.SuspendLayout();
            this.Settings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.About.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.Settings);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.About);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 477);
            this.tabControl1.TabIndex = 0;
            // 
            // Windows
            // 
            this.Windows.Controls.Add(this.win_progressbar);
            this.Windows.Controls.Add(this.win_cancel);
            this.Windows.Controls.Add(this.win_progress_label);
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
            this.Windows.Controls.Add(this.winlist);
            this.Windows.Controls.Add(this.allinlist);
            this.Windows.Location = new System.Drawing.Point(4, 22);
            this.Windows.Name = "Windows";
            this.Windows.Padding = new System.Windows.Forms.Padding(3);
            this.Windows.Size = new System.Drawing.Size(795, 451);
            this.Windows.TabIndex = 0;
            this.Windows.Text = "Windows";
            this.Windows.UseVisualStyleBackColor = true;
            // 
            // win_progressbar
            // 
            this.win_progressbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.win_progressbar.Location = new System.Drawing.Point(30, 402);
            this.win_progressbar.Name = "win_progressbar";
            this.win_progressbar.Size = new System.Drawing.Size(732, 23);
            this.win_progressbar.TabIndex = 16;
            // 
            // win_cancel
            // 
            this.win_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.win_cancel.Enabled = false;
            this.win_cancel.Location = new System.Drawing.Point(30, 363);
            this.win_cancel.Name = "win_cancel";
            this.win_cancel.Size = new System.Drawing.Size(75, 23);
            this.win_cancel.TabIndex = 15;
            this.win_cancel.Text = "Cancel";
            this.win_cancel.UseVisualStyleBackColor = true;
            this.win_cancel.Click += new System.EventHandler(this.win_cancel_Click);
            // 
            // win_progress_label
            // 
            this.win_progress_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.win_progress_label.AutoSize = true;
            this.win_progress_label.Location = new System.Drawing.Point(27, 427);
            this.win_progress_label.Name = "win_progress_label";
            this.win_progress_label.Size = new System.Drawing.Size(51, 13);
            this.win_progress_label.TabIndex = 14;
            this.win_progress_label.Text = "Progress:";
            // 
            // wintolabel
            // 
            this.wintolabel.AutoSize = true;
            this.wintolabel.Location = new System.Drawing.Point(277, 92);
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
            this.winrange.Text = "IP Range(IPv4)";
            this.winrange.UseVisualStyleBackColor = true;
            this.winrange.CheckedChanged += new System.EventHandler(this.winrange_CheckedChanged);
            // 
            // winto
            // 
            this.winto.Location = new System.Drawing.Point(303, 90);
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
            this.label6.Location = new System.Drawing.Point(244, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Domain\\Username";
            // 
            // winpass
            // 
            this.winpass.Location = new System.Drawing.Point(303, 17);
            this.winpass.Name = "winpass";
            this.winpass.Size = new System.Drawing.Size(100, 20);
            this.winpass.TabIndex = 6;
            this.winpass.UseSystemPasswordChar = true;
            // 
            // winuser
            // 
            this.winuser.Location = new System.Drawing.Point(129, 17);
            this.winuser.Name = "winuser";
            this.winuser.Size = new System.Drawing.Size(100, 20);
            this.winuser.TabIndex = 5;
            // 
            // winrunnow
            // 
            this.winrunnow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.winrunnow.Location = new System.Drawing.Point(687, 363);
            this.winrunnow.Name = "winrunnow";
            this.winrunnow.Size = new System.Drawing.Size(77, 23);
            this.winrunnow.TabIndex = 4;
            this.winrunnow.Text = "Start";
            this.winrunnow.UseVisualStyleBackColor = true;
            this.winrunnow.Click += new System.EventHandler(this.winrunnow_Click);
            // 
            // winlist
            // 
            this.winlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.winlist.Location = new System.Drawing.Point(30, 138);
            this.winlist.Name = "winlist";
            this.winlist.Size = new System.Drawing.Size(732, 219);
            this.winlist.TabIndex = 3;
            this.winlist.Text = "";
            // 
            // allinlist
            // 
            this.allinlist.AutoSize = true;
            this.allinlist.Checked = true;
            this.allinlist.Location = new System.Drawing.Point(30, 115);
            this.allinlist.Name = "allinlist";
            this.allinlist.Size = new System.Drawing.Size(233, 17);
            this.allinlist.TabIndex = 2;
            this.allinlist.TabStop = true;
            this.allinlist.Text = "Following Computers(Separated by new line)";
            this.allinlist.UseVisualStyleBackColor = true;
            this.allinlist.CheckedChanged += new System.EventHandler(this.allinlist_CheckedChanged);
            // 
            // Linux
            // 
            this.Linux.Controls.Add(this.linux_cancel);
            this.Linux.Controls.Add(this.linux_progress_label);
            this.Linux.Controls.Add(this.linux_progressbar);
            this.Linux.Controls.Add(this.ignoreDomain);
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
            this.Linux.Size = new System.Drawing.Size(795, 451);
            this.Linux.TabIndex = 1;
            this.Linux.Text = "Linux";
            this.Linux.UseVisualStyleBackColor = true;
            // 
            // linux_cancel
            // 
            this.linux_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linux_cancel.Enabled = false;
            this.linux_cancel.Location = new System.Drawing.Point(39, 365);
            this.linux_cancel.Name = "linux_cancel";
            this.linux_cancel.Size = new System.Drawing.Size(75, 23);
            this.linux_cancel.TabIndex = 17;
            this.linux_cancel.Text = "Cancel";
            this.linux_cancel.UseVisualStyleBackColor = true;
            this.linux_cancel.Click += new System.EventHandler(this.linux_cancel_Click);
            // 
            // linux_progress_label
            // 
            this.linux_progress_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linux_progress_label.AutoSize = true;
            this.linux_progress_label.Location = new System.Drawing.Point(39, 422);
            this.linux_progress_label.Name = "linux_progress_label";
            this.linux_progress_label.Size = new System.Drawing.Size(54, 13);
            this.linux_progress_label.TabIndex = 16;
            this.linux_progress_label.Text = "Progress: ";
            // 
            // linux_progressbar
            // 
            this.linux_progressbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linux_progressbar.Location = new System.Drawing.Point(40, 394);
            this.linux_progressbar.Name = "linux_progressbar";
            this.linux_progressbar.Size = new System.Drawing.Size(723, 23);
            this.linux_progressbar.TabIndex = 14;
            // 
            // ignoreDomain
            // 
            this.ignoreDomain.AutoSize = true;
            this.ignoreDomain.Checked = true;
            this.ignoreDomain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ignoreDomain.Location = new System.Drawing.Point(40, 54);
            this.ignoreDomain.Name = "ignoreDomain";
            this.ignoreDomain.Size = new System.Drawing.Size(218, 17);
            this.ignoreDomain.TabIndex = 13;
            this.ignoreDomain.Text = "Use only hostname (ignore domain suffix)";
            this.ignoreDomain.UseVisualStyleBackColor = true;
            // 
            // linuxrun
            // 
            this.linuxrun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linuxrun.Location = new System.Drawing.Point(687, 363);
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
            this.linuxtolabel.Location = new System.Drawing.Point(242, 109);
            this.linuxtolabel.Name = "linuxtolabel";
            this.linuxtolabel.Size = new System.Drawing.Size(20, 13);
            this.linuxtolabel.TabIndex = 10;
            this.linuxtolabel.Text = "To";
            this.linuxtolabel.Visible = false;
            // 
            // linuxfromlabel
            // 
            this.linuxfromlabel.AutoSize = true;
            this.linuxfromlabel.Location = new System.Drawing.Point(63, 109);
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
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // linuxto
            // 
            this.linuxto.Location = new System.Drawing.Point(268, 106);
            this.linuxto.Name = "linuxto";
            this.linuxto.Size = new System.Drawing.Size(100, 20);
            this.linuxto.TabIndex = 6;
            this.linuxto.Visible = false;
            // 
            // linuxfrom
            // 
            this.linuxfrom.Location = new System.Drawing.Point(99, 106);
            this.linuxfrom.Name = "linuxfrom";
            this.linuxfrom.Size = new System.Drawing.Size(100, 20);
            this.linuxfrom.TabIndex = 5;
            this.linuxfrom.Visible = false;
            // 
            // linuxrange
            // 
            this.linuxrange.AutoSize = true;
            this.linuxrange.Location = new System.Drawing.Point(39, 80);
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
            this.linuxlist.Location = new System.Drawing.Point(39, 159);
            this.linuxlist.Name = "linuxlist";
            this.linuxlist.Size = new System.Drawing.Size(723, 198);
            this.linuxlist.TabIndex = 1;
            this.linuxlist.Text = "";
            // 
            // linuxlistradio
            // 
            this.linuxlistradio.AutoSize = true;
            this.linuxlistradio.Checked = true;
            this.linuxlistradio.Location = new System.Drawing.Point(40, 140);
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
            this.log.Size = new System.Drawing.Size(795, 451);
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
            this.logbox.Size = new System.Drawing.Size(799, 448);
            this.logbox.TabIndex = 0;
            this.logbox.Text = "";
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.file_path_button);
            this.Settings.Controls.Add(this.file_path);
            this.Settings.Controls.Add(this.password);
            this.Settings.Controls.Add(this.user);
            this.Settings.Controls.Add(this.LabelD42);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(795, 451);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // file_path_button
            // 
            this.file_path_button.Location = new System.Drawing.Point(82, 96);
            this.file_path_button.Name = "file_path_button";
            this.file_path_button.Size = new System.Drawing.Size(193, 23);
            this.file_path_button.TabIndex = 7;
            this.file_path_button.Text = "Change folder location for excel file";
            this.file_path_button.UseVisualStyleBackColor = true;
            this.file_path_button.Click += new System.EventHandler(this.file_path_button_Click);
            // 
            // file_path
            // 
            this.file_path.AutoSize = true;
            this.file_path.Location = new System.Drawing.Point(79, 60);
            this.file_path.Name = "file_path";
            this.file_path.Size = new System.Drawing.Size(166, 13);
            this.file_path.TabIndex = 6;
            this.file_path.Text = "Current folder where file is saved: ";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(35, 140);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(0, 13);
            this.password.TabIndex = 5;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(34, 96);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(0, 13);
            this.user.TabIndex = 4;
            // 
            // LabelD42
            // 
            this.LabelD42.AutoSize = true;
            this.LabelD42.Location = new System.Drawing.Point(33, 43);
            this.LabelD42.Name = "LabelD42";
            this.LabelD42.Size = new System.Drawing.Size(0, 13);
            this.LabelD42.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox6);
            this.tabPage1.Controls.Add(this.richTextBox5);
            this.tabPage1.Controls.Add(this.richTextBox3);
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(795, 451);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Help";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(56, 378);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(676, 44);
            this.richTextBox3.TabIndex = 4;
            this.richTextBox3.Text = "Cancelling: Depending on # of tasks started in the background, cancelling may tak" +
                "e a while as it has to wait for the processes to finish. You can close the execu" +
                "table for immediate abort.";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(56, 170);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(676, 146);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(56, 105);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(676, 59);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Documentation available at:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(308, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(319, 19);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://docs.device42.com/open-discovery-client";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // About
            // 
            this.About.Controls.Add(this.linkLabel4);
            this.About.Controls.Add(this.label8);
            this.About.Controls.Add(this.richTextBox4);
            this.About.Controls.Add(this.label7);
            this.About.Controls.Add(this.linkLabel3);
            this.About.Controls.Add(this.linkLabel2);
            this.About.Controls.Add(this.label4);
            this.About.Location = new System.Drawing.Point(4, 22);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(795, 451);
            this.About.TabIndex = 5;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.Location = new System.Drawing.Point(455, 147);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(61, 18);
            this.linkLabel4.TabIndex = 8;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "twitter.";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(421, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Want to know when next update is available? Follow us on ";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTextBox4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.Location = new System.Drawing.Point(43, 244);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(685, 183);
            this.richTextBox4.TabIndex = 6;
            this.richTextBox4.Text = resources.GetString("richTextBox4.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(259, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "About Open Discovery Client";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(38, 205);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(181, 25);
            this.linkLabel3.TabIndex = 4;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "About Device42";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(342, 107);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(386, 18);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://github.com/device42/Open-Discovery-Client";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(652, 72);
            this.label4.TabIndex = 0;
            this.label4.Text = "D42 Open Discovery client enumerates windows and linux devices on given network(s" +
                ") and \r\ncreates an excel sheet with the related information.\r\n\r\nSource Code and " +
                "licensing info available at: ";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Choose Folder where to save the file";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.Location = new System.Drawing.Point(56, 49);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.Size = new System.Drawing.Size(676, 50);
            this.richTextBox5.TabIndex = 5;
            this.richTextBox5.Text = "File Location: By default, file(D42_Device_IP.xlsx) is saved under the folder whe" +
                "re the open discovery client is installed. You can change the location where fil" +
                "e is saved from the settings tab.";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox6.Location = new System.Drawing.Point(56, 322);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            this.richTextBox6.Size = new System.Drawing.Size(676, 50);
            this.richTextBox6.TabIndex = 6;
            this.richTextBox6.Text = "Firewall Settings: For windows, wmi(RPC) port tcp/135 needs to be open and for li" +
                "nux ssh tcp/22 port needs to be opened.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 473);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "D42 Open Discovery v2.0.2";
            this.tabControl1.ResumeLayout(false);
            this.Windows.ResumeLayout(false);
            this.Windows.PerformLayout();
            this.Linux.ResumeLayout(false);
            this.Linux.PerformLayout();
            this.log.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.About.ResumeLayout(false);
            this.About.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Windows;
        private System.Windows.Forms.TabPage Linux;
        private System.Windows.Forms.RichTextBox winlist;
        private System.Windows.Forms.RadioButton allinlist;
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
        private System.Windows.Forms.CheckBox ignoreDomain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ProgressBar linux_progressbar;
        private System.Windows.Forms.Label linux_progress_label;
        private System.Windows.Forms.Button linux_cancel;
        private System.Windows.Forms.Label win_progress_label;
        private System.Windows.Forms.Button win_cancel;
        private System.Windows.Forms.ProgressBar win_progressbar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label LabelD42;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button file_path_button;
        private System.Windows.Forms.Label file_path;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
    }
}

