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
using System.Diagnostics;

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

            if(matos != null)
            {
                foreach (Materiel item in matos)
                    this.lbMateriel.Items.Add(item);
            }
            
        }

        public void UpdateCatergories(List<CategorieMateriel> cate)
        {
            this.cmbCategorie.Items.Clear();
            this.cmbFiltre.Items.Clear();

            if(cate != null)
            {
                this.cmbFiltre.Items.Add(new CategorieMateriel(0, "Tout"));
                foreach (CategorieMateriel item in cate)
                {
                    this.cmbCategorie.Items.Add(item);
                    this.cmbFiltre.Items.Add(item);
                }
                    
            } 
        }

        public void ShowMateriel(Materiel m, int indexCate)
        {
            this.tbxName.Text = m.Nom;
            this.tbxDescription.Text = m.Description;
            this.tbxPrix.Text = m.Prix.ToString();
            this.tbxQuantite.Text = m.Quantite.ToString();

            this.cmbCategorie.SelectedIndex = indexCate;

        }

        private void lbMateriel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Tuple<Materiel, CategorieMateriel, int> t = this.ctrl.SelectMateriel(this.lbMateriel.SelectedIndex);
            Tuple<Materiel, CategorieMateriel, int> t = this.ctrl.SelectMateriel(this.lbMateriel.SelectedItem as Materiel);

            Materiel m = t.Item1;
            CategorieMateriel cm = t.Item2;
            int index = t.Item3;

            Debug.WriteLine(t);

            if (m != null)
            {
                this.ShowMateriel(m, index);
            }
        }

        private void cmbFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ctrl.Filtrer(this.cmbFiltre.SelectedIndex);
        }

        private void lbMateriel_SelectedValueChanged(object sender, EventArgs e)
        {
        }
    }
}
