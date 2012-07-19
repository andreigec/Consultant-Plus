using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ANDREICSLIB;
using ANDREICSLIB.NewControls;

namespace Consultant_Plus
{
    public static class controller
    {
        private static string GetInfoFilePath(string basepath)
        {
            return basepath + "/INFO.txt";
        }

        private static string GetTimesheetPath(String basepath)
        {
            return basepath + "/TIMESHEETS.txt";
        }

        public static Tuple<string, Project> CreateProject(string basedirectory, Project p)
        {
            String dir = basedirectory + "\\" + p.ProjectName;
            p.SetProjectPath(dir);

            if (Directory.Exists(dir))
            {
                return new Tuple<string, Project>("A project already exists with that name", null);
            }

            CreateProjectShell(dir);
            SaveProject(p);

            return new Tuple<string, Project>(null, p);
        }

        private static void CreateProjectShell(string projectpath)
        {
            //base directory
            Directory.CreateDirectory(projectpath);

            //project info file
            FileUpdates.CreateFile(GetInfoFilePath(projectpath));

            //timesheets file
            FileUpdates.CreateFile(GetTimesheetPath(projectpath));
        }

        public static bool SaveProject(Project p)
        {
            return Reflection.SerialiseObject(p, GetInfoFilePath(p.GetProjectPath()));
        }

        public static Project LoadProject(string projectpath)
        {
            var p = (Project)Reflection.DeserialiseObject(GetInfoFilePath(projectpath), typeof(Project));
            if (p == null)
                return null;
            p.SetProjectPath(projectpath);
            return p;
        }

        public static void SaveTimesheet(Project p, List<Session> sessions)
        {
            var tp = GetTimesheetPath(p.GetProjectPath());
            if (File.Exists(tp))
            {
                File.Delete(tp);
            }

            String ts = "";
            foreach (var s in sessions)
            {
                ts += Reflection.SerialiseObject(s) + "\b";
            }

            FileUpdates.SaveToFile(tp, ts);
        }

        public static List<Session> LoadTimesheet(Project p)
        {
            var file = FileUpdates.LoadFile(GetTimesheetPath(p.GetProjectPath()));
            if (String.IsNullOrEmpty(file))
                return null;

            var sessions = StringUpdates.SplitString(file, "\b");
            var ret = new List<Session>();
            foreach (var s in sessions)
            {
                ret.Add((Session)Reflection.DeserialiseObject(typeof(Session), s));
            }
            return ret;
        }

        private static Project ShowProjectDialog(Project ptemp = null)
        {
            var overloads = new List<MassVariableEdit.TextBoxItems>();
            bool create = ptemp == null;

            //var ptemp = new Project();
            if (ptemp == null)
                ptemp = new Project();

            MassVariableEdit.AcceptFinalTextBoxText a = (x) => x.Length > 0;
            var fn = Reflection.GetFieldName(() => ptemp.ProjectName);
            var fv = ptemp.ProjectName;

            overloads.Add(MassVariableEdit.TextBoxItems.Create(fn, fv, null, a, "Project Name must be at least one character"));

            var res = MassVariableEdit.ShowDialogStatic(create ? "Create Project" : "Edit Project", ptemp, overloads);
            if (res == null)
                return null;

            var p = Reflection.DeserialiseObject(typeof(Project), res);
            return (Project)p;
        }

        private static Session ShowTimesheetDialog(Session s = null)
        {
            bool create = s == null;

            if (s == null)
                s = new Session();

            if (string.IsNullOrEmpty(s.Date))
                s.Date = DateTime.Now.ToShortDateString();

            var overloads = new List<MassVariableEdit.TextBoxItems>();
            var fn = Reflection.GetFieldName(() => s.Hours);
            var fv = s.Hours.ToString();
            overloads.Add(MassVariableEdit.TextBoxItems.Create(fn, fv,TextboxUpdates.HandleInputAsFloat));

            fn = Reflection.GetFieldName(() => s.HourlyRate);
            fv = s.HourlyRate.ToString();
            overloads.Add(MassVariableEdit.TextBoxItems.Create(fn, fv, TextboxUpdates.HandleInputAsFloat));

            var res = MassVariableEdit.ShowDialogStatic(create ? "Create Session" : "Edit Session", s,overloads);
            if (res == null)
                return null;

            var sc = Reflection.DeserialiseObject(typeof(Session), res);
            return (Session)sc;
        }

        public static void ManualAddTimesheet(ListView lv)
        {
            var s = ShowTimesheetDialog();
            if (s == null)
                return;

            ListViewUpdate.CopyClassToListView(lv, s);
        }

        public static void EditTimesheet(ListView lv, ListViewItem lvi)
        {
            //get the existing session
            var s = (Session)ListViewUpdate.GetObjectFromListViewItem(lv, lvi, typeof(Session));

            //show the edit dialog
            var news = ShowTimesheetDialog(s);

            if (news == null)
                return;

            //move the changed session back to the LV
            ListViewUpdate.CopyClassToListView(lv, news, lvi);
        }

        public static void UpdateManualColumns(ListView lv, Project p)
        {
            var tests = new Session();
            var totalhoursname = Reflection.GetFieldName(() => tests.Hours);
            var hourcolname = Reflection.GetFieldName(() => tests.HourlyRate);
            foreach (ListViewItem lvi in lv.Items)
            {
                var totalhours = Double.Parse(ListViewUpdate.GetColumn(lv, lvi, totalhoursname));
                var hourlyrate = Double.Parse(ListViewUpdate.GetColumn(lv, lvi, hourcolname));
                //manual change columns
                var chg = MathUpdates.Truncate(totalhours * hourlyrate).ToString() + " " + p.CurrencyCode;
                ListViewUpdate.SetColumn(lv, lvi, Form1.chargecolumn, chg);
            }
            ListViewUpdate.AutoResize(lv);
        }

        public static Project CreateProject(string basedir)
        {
            var p = ShowProjectDialog();
            if (p == null)
            {
                return null;
            }

            var res = CreateProject(basedir, p);

            if (res.Item2 == null)
            {
                MessageBox.Show("An error occured when creating the project:\n" + res.Item1);
                return null;
            }

            return res.Item2;
        }

        public static Project EditProject(Project p)
        {
            var p2 = ShowProjectDialog(p);
            if (p2 == null)
            {
                return null;
            }

            p2.SetProjectPath(p.GetProjectPath());
            bool r = SaveProject(p2);
            if (r == false)
            {
                MessageBox.Show("There was an error saving the project, changes will not be made");
                return null;
            }
            return p2;
        }
    }
}
