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

namespace WavContact.Views.Client
{
    public partial class FrmClientPagePrincipale : Form
    {
        public FrmClientPagePrincipale(User u)
        {
            InitializeComponent();
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


        /// <summary>
        /// Passage du darkmode au lightmode et vice versa
        /// </summary>
        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
        }

        private void btnSwitchMode_Click(object sender, EventArgs e)
        {
            PropertiesManager.ChangeTheme();
            this.SwitchMode();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClientPagePrincipale_Load(object sender, EventArgs e)
        {
           
        }

        private void btnParametre_Click(object sender, EventArgs e)
        {
            FrmParametre frm = new FrmParametre();
            frm.ShowDialog();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            FrmClientChat frm = new FrmClientChat();
            frm.ShowDialog();
        }

        private void btnProjet_Click(object sender, EventArgs e)
        {
            //FrmProjet frm = new FrmProjet();
            //frm.ShowDialog();
        }
    }
}
