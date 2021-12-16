﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region WAVCONTACT using
using WavContact.Controllers;
using WavContact.Metier;
using WavContact.Models;
using WavContact.Views;
#endregion

namespace WavContact.Views.Member
{
    public partial class FrmWaviewGestionReservation : Form
    {
        private ProjectWaviewMemberController ctrl;

        public FrmWaviewGestionReservation()
        {
            InitializeComponent();
            this.ctrl = new ProjectWaviewMemberController(this, project);
        }

        private void FrmWaviewGestionReservation_Load(object sender, EventArgs e)
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

        #region SWITCHMODE
        /// <summary>
        /// Change between dark and light mode
        /// </summary>
        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
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
            this.gpbProjet.Text = project.Name;
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            FrmWaviewChat frm = new FrmWaviewChat();
            frm.ShowDialog();
        }

        private void btnReserver_Click(object sender, EventArgs e)
        {
            FrmWaviewReservation frm = new FrmWaviewReservation();
            frm.ShowDialog();
        }
    }
}
