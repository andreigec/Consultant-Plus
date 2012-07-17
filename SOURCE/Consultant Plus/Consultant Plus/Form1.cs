using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ANDREICSLIB;
using ANDREICSLIB.ClassExtras;

namespace Consultant_Plus
{
    public partial class Form1 : Form
    {
        #region licensing

        private const string AppTitle = "Consultant Plus";
        private const double AppVersion = 0.1;
        private const String HelpString = "";

        private const String UpdatePath = "https://github.com/EvilSeven/Consultant-Plus/zipball/master";
        private const String VersionPath = "https://raw.github.com/EvilSeven/Consultant-Plus/master/INFO/version.txt";
        private const String ChangelogPath = "https://raw.github.com/EvilSeven/Consultant-Plus/master/INFO/changelog.txt";

        private readonly String OtherText =
            @"©" + DateTime.Now.Year +
            @" Andrei Gec (http://www.andreigec.net)

Licensed under GNU LGPL (http://www.gnu.org/)

Zip Assets © SharpZipLib (http://www.sharpdevelop.net/OpenSource/SharpZipLib/)
";
        #endregion

#region vars

        private Project p;
        private const string projectdir = "Project";

#endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(projectdir) == false)
                Directory.CreateDirectory(projectdir);

            CloseProject();

            Licensing.CreateLicense(this, HelpString, AppTitle, AppVersion, OtherText, VersionPath, UpdatePath, ChangelogPath, menuStrip1);
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pi = CreateProject.ShowDialogCreate();
            if (pi == null)
                return;

            var res = controller.CreateProject(projectdir,pi);

            if (res.Item2==null)
            {
                MessageBox.Show("An error occured when creating the project:\n"+res.Item1);
                return;
            }

            OpenProject(res.Item2);
        }

        private void OpenProject(Project pn)
        {
            devteamlabel.Text = pn.DeveloperName;
            projectnamelabel.Text = pn.ProjectName;
            clientlabel.Text = pn.ClientName;
            currencycodelabel.Text = pn.CurrencyCode;
            p = pn;
            TabPageUpdates.SetEnableOnAllTabPagesInTabControl(tabControl1, true); 
        }

        private void CloseProject()
        {
            p = null;
            devteamlabel.Text = "";
            projectnamelabel.Text = "";
            clientlabel.Text = "";
            currencycodelabel.Text = "";
            StopTimer();
            TabPageUpdates.SetEnableOnAllTabPagesInTabControl(tabControl1,false,new ListUpdates<TabPage>(){infopage});
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            var pp = DirectoryUpdates.GetExePath() + "\\" + projectdir;
            fbd.SelectedPath = pp;
            fbd.Description = "Select project to open";
            var r = fbd.ShowDialog();

            if (r != DialogResult.OK)
                return;

            var res = controller.LoadProject(fbd.SelectedPath);

            if (res==null)
            {
                MessageBox.Show("There was an error loading the project");
                return;
            }

            OpenProject(res);
        }

        private double accumulatedSeconds = 0;
        private void closeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseProject();
        }

        private void starttimebutton_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void pausetimerbutton_Click(object sender, EventArgs e)
        {
         PauseTimer();  
        }

        private void resettimerbutton_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Are you sure?", "question", MessageBoxButtons.YesNo);
            if (r != DialogResult.Yes)
                return;

            accumulatedSeconds = 0;
        }

        private void StopTimer()
        {
            timer1.Stop();
            accumulatedSeconds = 0;
            UpdateTickLabel();
            SetPostTimeButton();
        }

        private void StartTimer()
        {
            UpdateTickLabel();
            timer1.Start();
            SetPostTimeButton();
        }

        private void PauseTimer()
        {
            UpdateTickLabel();
            timer1.Stop();
            SetPostTimeButton();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            accumulatedSeconds += timer1.Interval / 1000.0;
            UpdateTickLabel();
        }

        private  void UpdateTickLabel()
        {
            timelabel.Text = TimeUpdates.TimeInWords((int)accumulatedSeconds);
        }

        private void SetPostTimeButton()
        {
            if (timer1.Enabled)
            {
                posttimebutton.Text = "Pause Timer To Post Session Into Log";
                posttimebutton.Enabled = false;
            }
            else
            {
                posttimebutton.Text = "Post Session Into Time Log";
                posttimebutton.Enabled = true;
            }
            
        }

        private void hourcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextboxUpdates.HandleInputAsFloat(e.KeyChar, hourcost);
        }
    }
}
