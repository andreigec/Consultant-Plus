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
using Consultant_Plus.ServiceReference1;

namespace Consultant_Plus
{
    public partial class Form1 : Form
    {
        #region licensing

        private const string AppTitle = "Consultant Plus";
        private const double AppVersion = 0.2;
        private const String HelpString = "";

        private readonly String OtherText =
            @"©" + DateTime.Now.Year +
            @" Andrei Gec (http://www.andreigec.net)

Licensed under GNU LGPL (http://www.gnu.org/)
";
        #endregion

        #region vars

        private Project p;
        private const string projectdir = "Project";
        public const string chargecolumn = "Charge";
        private const string cfgfile = "consultantplus.cfg";
        private const string previoussessionkeyword = "Previous Project";
        private double acculumatedTime = 0;

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

            Licensing.CreateLicense(this, menuStrip1, new Licensing.SolutionDetails(GetDetails, HelpString, AppTitle, AppVersion, OtherText));
            
            LoadConfig();
        }

        public Licensing.DownloadedSolutionDetails GetDetails()
        {
            try
            {
                var sr = new ServicesClient();
                var ti = sr.GetTitleInfo(AppTitle);
                if (ti == null)
                    return null;
                return ToDownloadedSolutionDetails(ti);

            }
            catch (Exception)
            {
            }
            return null;
        }

        public static Licensing.DownloadedSolutionDetails ToDownloadedSolutionDetails(TitleInfoServiceModel tism)
        {
            return new Licensing.DownloadedSolutionDetails()
            {
                ZipFileLocation = tism.LatestTitleDownloadPath,
                ChangeLog = tism.LatestTitleChangelog,
                Version = tism.LatestTitleVersion
            };
        }


        private void LoadConfig()
        {
            try
            {
                var literals = FormConfigRestore.LoadConfig(this, cfgfile);

                if (literals != null)
                {
                    foreach (var s in literals)
                    {
                        if (s.Item1.Equals(previoussessionkeyword))
                            LoadProject(s.Item2);
                    }
                }
            }
            catch (Exception)
            {
                try
                {
                    File.Delete(cfgfile);
                }
                catch (Exception)
                {
                    
                }
               
            }
            

        }

        private void SaveConfig()
        {
            var lc = new List<Control>();
            var tsi = new List<ToolStripItem>();
            tsi.Add(loadLastProjectOnStartupToolStripMenuItem);

            var sas = new List<Tuple<String, String>>();
            if (p!=null&&string.IsNullOrEmpty(p.GetProjectPath())==false)
                sas.Add(new Tuple<string, string>(previoussessionkeyword, p.GetProjectPath()));

            FormConfigRestore.SaveConfig(this, cfgfile, lc, tsi,sas);
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = controller.CreateProject(projectdir);

            if (p == null)
                return;

            OpenProject(p);
        }

        private void OpenProject(Project pn)
        {
            acculumatedTime = 0;
            editbutton.Enabled = true;
            devteamlabel.Text = pn.DeveloperName;
            projectnamelabel.Text = pn.ProjectName;
            clientlabel.Text = pn.ClientName;
            currencycodelabel.Text = pn.CurrencyCode;
            p = pn;
            TabPageExtras.SetEnableOnAllTabPagesInTabControl(tabControl1, true);
            LoadSessions();
            datetextbox.Text = DateTime.Now.ToShortDateString();
        }

        private void CloseProject()
        {
            acculumatedTime = 0;
            editbutton.Enabled = false;
            p = null;
            devteamlabel.Text = "";
            projectnamelabel.Text = "";
            clientlabel.Text = "";
            currencycodelabel.Text = "";
            StopTimer();
            ClearSessions();
            TabPageExtras.SetEnableOnAllTabPagesInTabControl(tabControl1, false, new List<TabPage>() { infopage });
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            var pp = DirectoryExtras.GetExePath() + "\\" + projectdir;
            fbd.SelectedPath = pp;
            fbd.Description = "Select project to open";
            var r = fbd.ShowDialog();

            if (r != DialogResult.OK)
                return;

            LoadProject(fbd.SelectedPath);
        }

        private  void LoadProject(String path)
        {
            var res = controller.LoadProject(path);

            if (res == null)
            {
                MessageBox.Show("There was an error loading the project");
                return;
            }

            OpenProject(res);  
        }

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

            ClearTime();
        }

        private void StopTimer()
        {
            timer1.Stop();
            ClearTime();
            SetPostTimeButton();
        }

        private void StartTimer()
        {
            acculumatedTime = GetTotalSeconds();
            daysTB.Enabled = hoursTB.Enabled = minutesTB.Enabled = secondsTB.Enabled = false;
            timer1.Start();
            SetPostTimeButton();
        }

