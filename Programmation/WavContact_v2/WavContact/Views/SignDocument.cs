using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WavContact.Metier;

namespace WavContact.Views
{
    public partial class SignDocument : Form
    {
        public string certificatePath;
        public string certificatePassword;
        
        public SignDocument()
        {
            InitializeComponent();
        }

        private void SignDocument_Load(object sender, EventArgs e)
        {
            this.SwitchMode();
            this.btnSign.Enabled = false;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if(ofdFile.ShowDialog() == DialogResult.OK)
            {
                Debug.WriteLine(ofdFile.FileName);
                this.lblPath.Text = ofdFile.FileName;
                this.certificatePath = ofdFile.FileName;
                this.btnSign.Enabled = true;
            }
        }

        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            this.certificatePassword = tbxPassword.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
