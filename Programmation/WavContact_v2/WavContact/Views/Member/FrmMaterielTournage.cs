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

                this.cmbFiltreDisponible.SelectedIndex = 0;
                this.cmbFiltreSelect.SelectedIndex = 0;
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
            }
            else
            {
                this.gbSelectionMateriel.Enabled = false;
            }
        }
    }
}
