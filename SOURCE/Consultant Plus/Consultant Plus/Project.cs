using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consultant_Plus
{
    public class Project
    {
        public String ProjectName;
        public String DeveloperName;
        public String ClientName;
        public String CurrencyCode;
        private String ProjectPath;

        public void SetProjectPath(string p)
        {
            ProjectPath = p;
        }

        public Project(string projectName, string developerName, string currencyCode, string clientName)
        {
            ProjectName = projectName;
            DeveloperName = developerName;
            CurrencyCode = currencyCode;
            ClientName = clientName;
        }

        public Project()
        {
            
        }
    }
}
