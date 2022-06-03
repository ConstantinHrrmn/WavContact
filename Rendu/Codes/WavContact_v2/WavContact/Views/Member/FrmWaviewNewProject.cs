using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WavContact.Metier;
using WavContact.Models;

namespace WavContact.Views.Member
{
    public partial class FrmWaviewNewProject : Form
    {
        private Project _nouveauProjet;

        public Project NouveauProjet { get => _nouveauProjet; set => _nouveauProjet = value; }

        public FrmWaviewNewProject()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Passage du darkmode au lightmode et vice versa
        /// </summary>
        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
        }

        private void FrmWaviewNewProject_Load(object sender, EventArgs e)
        {
            this.SwitchMode();
        }

        private void lblNomMandant_Click(object sender, EventArgs e)
        {

        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            if (this.tbxNom.Text.Trim().Length > 0)
            {
                this.NouveauProjet = new Project(-1, this.tbxNom.Text.Trim(), this.tbxDescription.Text.Trim(), 0, "");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
