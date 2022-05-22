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

namespace WavContact.Views
{
    public partial class FrmReviewClients : Form
    {
        private WaviewReviewController ctrl;
        
        public FrmReviewClients()
        {
            InitializeComponent();
            this.ctrl = new WaviewReviewController(this);
        }

        private void FrmReviewClients_Load(object sender, EventArgs e)
        {
            this.SwitchMode();
            this.ctrl.LoadData();
        }

        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
        }

        private void lstListeClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.t_update.Stop();
            
            DialogResult result = MessageBox.Show("Voulez-vous ajouter ce client ?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                this.ctrl.ActivateUser(this.lstListeClients.SelectedItem as User);
            }
            else if (result == DialogResult.No)
            {
                this.ctrl.DeleteUser(this.lstListeClients.SelectedItem as User);
            }

            this.t_update.Start();
        }

        public void UpdateData(List<User> clients)
        {
            this.lstListeClients.Invoke(() => this.lstListeClients.Items.Clear());

            if (clients == null)
            {
                MessageBox.Show("Tous les clients ont été activés");
            }
            else
            {
                foreach (User item in clients)
                {
                    this.lstListeClients.Invoke(() => this.lstListeClients.Items.Add(item));
                }
            }
            
        }

        private void t_update_Tick(object sender, EventArgs e)
        {
            try
            {
                this.ctrl.LoadData();
            }
            catch (Exception)
            {
            }
        }
    }
}
