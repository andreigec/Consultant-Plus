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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.infopage = new System.Windows.Forms.TabPage();
            this.clientlabel = new System.Windows.Forms.Label();
            this.devteamlabel = new System.Windows.Forms.Label();
            this.currencycodelabel = new System.Windows.Forms.Label();
            this.projectnamelabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timesheet = new System.Windows.Forms.TabPage();
            this.hourcost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.posttimebutton = new System.Windows.Forms.Button();
            this.resettimerbutton = new System.Windows.Forms.Button();
            this.pausetimerbutton = new System.Windows.Forms.Button();
            this.starttimebutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.timelogs = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.infopage.SuspendLayout();
            this.timesheet.SuspendLayout();
            this.timelogs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.infopage);
            this.tabControl1.Controls.Add(this.timesheet);
            this.tabControl1.Controls.Add(this.timelogs);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 299);
            this.tabControl1.TabIndex = 1;
            // 
            // infopage
            // 
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
            this.infopage.Size = new System.Drawing.Size(437, 273);
            this.infopage.TabIndex = 0;
            this.infopage.Text = "Info";
            this.infopage.UseVisualStyleBackColor = true;
            // 
            // clientlabel
            // 
            this.clientlabel.AutoSize = true;
            this.clientlabel.Location = new System.Drawing.Point(138, 129);
            this.clientlabel.Name = "clientlabel";
            this.clientlabel.Size = new System.Drawing.Size(10, 13);
            this.clientlabel.TabIndex = 16;
            this.clientlabel.Text = " ";
            // 
            // devteamlabel
            // 
            this.devteamlabel.AutoSize = true;
            this.devteamlabel.Location = new System.Drawing.Point(138, 90);
            this.devteamlabel.Name = "devteamlabel";
            this.devteamlabel.Size = new System.Drawing.Size(10, 13);
            this.devteamlabel.TabIndex = 15;
            this.devteamlabel.Text = " ";
            // 
            // currencycodelabel
            // 
            this.currencycodelabel.AutoSize = true;
            this.currencycodelabel.Location = new System.Drawing.Point(138, 51);
            this.currencycodelabel.Name = "currencycodelabel";
            this.currencycodelabel.Size = new System.Drawing.Size(10, 13);
            this.currencycodelabel.TabIndex = 14;
            this.currencycodelabel.Text = " ";
            // 
            // projectnamelabel
            // 
            this.projectnamelabel.AutoSize = true;
            this.projectnamelabel.Location = new System.Drawing.Point(138, 12);
            this.projectnamelabel.Name = "projectnamelabel";
            this.projectnamelabel.Size = new System.Drawing.Size(10, 13);
            this.projectnamelabel.TabIndex = 13;
            this.projectnamelabel.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Client Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Development Team Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Currency Code (eg USD)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Project Name";
            // 
            // timesheet
            // 
            this.timesheet.Controls.Add(this.groupBox1);
            this.timesheet.Controls.Add(this.resettimerbutton);
            this.timesheet.Controls.Add(this.pausetimerbutton);
            this.timesheet.Controls.Add(this.starttimebutton);
            this.timesheet.Controls.Add(this.label6);
            this.timesheet.Controls.Add(this.timelabel);
            this.timesheet.Location = new System.Drawing.Point(4, 22);
            this.timesheet.Name = "timesheet";
            this.timesheet.Padding = new System.Windows.Forms.Padding(3);
            this.timesheet.Size = new System.Drawing.Size(437, 273);
            this.timesheet.TabIndex = 1;
            this.timesheet.Text = "Session";
            this.timesheet.UseVisualStyleBackColor = true;
            // 
            // hourcost
            // 
            this.hourcost.Location = new System.Drawing.Point(9, 55);
            this.hourcost.Name = "hourcost";
            this.hourcost.Size = new System.Drawing.Size(100, 20);
            this.hourcost.TabIndex = 7;
            this.hourcost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hourcost_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cost per hour in currency";
            // 
            // posttimebutton
            // 
            this.posttimebutton.Location = new System.Drawing.Point(6, 94);
            this.posttimebutton.Name = "posttimebutton";
            this.posttimebutton.Size = new System.Drawing.Size(259, 23);
            this.posttimebutton.TabIndex = 5;
            this.posttimebutton.Text = "PTB";
            this.posttimebutton.UseVisualStyleBackColor = true;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Time:";
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Location = new System.Drawing.Point(88, 29);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(10, 13);
            this.timelabel.TabIndex = 0;
            this.timelabel.Text = " ";
            // 
            // timelogs
            // 
            this.timelogs.Controls.Add(this.listView1);
            this.timelogs.Location = new System.Drawing.Point(4, 22);
            this.timelogs.Name = "timelogs";
            this.timelogs.Size = new System.Drawing.Size(437, 273);
            this.timelogs.TabIndex = 2;
            this.timelogs.Text = "Time Logs";
            this.timelogs.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(8, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(421, 198);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Session Number";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hours";
            this.columnHeader2.Width = 68;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.hourcost);
            this.groupBox1.Controls.Add(this.posttimebutton);
            this.groupBox1.Location = new System.Drawing.Point(8, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 167);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posting to Log";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hourly Rate";
            this.columnHeader3.Width = 72;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Comments";
            this.columnHeader4.Width = 73;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 323);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.infopage.ResumeLayout(false);
            this.infopage.PerformLayout();
            this.timesheet.ResumeLayout(false);
            this.timesheet.PerformLayout();
            this.timelogs.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button posttimebutton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox hourcost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

