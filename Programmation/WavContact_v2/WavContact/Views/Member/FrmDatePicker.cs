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

namespace WavContact.Views.Member
{
    public partial class FrmDatePicker : Form
    {
        private DateTime _debut;
        private DateTime _fin;

        public FrmDatePicker()
        {
            InitializeComponent();
            this.Debut = dtpDebut.Value;
            this.Fin = dtpFin.Value;
        }

        public FrmDatePicker(DateTime debut, DateTime fin)
        {
            InitializeComponent();
            this.Debut = debut;
            this.Fin = fin;

            this.dtpDebut.Value = debut;
            this.dtpFin.Value = fin;
        }

        public DateTime Debut { get => _debut; set => _debut = value; }
        public DateTime Fin { get => _fin; set => _fin = value; }

        private void dtpDebut_ValueChanged(object sender, EventArgs e)
        {
            this.Debut = this.dtpDebut.Value;
            /*
            if (this.Debut < DateTime.Now)
            {
                this.Debut = DateTime.Now;
                
                MessageBox.Show("La date de début ne peut pas être antérieure à la date du jour");

                this.dtpDebut.Value = this.Debut + TimeSpan.FromDays(1);
            }*/
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            this.Fin = this.dtpFin.Value;
            /*
            if (this.Fin < this.Debut)
            {
                this.Fin = this.Debut;
                
                MessageBox.Show("La date de fin doit être supérieure à la date de début");

                this.dtpFin.Value = this.Fin;
            }*/
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmDatePicker_Load(object sender, EventArgs e)
        {
            this.SwitchMode();
        }

        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
        }
    }
}
