﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WavContact.Controllers;
using WavContact.Controllers.Member;
using WavContact.DB;
using WavContact.Metier;
using WavContact.Models;
using Activity = WavContact.DB.Activity;

namespace WavContact.Views.Member
{
    public partial class FrmWaviewPagePrincipale1080 : Form
    {
        #region Variables privées
        private WaviewMemberController1080 ctrl;

        List<ListBox> boxes = new List<ListBox>();
        List<Label> labels = new List<Label>();

        private int weekMultiplier = 0;
        #endregion

        /// <summary>
        /// Constructeur par défaut de la form de gestion d'un membre de waview
        /// </summary>
        /// <param name="u">Le membre de waview connecté</param>
        public FrmWaviewPagePrincipale1080(User u)
        {
            InitializeComponent();
            // Initialisation du controlleur
            this.ctrl = new WaviewMemberController1080(this, u);

        }
        
        public FrmWaviewPagePrincipale1080()
        {
            InitializeComponent();
        }

        private void FrmWaviewPagePrincipale1080_Load(object sender, EventArgs e)
        {
            // Affichage du nom de la personne dans la ligne en haut
            this.lblWelcome.Text = string.Format("Hello {0} !", this.ctrl.ConnectedUser);
            // On met a jour le theme de la page en fonction de l'enregistrement de l'utilisateur
            this.SwitchMode();

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


        #region Buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.ctrl.Logout();
            Application.Restart();
        }

        private void btnSwitchMode_Click(object sender, EventArgs e)
        {
            PropertiesManager.ChangeTheme();
            this.SwitchMode();
        }
        #endregion

        #region SelectedIndexChange
        private void lbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstListeClients.SelectedItem != null)
            {
                this.LoadProjectsForClient(this.ctrl.GetProjectsForUser(this.lstListeClients.SelectedItem as User));
                this.btnNewProject.Enabled = true;
                this.btnInfosClients.Enabled = true;
            }
            else
            {
                this.btnNewProject.Enabled = false;
                this.btnInfosClients.Enabled = false;
            }

        }

        private void lbProjets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstListeProjets.SelectedItem != null)
            {
                this.ctrl.LoadProjectPage(this.lstListeProjets.SelectedItem as Project);
            }

        }
        #endregion

        /// <summary>
        /// Passage du darkmode au lightmode et vice versa
        /// </summary>
        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
        }

        /// <summary>
        /// Charger la liste des clients dans la liste de la vue
        /// </summary>
        /// <param name="clients">La liste de clients (user) à afficher dans la vue</param>
        public void LoadClients(List<User> clients)
        {
            this.lstListeClients.Items.Clear();

            if (clients != null)
            {
                foreach (User item in clients)
                {
                    this.lstListeClients.Items.Add(item);
                }
            }

        }

        public void UpdateActivityMonitor(List<Activity> activites)
        {
            try
            {
                this.lbActivity.Invoke(() => this.lbActivity.Items.Clear());
                if (activites != null)
                {
                    foreach (Activity a in activites)
                    {
                        this.lbActivity.Invoke(() => this.lbActivity.Items.Add(a.MainActivity()));
                    }
                }
            }
            catch (Exception)
            {

            }

        }

        /// <summary>
        /// Charger les projets du clients dans la vue
        /// </summary>
        /// <param name="projects">Les projets a afficher</param>
        public void LoadProjectsForClient(List<Project> projects)
        {
            this.lstListeProjets.Items.Clear();

            foreach (Project item in projects)
            {
                this.lstListeProjets.Items.Add(item);
            }
        }

        private void btnChats_Click(object sender, EventArgs e)
        {
            FrmWaviewChat chat = new FrmWaviewChat(this.ctrl.ConnectedUser);
            chat.Show();
        }

        private void btnInfosClients_Click(object sender, EventArgs e)
        {
            FrmWaviewPageClient frmC = new FrmWaviewPageClient(this.lstListeClients.SelectedItem as User);
            DialogResult dr = frmC.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Debug.WriteLine(frmC.Client);
                this.ctrl.UpdateClient(frmC.Client);
            }
        }

        private void btnGestionMateriel_Click(object sender, EventArgs e)
        {
            FrmWaviewGestionStock frmG = new FrmWaviewGestionStock();
            frmG.Show();
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            FrmWaviewPageClient frmC = new FrmWaviewPageClient();
            DialogResult dr = frmC.ShowDialog();

            if (dr == DialogResult.OK)
            {
                WavContactPDO.CreateClient(frmC.Client);

                this.ctrl.UpdateClients();
                Debug.WriteLine(frmC.Client);
            }

        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            FrmWaviewNewProject frm = new FrmWaviewNewProject();
            DialogResult dr = frm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Debug.WriteLine(frm.NouveauProjet);
                WavContactPDO.CreateProject(frm.NouveauProjet, this.lstListeClients.SelectedItem as User);
                this.LoadProjectsForClient(this.ctrl.GetProjectsForUser(this.lstListeClients.SelectedItem as User));
                WavActivity.CreationProjet(this.ctrl.ConnectedUser, frm.NouveauProjet);
            }
        }

        private void ActivityTimer_Tick(object sender, EventArgs e)
        {
            this.ctrl.LoadActivityMonitor();

            if (this.weekMultiplier != 0)
            {
                this.ctrl.UpdateCalendar(DateTime.Now.AddDays(this.weekMultiplier * 7));
            }
            else
            {
                this.ctrl.UpdateCalendar();
            }

            this.ctrl.UpdateUnactive();

        }

        public void UpdateUnactiveCount(int count)
        {
            this.btnReviewClients.Invoke(() => this.btnReviewClients.Text = count.ToString());
            this.btnReviewClients.Invoke(() => this.btnReviewClients.Visible = count > 0);
        }

        private void MessageTimer_Tick(object sender, EventArgs e)
        {
            this.ctrl.UpdateChatCount();
        }

        public void UpdateChatCount(int amount)
        {
            try
            {
                this.btnChats.Invoke(() => this.btnChats.Text = "Chats (" + amount + ")");
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
                    return english;
            }
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            this.ctrl.UpdateCalendar();
            this.weekMultiplier = 0;
        }

        private void btnPreviusWeek_Click(object sender, EventArgs e)
        {
            this.weekMultiplier--;
            this.ctrl.UpdateCalendar(DateTime.Now.AddDays(this.weekMultiplier * 7));
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            this.weekMultiplier++;
            this.ctrl.UpdateCalendar(DateTime.Now.AddDays(this.weekMultiplier * 7));
        }

        private void lbActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.lbActivity.SelectedItem.ToString());
        }
    }
}