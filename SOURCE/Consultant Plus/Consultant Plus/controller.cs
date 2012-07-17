using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ANDREICSLIB;

namespace Consultant_Plus
{
    public static class controller
    {
        private static string  GetInfoFilePath (string basepath)
        {
            return basepath + "/INFO.txt";
        }

        private static string GetTimesheetPath(String basepath)
        {
            return basepath + "/TIMESHEETS.txt";
        }

        private static Project p;

        public static Tuple<String,Project> CreateProject(string basedirectory,Project p)
        {
            String dir = basedirectory + "\\" + p.ProjectName;

            if (Directory.Exists(dir))
            {
                return new Tuple<string, Project>("A project already exists with that name", null);
            }

            CreateProjectShell(dir);
            SaveProject(p,dir);


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

        public static void SaveProject(Project p, string projectpath)
        {
            Reflection.SerialiseObject(p, GetInfoFilePath(projectpath));
        }

        public static Project LoadProject(string projectpath)
        {
            var p=(Project)Reflection.DeserialiseFile(typeof(Project), GetInfoFilePath(projectpath));
            if (p==null)
                return null;
            p.SetProjectPath(projectpath);
            return p;
        }

        
    }
}
