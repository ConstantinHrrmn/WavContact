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
        }

        private void btnOpenChatWaview_Click(object sender, EventArgs e)
        {

        }

        private void gpbProjet_Enter(object sender, EventArgs e)
        {

        }
    }
}