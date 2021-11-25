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

namespace WavContact.Views.Member
{
    public partial class FrmWaviewChat : Form
    {
        public FrmWaviewChat()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadClientsList(List<User> clients)
        {
            this.lbClients.Items.Clear();
            foreach (User item in clients)
            {
                this.lbClients.Items.Add(item);
            }
        }

        #region MouseMoving
        private MovingForms mf = new MovingForms();
        private void frm_MouseDown(object sender, MouseEventArgs e)
        {
            this.mf.MouseDown(this.Location);
        }

        private void frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mf.CanDrag())
                this.Location = this.mf.MouseMove(sender, e);
        }

        private void frm_MouseUp(object sender, MouseEventArgs e)
        {
            this.mf.MouseUp();
        }
        #endregion

        /// <summary>
        /// Passage du darkmode au lightmode et vice versa
        /// </summary>
        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
        }

        private void FrmWaviewChat_Load(object sender, EventArgs e)
        {
            this.SwitchMode();
        }

        private void tbxMessage_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(tbxMessage.Text, tbxMessage.Font);
            //tbxMessage.Height = size.Height;
        }
    }
}
