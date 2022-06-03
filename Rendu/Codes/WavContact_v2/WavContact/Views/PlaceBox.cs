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

namespace WavContact.Views
{
    public partial class PlaceBox : Form
    {
        private Lieu _lieu;

        public Lieu SelectedLieu { get => _lieu; set => _lieu = value; }

        public PlaceBox(Lieu l)
        {
            InitializeComponent();

            this.SelectedLieu = l;
            
        }

        private void LoadData()
        {
            this.lblName.Text = SelectedLieu.Nom;
            this.lblLat.Text = "Latitude : " + SelectedLieu.Lat.ToString();
            this.lblLon.Text = "Longitude : " + SelectedLieu.Lon.ToString();
            this.tbxDescription.Text = SelectedLieu.Description;
            if (SelectedLieu.PathImage != null)
            {
                string url = "https://waview.ch/wavcontact/map/imagelieu/" + SelectedLieu.PathImage;
                this.pbPhoto.Load(url);
            }
            else
            {
                this.pbPhoto.Image = Properties.Resources.no_image;
            }
            
        }

        private void PlaceBox_Load(object sender, EventArgs e)
        {
            this.SwitchMode();
            this.LoadData();
        }

        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
