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

            dtpDebut.Value = DateTime.Now.AddMinutes(10);
            dtpFin.Value = DateTime.Now.AddHours(2);


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
            CheckStartDate();
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            CheckEndDate();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CheckStartDate();
            CheckEndDate();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void CheckStartDate()
        {
            this.Debut = this.dtpDebut.Value;

            if (this.Debut < DateTime.Now)
            {
                MessageBox.Show("La date de début ne peut pas être antérieure à la date du jour");
                this.dtpDebut.Value = DateTime.Now.AddMinutes(1);
                this.Debut = this.dtpDebut.Value;
            }
        }

        public void CheckEndDate()
        {
            this.Fin = this.dtpFin.Value;

            if (this.Fin < this.Debut)
            {
                MessageBox.Show("La date de fin doit être supérieure à la date de début");
                this.dtpFin.Value = this.dtpDebut.Value.AddMinutes(1);
                this.Fin = this.dtpFin.Value;
            }
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
