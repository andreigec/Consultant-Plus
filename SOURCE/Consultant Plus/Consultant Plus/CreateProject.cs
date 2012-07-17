using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Consultant_Plus
{
    public partial class CreateProject : Form
    {
        private Project p;

        public CreateProject()
        {
            InitializeComponent();
            projectname.Focus();
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            p = new Project(projectname.Text, devteamname.Text, currencycode.Text, clientname.Text);

            if (projectname.Text.Length==0)
            {
                MessageBox.Show("The project name must be at least one character");
                return;
            }

            Close();
        }

        public static Project ShowDialogCreate()
        {
            var cp = new CreateProject();
            cp.Text = "Create Project";
            
            cp.ShowDialog();
            return cp.p;
        }

        public static Project ShowDialogEdit(Project p)
        {
            var cp = new CreateProject();
            cp.Text = "Edit Project";
            cp.projectname.Text = p.ProjectName;
            cp.devteamname.Text = p.DeveloperName;
            cp.currencycode.Text = p.CurrencyCode;
            cp.clientname.Text = p.ClientName;

            cp.ShowDialog();
            return cp.p;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
