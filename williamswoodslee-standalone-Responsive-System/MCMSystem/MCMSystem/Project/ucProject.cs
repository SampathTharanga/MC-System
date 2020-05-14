using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMSystem.Project
{
    public partial class ucProject : UserControl
    {
        private static ucProject newInstance;
        private CommonController ccNew;

        public static ucProject newProject
        {
            get
            {
                newInstance = null;
                if (newInstance == null)
                {
                    newInstance = new ucProject();
                }
                return newInstance;
            }
        }
        public ucProject()
        {
            InitializeComponent();
            this.ccNew = CommonController.Instance;
        }

        private void btnAddNewProject_Click(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnAddNewProject, btnViewProject);
            ccNew.changePanelView(pnlProject, ucProjectReg.newProjectReg);
        }

        private void btnViewProject_Click(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnViewProject, btnAddNewProject);
            ccNew.changePanelView(pnlProject, ucProjectView.newProjectView);
        }

        private void ucProject_Load(object sender, EventArgs e)
        {
            ccNew.changeButtonColor(btnAddNewProject, btnViewProject);
            ccNew.changePanelView(pnlProject, ucProjectReg.newProjectReg);
        }
    }
}
