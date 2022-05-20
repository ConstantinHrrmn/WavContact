using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WavContact.Controllers.Member;
using WavContact.Metier;
using WavContact.Models;

namespace WavContact.Views.Member
{
    public partial class FrmMaterielTournage : Form
    {
        private WaviewMaterielTournageController _ctrl;

        public WaviewMaterielTournageController Ctrl { get => _ctrl; set => _ctrl = value; }

        public FrmMaterielTournage(Project p)
        {
            InitializeComponent();
            this.Ctrl = new WaviewMaterielTournageController(this, p);
        }

        private void FrmMaterielTournage_Load(object sender, EventArgs e)
        {
            this.SwitchMode();

            this.Ctrl.UpdateTournages();
            this.Ctrl.UpdateCategories();

            this.gbQuantite.Enabled = false;
        }

        /// <summary>
        /// Passage du darkmode au lightmode et vice versa
        /// </summary>
        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
        }

        public void UpdateCatergories(List<CategorieMateriel> cate)
        {
            this.cmbFiltreDisponible.Items.Clear();
            this.cmbFiltreSelect.Items.Clear();

            if (cate != null)
            {
                this.cmbFiltreDisponible.Items.Add(new CategorieMateriel(0, "Tout"));
                this.cmbFiltreSelect.Items.Add(new CategorieMateriel(0, "Tout"));
                
                foreach (CategorieMateriel item in cate)
                {
                    this.cmbFiltreDisponible.Items.Add(item);
                    this.cmbFiltreSelect.Items.Add(item);
                }

                //this.cmbFiltreDisponible.SelectedIndex = 0;
                //this.cmbFiltreSelect.SelectedIndex = 0;
            }
        }

        public void UpdateTournageDates(List<Tournage> tournages)
        {
            this.cmbDate.Items.Clear();
            if (tournages != null)
            {
                foreach (Tournage item in tournages)
                {
                    this.cmbDate.Items.Add(item);
                }

                this.cmbDate.SelectedIndex = 0;
            }
        }

        private void cmbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbDate.SelectedIndex != -1)
            {
                this.gbSelectionMateriel.Enabled = true;
                this.Ctrl.Update(this.cmbDate.SelectedItem as Tournage);
                this.btnPrint.Enabled = true;
            }
            else
            {
                this.gbSelectionMateriel.Enabled = false;
                this.btnPrint.Enabled = false;
            }
        }

        public void UpdateMaterielPris(List<Materiel> materiels)
        {
            this.lbSelect.Invoke(() => this.lbSelect.Items.Clear());

            foreach (Materiel item in materiels)
            {
                this.lbSelect.Invoke(() => this.lbSelect.Items.Add(item));
            }
        }

        public void UpdateMaterielDispo(List<Materiel> materiels)
        {
            this.lbDisponible.Invoke(() => this.lbDisponible.Items.Clear());

            foreach (Materiel item in materiels)
            {
                this.lbDisponible.Invoke(() => this.lbDisponible.Items.Add(item));
            }
        }

        private void lbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gbQuantite.Enabled = true;
            this.btnAction.Text = "Modifer";
            this.btnRemove.Visible = true;

            Materiel m = this.lbSelect.SelectedItem as Materiel;

            this.UpdateAvaibleAmount(m.Quantite, this.Ctrl.AvaibleCount(m));
        }

        private void lbDisponible_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gbQuantite.Enabled = true;
            this.btnAction.Text = "Ajouter";
            this.btnRemove.Visible = false;

            Materiel m = this.lbDisponible.SelectedItem as Materiel;

            this.UpdateAvaibleAmount(0, m.Quantite);
        }

        public void UpdateAvaibleAmount(int toSelect, int amount)
        {
            this.lblQuantiteDisponible.Text = "/ " + amount;

            this.cbAmount.Items.Clear();
            for (int i = 0; i < amount + 1; i++)
            {
                this.cbAmount.Items.Add(i);
            }

            if (toSelect <= amount && toSelect > 0)
            {
                this.cbAmount.SelectedIndex = toSelect;
            }
            else
            {
                this.cbAmount.SelectedIndex = 0;
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Materiel m = this.lbSelect.SelectedItem as Materiel;
            this.Ctrl.DeleteReservation(m);
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (this.cbAmount.SelectedIndex > 0)
            {
                if (this.btnAction.Text == "Ajouter")
                {
                    Materiel m = this.lbDisponible.SelectedItem as Materiel;

                    if (this.Ctrl.IsAllReadyTaken(m))
                    {
                        this.Ctrl.UpdateTakenReservation(m, this.cbAmount.SelectedIndex);
                    }
                    else
                    {
                        this.Ctrl.NewReservation(m, this.cbAmount.SelectedIndex);
                    }
                }
                else
                {
                    Materiel m = this.lbSelect.SelectedItem as Materiel;
                    if (this.Ctrl.IsAllReadyTaken(m))
                    {
                        this.Ctrl.UpdateTakenReservation(m, this.cbAmount.SelectedIndex);
                    }
                    else
                    {
                        this.Ctrl.UpdateReservation(m, this.cbAmount.SelectedIndex);
                    }
                    
                    
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer une valeur supérieur à 0.");
            }
            

            
        }

        private void cmbFiltreDisponible_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Ctrl.FiltrerAvaible(this.cmbFiltreDisponible.SelectedIndex);
        }

        private void cmbFiltreSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Ctrl.FiltrerSelected(this.cmbFiltreSelect.SelectedIndex);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            WavPDFWriter.WritePDF(this.Ctrl.Projet, this.Ctrl.SelectedDate, this.Ctrl.MaterielsTournage, this.Ctrl.Categories);
        }
    }
}
