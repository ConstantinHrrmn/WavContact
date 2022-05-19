using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WavContact.Controllers;
using WavContact.Controllers.Clients;
using WavContact.DB;
using WavContact.Metier;
using WavContact.Models;

namespace WavContact.Views.Client
{
    public partial class FrmClientPagePrincipale : Form
    {
        private ClientPagePrincipaleControlleur ctrl;
        List<ListBox> boxes = new List<ListBox>();
        List<Label> labels = new List<Label>();

        private int weekMultiplier = 0;        
        
        public FrmClientPagePrincipale(User u)
        {
            InitializeComponent();
            this.ctrl = new ClientPagePrincipaleControlleur(this, u);
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

        public void UpdateForm()
        {
            this.lblMenuPrincipal.Text = "Bonjour " + this.ctrl.ConnectedUser.First_name + " !";
        }

        private void btnSwitchMode_Click(object sender, EventArgs e)
        {
            PropertiesManager.ChangeTheme();
            this.SwitchMode();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClientPagePrincipale_Load(object sender, EventArgs e)
        {
            this.SwitchMode();
            this.UpdateForm();
            this.ctrl.UpdateProjects();

            this.boxes.Add(this.lbDay1);
            this.boxes.Add(this.lbDay2);
            this.boxes.Add(this.lbDay3);
            this.boxes.Add(this.lbDay4);
            this.boxes.Add(this.lbDay5);
            this.boxes.Add(this.lbDay6);
            this.boxes.Add(this.lbDay7);

            this.labels.Add(this.lblDay1);
            this.labels.Add(this.lblDay2);
            this.labels.Add(this.lblDay3);
            this.labels.Add(this.lblDay4);
            this.labels.Add(this.lblDay5);
            this.labels.Add(this.lblDay6);
            this.labels.Add(this.lblDay7);


            this.ctrl.UpdateCalendar();
        }

        public void UpdateChatCount(int amount)
        {
            try
            {
                this.btnChat.Invoke(() => this.btnChat.Text = "Chat (" + amount + ")");
            }
            catch (Exception)
            {
            }

        }

        public void UpdateCalendar(DateTime startingDate, Calendat[][] calendar)
        {

            for (int i = 0; i < calendar.Length; i++)
            {
                this.boxes[i].Invoke(() => this.boxes[i].Items.Clear());
                DateTime date = startingDate.AddDays(i);

                this.labels[i].Invoke(() => this.labels[i].Text = this.FormatDate(date));
                for (int x = 0; x < calendar[i].Length; x++)
                {
                    this.boxes[i].Invoke(() => this.boxes[i].Items.Add(calendar[i][x].ToString(date)));
                }
            }
        }

        public string FormatDate(DateTime date)
        {
            return date.ToString("dd.MM") + " (" + this.GetDayNameFrench(date.ToString("dddd")) + ")";
        }

        public string GetDayNameFrench(string english)
        {
            switch (english)
            {
                case "Monday":
                    return "Lundi";
                case "Tuesday":
                    return "Mardi";
                case "Wednesday":
                    return "Mercredi";
                case "Thursday":
                    return "Jeudi";
                case "Friday":
                    return "Vendredi";
                case "Saturday":
                    return "Samedi";
                case "Sunday":
                    return "Dimanche";
                default:
                    return "";
            }
        }
        
        public void UpdateProjectList(List<Project> projets)
        {
            this.lstProjet.Items.Clear();

            if (projets != null)
            {
                foreach (Project item in projets)
                {
                    this.lstProjet.Items.Add(item);
                }
            }
        }

        private void btnParametre_Click(object sender, EventArgs e)
        {
            FrmParametre frm = new FrmParametre(this.ctrl.ConnectedUser);
            frm.ShowDialog();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            FrmClientChat frm = new FrmClientChat(this.ctrl.ConnectedUser);
            frm.ShowDialog();
        }

        private void btnProjet_Click(object sender, EventArgs e)
        {
            //FrmProjet frm = new FrmProjet();
            //frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.ctrl.Logout();
            Application.Restart();
        }

        private void lstProjet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstProjet.SelectedItem != null)
            {
                this.ctrl.LoadProjectPage(this.lstProjet.SelectedItem as Project);
            }
        }

        private void TimerCheckNewMessages_Tick(object sender, EventArgs e)
        {
            this.ctrl.UpdateChatCount();
        }

        private void CalendarTimer_Tick(object sender, EventArgs e)
        {
            if (this.weekMultiplier != 0)
            {
                this.ctrl.UpdateCalendar(DateTime.Now.AddDays(this.weekMultiplier * 7));
            }
            else
            {
                this.ctrl.UpdateCalendar();
            }
        }

        private void btnPreviusWeek_Click(object sender, EventArgs e)
        {
            this.weekMultiplier--;
            this.ctrl.UpdateCalendar(DateTime.Now.AddDays(this.weekMultiplier * 7));
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            this.ctrl.UpdateCalendar();
            this.weekMultiplier = 0;
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            this.weekMultiplier++;
            this.ctrl.UpdateCalendar(DateTime.Now.AddDays(this.weekMultiplier * 7));
        }
    }
}
