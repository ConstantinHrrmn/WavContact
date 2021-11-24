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

namespace WavContact.Views
{
    public partial class FrmProjectWaviewMember : Form
    {
        private ProjectWaviewMemberController ctrl;

        public FrmProjectWaviewMember()
        {
            InitializeComponent();
            this.ctrl = new ProjectWaviewMemberController(this);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SwitchMode()
        {
            Color backcolor = Properties.Settings.Default.darkmode ? Color.Black : Color.White;
            Color invertedColor = Properties.Settings.Default.darkmode ? Color.White : Color.Black;

            this.BackColor = backcolor;

            foreach (Control item in this.Controls)
            {
                item.BackColor = backcolor;
                item.ForeColor = invertedColor;

                if (item.Name == "btnClose")
                {
                    item.ForeColor = Color.Red;
                }

                if (item.Name == "btnSwitchMode")
                {
                    item.Text = Properties.Settings.Default.darkmode ? "Light" : "Dark";
                }
            }
        }
    }
}