        private void PauseTimer()
        {
            daysTB.Enabled = hoursTB.Enabled = minutesTB.Enabled = secondsTB.Enabled = true;
            timer1.Stop();
            SetPostTimeButton();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            acculumatedTime += timer1.Interval/1000.0;
            SetTime((int)acculumatedTime);
        }

        private void CheckTB(TextBox tb)
        {
            int r;
            if (string.IsNullOrEmpty(tb.Text) || int.TryParse(tb.Text, out r) == false)
                tb.Text = "0";
        }

        private int GetTotalSeconds()
        {
            CheckTB(daysTB);
            CheckTB(hoursTB);
            CheckTB(minutesTB);
            CheckTB(secondsTB);

            int d = int.Parse(daysTB.Text);
            int h = int.Parse(hoursTB.Text);
            int m = int.Parse(minutesTB.Text);
            int s = int.Parse(secondsTB.Text);

            return s + (m*60) + (h*3600) + (d*86400);
        }

        private void SetTime(int totalseconds)
        {
            daysTB.Text = ((int)TimeUpdates.GetDays(totalseconds)).ToString();
            hoursTB.Text = ((int)TimeUpdates.GetHours(totalseconds)).ToString();
            minutesTB.Text = ((int)TimeUpdates.GetMinutes(totalseconds)).ToString();
            secondsTB.Text = (totalseconds%60).ToString();
        }

        private void ClearTime()
        {
            daysTB.Text = hoursTB.Text = minutesTB.Text = secondsTB.Text = "0";  
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
            e.Handled = TextboxExtras.HandleInputAsFloat(e.KeyChar, hourcost);
        }

        private void posttimebutton_Click(object sender, EventArgs e)
        {
            double ts = 0;
            double h = 0;
            double hourlyrate = 0;
            try
            {
                ts = GetTotalSeconds();
                h = MathExtras.Truncate(TimeUpdates.GetHours(ts));
                hourlyrate = double.Parse(hourcost.Text);
            }
            catch (Exception)
            {
            }

            if (h == 0)
            {
                MessageBox.Show("Error, less than 0.00 hours");
                return;
            }

            var s = new Session(datetextbox.Text, hourlyrate, commentstextbox.Text, h);

            ListViewExtras.CopyClassToListView(sessions, s);
            controller.UpdateManualColumns(sessions, p);
            SaveSessions();
        }

        private List<Session> SerialiseSessions()
        {
            var os = ListViewExtras.GetObjectsFromListViewItems(sessions, typeof(Session));
            return ListExtras.ChangeListTyping<Session>(os);
        }

        private void DeserialiseSession(IEnumerable<Session> sessionsA)
        {
            ClearSessions();
            foreach (var s in sessionsA)
            {
                ListViewExtras.CopyClassToListView(sessions, s);
            }
        }

        private void SaveSessions()
        {
            var ls = SerialiseSessions();
            controller.SaveTimesheet(p, ls);
        }

        private void LoadSessions()
        {
            var sl = controller.LoadTimesheet(p);
            if (sl == null)
                return;

            DeserialiseSession(sl);
            controller.UpdateManualColumns(sessions,p);
        }

        private void ClearSessions()
        {
            sessions.Items.Clear();
            sessions.Columns.Clear();
            ListViewExtras.InitColumnHeaders(sessions, typeof(Session));
            sessions.Columns.Insert(3, chargecolumn);
            ListViewExtras.AutoResize(sessions);
            UpdateSessionButtons();
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            var p2 = controller.EditProject(p);

            if (p2 == null)
                return;

            OpenProject(p2);
        }

        private void deletesessionbutton_Click(object sender, EventArgs e)
        {
            if (sessions.SelectedItems.Count != 1)
                return;

            var res = MessageBox.Show("Are you sure?", "question", MessageBoxButtons.YesNo);
            if (res != DialogResult.Yes)
                return;

            sessions.Items.Remove(sessions.SelectedItems[0]);
            SaveSessions();
        }

        private void sessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSessionButtons();
        }

        private void UpdateSessionButtons()
        {
            deletesessionbutton.Enabled =
                editsessionbutton.Enabled =
                sessions.SelectedItems.Count == 1;
        }


        private void editsessionbutton_Click(object sender, EventArgs e)
        {
            controller.EditTimesheet(sessions,sessions.SelectedItems[0]);
            controller.UpdateManualColumns(sessions, p);
            SaveSessions();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }

        private void daysTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextboxExtras.HandleInput(TextboxExtras.InputType.Create(false, true),e.KeyChar,daysTB);
        }

        private void hoursTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextboxExtras.HandleInput(TextboxExtras.InputType.Create(false, true), e.KeyChar, hoursTB);
        }

        private void minutesTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextboxExtras.HandleInput(TextboxExtras.InputType.Create(false, true), e.KeyChar, minutesTB);
        }

        private void secondsTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextboxExtras.HandleInput(TextboxExtras.InputType.Create(false, true), e.KeyChar, secondsTB);
        }
    }
}
