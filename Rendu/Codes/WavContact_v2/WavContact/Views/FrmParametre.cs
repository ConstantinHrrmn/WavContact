﻿using System;
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
    public partial class FrmParametre : Form
    {
        User user = null;
        public FrmParametre(User u)
        {
            InitializeComponent();
            this.user = u;
        }

        private void FrmParametre_Load(object sender, EventArgs e)
        {
            this.SwitchMode();

            this.tbxNom.Text = this.user.Last_name;
            this.tbxPrenom.Text = this.user.First_name;
            this.tbxEmail.Text = this.user.Email;
            this.tbxNumTelephone.Text = this.user.Phone;
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

        #region Buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //this.ctrl.Logout(); //PROBLEME NE RECONNAIT PAS CTRL
            Application.Restart();
        }

        private void btnSwitchMode_Click(object sender, EventArgs e)
        {
            PropertiesManager.ChangeTheme();
            this.SwitchMode();
        }
        #endregion

        /// <summary>
        /// Passage du darkmode au lightmode et vice versa
        /// </summary>
        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
        }
    }
}