using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WavContact.Controllers;
using WavContact.Metier;
using WavContact.Models;

namespace WavContact.Views.Member
{
    public partial class FrmWaviewProject : Form
    {
        private ProjectWaviewMemberController ctrl;

        public FrmWaviewProject(Project p)
        {
            InitializeComponent();
            this.ctrl = new ProjectWaviewMemberController(this, p);
        }

        private void FrmWaviewProject_Load(object sender, EventArgs e)
        {
            this.SwitchMode();
        }

        /// <summary>
        /// Passage du darkmode au lightmode et vice versa
        /// </summary>
        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);

            Color backcolor = Properties.Settings.Default.darkmode ? Color.Black : Color.White;
            Color invertedColor = Properties.Settings.Default.darkmode ? Color.White : Color.Black;

            tbxDescription.BackColor = backcolor;
            tbxDescription.ForeColor = invertedColor;

            lstLieux.BackColor = backcolor;
            lstLieux.ForeColor = invertedColor;

            lstDateTournages.BackColor = backcolor;
            lstDateTournages.ForeColor = invertedColor;
        }

        public void ShowData(Project p)
        {
            this.lblProjectName.Text = p.Name;
            this.tbxDescription.Text = p.Description;
        }

        private void btnOpenChatWaview_Click(object sender, EventArgs e)
        {

        }

        private void gpbProjet_Enter(object sender, EventArgs e)
        {

        }
    }
}
