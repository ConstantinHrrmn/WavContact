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

namespace WavContact.Views
{
    public partial class FrmProjectWaviewMember : Form
    {
        private ProjectWaviewMemberController ctrl;

        public FrmProjectWaviewMember(Project project)
        {
            InitializeComponent();
            this.ctrl = new ProjectWaviewMemberController(this, project);
        }

        private void FrmProjectWaviewMember_Load(object sender, EventArgs e)
        {
            this.SwitchMode();
        }

        #region MouseMoving
        private MovingForms mf = new MovingForms();
        private void frm_MouseDown(object sender, MouseEventArgs e)
        {
            this.mf.MouseDown(this.Location);
        }

        private void frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mf.CanDrag())
                this.Location = this.mf.MouseMove(sender, e);
        }

        private void frm_MouseUp(object sender, MouseEventArgs e)
        {
            this.mf.MouseUp();
        }
        #endregion

        #region BUTTONS
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenChatWaview_Click(object sender, EventArgs e)
        {

        }
        #endregion

        public void DisplayProjectInformations(Project project)
        {
            this.lblProjectName.Text = project.Name;
        }

        /// <summary>
        /// Change between dark and light mode
        /// </summary>
        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
        }

        
    }
}
