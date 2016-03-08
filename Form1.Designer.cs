namespace Consultant_Plus
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLastProjectOnStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.infopage = new System.Windows.Forms.TabPage();
            this.editbutton = new System.Windows.Forms.Button();
            this.clientlabel = new System.Windows.Forms.Label();
            this.devteamlabel = new System.Windows.Forms.Label();
            this.currencycodelabel = new System.Windows.Forms.Label();
            this.projectnamelabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timesheet = new System.Windows.Forms.TabPage();
            this.secondsTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.minutesTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.hoursTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.daysTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.datetextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.commentstextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hourcost = new System.Windows.Forms.TextBox();
            this.posttimebutton = new System.Windows.Forms.Button();
            this.resettimerbutton = new System.Windows.Forms.Button();
            this.pausetimerbutton = new System.Windows.Forms.Button();
            this.starttimebutton = new System.Windows.Forms.Button();
            this.timelogs = new System.Windows.Forms.TabPage();
            this.deletesessionbutton = new System.Windows.Forms.Button();
            this.editsessionbutton = new System.Windows.Forms.Button();
            this.sessions = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.infopage.SuspendLayout();
            this.timesheet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.timelogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.closeProjectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.closeProjectToolStripMenuItem.Text = "Close Project";
            this.closeProjectToolStripMenuItem.Click += new System.EventHandler(this.closeProjectToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadLastProjectOnStartupToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // loadLastProjectOnStartupToolStripMenuItem
            // 
            this.loadLastProjectOnStartupToolStripMenuItem.Checked = true;
            this.loadLastProjectOnStartupToolStripMenuItem.CheckOnClick = true;
            this.loadLastProjectOnStartupToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loadLastProjectOnStartupToolStripMenuItem.Name = "loadLastProjectOnStartupToolStripMenuItem";
            this.loadLastProjectOnStartupToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.loadLastProjectOnStartupToolStripMenuItem.Text = "Load Last Project On Startup";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.infopage);
            this.tabControl1.Controls.Add(this.timesheet);
            this.tabControl1.Controls.Add(this.timelogs);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(456, 429);
            this.tabControl1.TabIndex = 1;
            // 
            // infopage
            // 
            this.infopage.Controls.Add(this.editbutton);
            this.infopage.Controls.Add(this.clientlabel);
            this.infopage.Controls.Add(this.devteamlabel);
            this.infopage.Controls.Add(this.currencycodelabel);
            this.infopage.Controls.Add(this.projectnamelabel);
            this.infopage.Controls.Add(this.label4);
            this.infopage.Controls.Add(this.label3);
            this.infopage.Controls.Add(this.label2);
            this.infopage.Controls.Add(this.label1);
            this.infopage.Location = new System.Drawing.Point(4, 22);
            this.infopage.Name = "infopage";
            this.infopage.Padding = new System.Windows.Forms.Padding(3);
            this.infopage.Size = new System.Drawing.Size(448, 403);
            this.infopage.TabIndex = 0;
            this.infopage.Text = "Info";
            this.infopage.UseVisualStyleBackColor = true;
            // 
            // editbutton
            // 
            this.editbutton.Location = new System.Drawing.Point(11, 6);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(75, 23);
            this.editbutton.TabIndex = 17;
            this.editbutton.Text = "Edit";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // clientlabel
            // 
            this.clientlabel.AutoSize = true;
            this.clientlabel.Location = new System.Drawing.Point(138, 170);
            this.clientlabel.Name = "clientlabel";
            this.clientlabel.Size = new System.Drawing.Size(10, 13);
            this.clientlabel.TabIndex = 16;
            this.clientlabel.Text = " ";
            // 
            // devteamlabel
            // 
            this.devteamlabel.AutoSize = true;
            this.devteamlabel.Location = new System.Drawing.Point(138, 131);
            this.devteamlabel.Name = "devteamlabel";
            this.devteamlabel.Size = new System.Drawing.Size(10, 13);
            this.devteamlabel.TabIndex = 15;
            this.devteamlabel.Text = " ";
            // 
            // currencycodelabel
            // 
            this.currencycodelabel.AutoSize = true;
            this.currencycodelabel.Location = new System.Drawing.Point(138, 92);
            this.currencycodelabel.Name = "currencycodelabel";
            this.currencycodelabel.Size = new System.Drawing.Size(10, 13);
            this.currencycodelabel.TabIndex = 14;
            this.currencycodelabel.Text = " ";
            // 
            // projectnamelabel
            // 
            this.projectnamelabel.AutoSize = true;
            this.projectnamelabel.Location = new System.Drawing.Point(138, 53);
            this.projectnamelabel.Name = "projectnamelabel";
            this.projectnamelabel.Size = new System.Drawing.Size(10, 13);
            this.projectnamelabel.TabIndex = 13;
            this.projectnamelabel.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Client Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Development Team Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Currency Code (eg USD)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Project Name";
            // 
            // timesheet
            // 
            this.timesheet.Controls.Add(this.secondsTB);
            this.timesheet.Controls.Add(this.label11);
            this.timesheet.Controls.Add(this.minutesTB);
            this.timesheet.Controls.Add(this.label10);
            this.timesheet.Controls.Add(this.hoursTB);
            this.timesheet.Controls.Add(this.label9);
            this.timesheet.Controls.Add(this.daysTB);
            this.timesheet.Controls.Add(this.label6);
            this.timesheet.Controls.Add(this.groupBox1);
            this.timesheet.Controls.Add(this.resettimerbutton);
            this.timesheet.Controls.Add(this.pausetimerbutton);
            this.timesheet.Controls.Add(this.starttimebutton);
            this.timesheet.Location = new System.Drawing.Point(4, 22);
            this.timesheet.Name = "timesheet";
            this.timesheet.Padding = new System.Windows.Forms.Padding(3);
            this.timesheet.Size = new System.Drawing.Size(448, 403);
            this.timesheet.TabIndex = 1;
            this.timesheet.Text = "Session";
            this.timesheet.UseVisualStyleBackColor = true;
            // 
            // secondsTB
            // 
            this.secondsTB.Location = new System.Drawing.Point(176, 32);
            this.secondsTB.MaxLength = 2;
            this.secondsTB.Name = "secondsTB";
            this.secondsTB.Size = new System.Drawing.Size(49, 20);
            this.secondsTB.TabIndex = 16;
            this.secondsTB.Text = "0";
            this.secondsTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondsTB_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(173, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Seconds";
            // 
            // minutesTB
            // 
            this.minutesTB.Location = new System.Drawing.Point(121, 32);
            this.minutesTB.MaxLength = 2;
            this.minutesTB.Name = "minutesTB";
            this.minutesTB.Size = new System.Drawing.Size(49, 20);
            this.minutesTB.TabIndex = 14;
            this.minutesTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minutesTB_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Minutes";
            // 
            // hoursTB
            // 
            this.hoursTB.Location = new System.Drawing.Point(64, 32);
            this.hoursTB.MaxLength = 2;
            this.hoursTB.Name = "hoursTB";
            this.hoursTB.Size = new System.Drawing.Size(49, 20);
            this.hoursTB.TabIndex = 12;
            this.hoursTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hoursTB_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Hours";
            // 
            // daysTB
            // 
            this.daysTB.Location = new System.Drawing.Point(9, 32);
            this.daysTB.Name = "daysTB";
            this.daysTB.Size = new System.Drawing.Size(49, 20);
            this.daysTB.TabIndex = 10;
            this.daysTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.daysTB_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Days";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.datetextbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.commentstextbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.hourcost);
            this.groupBox1.Controls.Add(this.posttimebutton);
            this.groupBox1.Location = new System.Drawing.Point(8, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 297);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posting to Log";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Date";
            // 
            // datetextbox
            // 
            this.datetextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datetextbox.Location = new System.Drawing.Point(146, 38);
            this.datetextbox.Name = "datetextbox";
            this.datetextbox.Size = new System.Drawing.Size(280, 20);
            this.datetextbox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Comments";
            // 
            // commentstextbox
            // 
            this.commentstextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentstextbox.Location = new System.Drawing.Point(6, 79);
            this.commentstextbox.Multiline = true;
            this.commentstextbox.Name = "commentstextbox";
            this.commentstextbox.Size = new System.Drawing.Size(420, 183);
            this.commentstextbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cost per hour in currency";
            // 
            // hourcost
            // 
            this.hourcost.Location = new System.Drawing.Point(6, 38);
            this.hourcost.Name = "hourcost";
            this.hourcost.Size = new System.Drawing.Size(100, 20);
            this.hourcost.TabIndex = 7;
            this.hourcost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hourcost_KeyPress);
            // 
            // posttimebutton
            // 
            this.posttimebutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.posttimebutton.Location = new System.Drawing.Point(6, 268);
            this.posttimebutton.Name = "posttimebutton";
            this.posttimebutton.Size = new System.Drawing.Size(420, 23);
            this.posttimebutton.TabIndex = 5;
            this.posttimebutton.Text = "PTB";
            this.posttimebutton.UseVisualStyleBackColor = true;
            this.posttimebutton.Click += new System.EventHandler(this.posttimebutton_Click);
            // 
            // resettimerbutton
            // 
            this.resettimerbutton.Location = new System.Drawing.Point(192, 69);
            this.resettimerbutton.Name = "resettimerbutton";
            this.resettimerbutton.Size = new System.Drawing.Size(75, 23);
            this.resettimerbutton.TabIndex = 4;
            this.resettimerbutton.Text = "Reset Timer";
            this.resettimerbutton.UseVisualStyleBackColor = true;
            this.resettimerbutton.Click += new System.EventHandler(this.resettimerbutton_Click);
            // 
            // pausetimerbutton
            // 
            this.pausetimerbutton.Location = new System.Drawing.Point(95, 69);
            this.pausetimerbutton.Name = "pausetimerbutton";
            this.pausetimerbutton.Size = new System.Drawing.Size(75, 23);
            this.pausetimerbutton.TabIndex = 3;
            this.pausetimerbutton.Text = "Pause Timer";
            this.pausetimerbutton.UseVisualStyleBackColor = true;
            this.pausetimerbutton.Click += new System.EventHandler(this.pausetimerbutton_Click);
            // 
            // starttimebutton
            // 
            this.starttimebutton.Location = new System.Drawing.Point(8, 69);
            this.starttimebutton.Name = "starttimebutton";
            this.starttimebutton.Size = new System.Drawing.Size(75, 23);
            this.starttimebutton.TabIndex = 2;
            this.starttimebutton.Text = "Start Timer";
            this.starttimebutton.UseVisualStyleBackColor = true;
            this.starttimebutton.Click += new System.EventHandler(this.starttimebutton_Click);
            // 
            // timelogs
            // 
            this.timelogs.Controls.Add(this.deletesessionbutton);
            this.timelogs.Controls.Add(this.editsessionbutton);
            this.timelogs.Controls.Add(this.sessions);
            this.timelogs.Location = new System.Drawing.Point(4, 22);
            this.timelogs.Name = "timelogs";
            this.timelogs.Size = new System.Drawing.Size(448, 403);
            this.timelogs.TabIndex = 2;
            this.timelogs.Text = "Time Logs";
            this.timelogs.UseVisualStyleBackColor = true;
            // 
            // deletesessionbutton
            // 
            this.deletesessionbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletesessionbutton.Location = new System.Drawing.Point(336, 372);
            this.deletesessionbutton.Name = "deletesessionbutton";
            this.deletesessionbutton.Size = new System.Drawing.Size(104, 23);
            this.deletesessionbutton.TabIndex = 2;
            this.deletesessionbutton.Text = "Delete Session";
            this.deletesessionbutton.UseVisualStyleBackColor = true;
            this.deletesessionbutton.Click += new System.EventHandler(this.deletesessionbutton_Click);
            // 
            // editsessionbutton
            // 
            this.editsessionbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editsessionbutton.Location = new System.Drawing.Point(8, 372);
            this.editsessionbutton.Name = "editsessionbutton";
            this.editsessionbutton.Size = new System.Drawing.Size(322, 23);
            this.editsessionbutton.TabIndex = 1;
            this.editsessionbutton.Text = "Edit Session";
            this.editsessionbutton.UseVisualStyleBackColor = true;
            this.editsessionbutton.Click += new System.EventHandler(this.editsessionbutton_Click);
            // 
            // sessions
            // 
            this.sessions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sessions.FullRowSelect = true;
            this.sessions.Location = new System.Drawing.Point(8, 3);
            this.sessions.Name = "sessions";
            this.sessions.Size = new System.Drawing.Size(432, 363);
            this.sessions.TabIndex = 0;
            this.sessions.UseCompatibleStateImageBehavior = false;
            this.sessions.View = System.Windows.Forms.View.Details;
            this.sessions.SelectedIndexChanged += new System.EventHandler(this.sessions_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 453);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.infopage.ResumeLayout(false);
            this.infopage.PerformLayout();
            this.timesheet.ResumeLayout(false);
            this.timesheet.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.timelogs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage infopage;
        private System.Windows.Forms.TabPage timesheet;
        private System.Windows.Forms.TabPage timelogs;
        private System.Windows.Forms.Label clientlabel;
        private System.Windows.Forms.Label devteamlabel;
        private System.Windows.Forms.Label currencycodelabel;
        private System.Windows.Forms.Label projectnamelabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resettimerbutton;
        private System.Windows.Forms.Button pausetimerbutton;
        private System.Windows.Forms.Button starttimebutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button posttimebutton;
        private System.Windows.Forms.ListView sessions;
        private System.Windows.Forms.TextBox hourcost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox commentstextbox;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button deletesessionbutton;
        private System.Windows.Forms.Button editsessionbutton;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadLastProjectOnStartupToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox datetextbox;
        private System.Windows.Forms.TextBox secondsTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox minutesTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox hoursTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox daysTB;
        private System.Windows.Forms.Label label6;
    }
}

