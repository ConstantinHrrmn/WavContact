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
using WavContact.Controllers.Member;
using WavContact.Models;

namespace WavContact.Views.Member
{
    public partial class FrmWaviewGestionStock : Form
    {
        private WavfiewMaterielController ctrl;

        public FrmWaviewGestionStock()
        {
            InitializeComponent();
            this.ctrl = new WavfiewMaterielController(this);
        }

        private void FrmWaviewGestionStock_Load(object sender, EventArgs e)
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
        }

        public void UpdateMateriel(List<Materiel> matos)
        {
            this.lbMateriel.Items.Clear();

            foreach (Materiel item in matos)
                this.lbMateriel.Items.Add(item);
        }

        public void UpdateCatergories(List<CategorieMateriel> cate)
        {
            this.cmbCategorie.Items.Clear();

            foreach (CategorieMateriel item in cate)
                this.cmbCategorie.Items.Add(item);
        }

        public void ShowMateriel(Materiel m)
        {
            this.tbxName.Text = m.Nom;
            this.tbxDescription.Text = m.Description;
            this.tbxPrix.Text = m.Prix.ToString();
            this.tbxQuantite.Text = m.Quantite.ToString();
        }

        private void lbMateriel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tuple<Materiel, CategorieMateriel, int> t = this.ctrl.SelectMateriel(this.lbMateriel.SelectedIndex);

            Materiel m = t.Item1;
            CategorieMateriel cm = t.Item2;
            int index = t.Item3;

            if (m != null)
            {
                this.ShowMateriel(m);
            }
        }
    }
}
