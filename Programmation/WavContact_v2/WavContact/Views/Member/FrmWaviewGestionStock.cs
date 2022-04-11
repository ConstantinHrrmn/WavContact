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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Empty all fields
            this.tbxName.Text = "";
            this.tbxDescription.Text = "";
            this.tbxPrix.Text = "";
            this.tbxQuantite.Text = "";
            this.cmbCategorie.SelectedIndex = 0;
            this.btnSaveNew.Visible = true;

            // Make all fileds editable
            this.tbxName.ReadOnly = false;
            this.tbxDescription.ReadOnly = false;
            this.tbxPrix.ReadOnly = false;
            this.tbxQuantite.ReadOnly = false;
            this.cmbCategorie.Enabled = true;
            
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            // If all fields are filled
            if (this.tbxName.Text != "" && this.tbxDescription.Text != "" && this.tbxPrix.Text != "" && this.tbxQuantite.Text != "")
            {
                double q = 0;
                if (double.TryParse(this.tbxQuantite.Text, out q))
                {
                    if (q > 0)
                    {
                        CategorieMateriel categorieMateriel = this.cmbCategorie.SelectedItem as CategorieMateriel;
                        Materiel m = new Materiel(-1, categorieMateriel.Id, this.tbxName.Text, this.tbxDescription.Text, Convert.ToDouble(this.tbxPrix.Text), Convert.ToInt32(this.tbxQuantite.Text));

                        // Save materiel in database
                        WavContact.DB.WavContactPDO.CreateMaterial(m);

                        //Update Materiel list
                        this.ctrl.UpdateMateriel();

                        MessageBox.Show("Le matériel a été ajouté avec succès", "Ajout matériel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La quantité doit être supérieur à 0");
                    }
                }
                else
                {
                    MessageBox.Show("La quantité doit être un nombre");
                }
                
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
