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

#region WAVCONTACT using
using WavContact.Controllers;
using WavContact.DB;
using WavContact.Metier;
using WavContact.Models;
using WavContact.Views.Member;
using Activity = WavContact.DB.Activity;
#endregion

namespace WavContact.Views
{
    public partial class FrmWaviewPagePrincipale : Form
    {
        #region Variables privées
        private WaviewMemberController ctrl;

        List<ListBox> boxes = new List<ListBox>();
        List<Label> labels = new List<Label>();

        private int weekMultiplier = 0;
        #endregion

        /// <summary>
        /// Constructeur par défaut de la form de gestion d'un membre de waview
        /// </summary>
        /// <param name="u">Le membre de waview connecté</param>
        public FrmWaviewPagePrincipale(User u)
        {
            InitializeComponent();
            // Initialisation du controlleur
            this.ctrl = new WaviewMemberController(this, u);
            
            
        }

        #region RESIZE_FORM
        
        private void SmallScreen()
        {
            
            MessageBox.Show("En raison de la taille de votre écran, certaines fonctionnalités de l'application peuvent ne pas fonctionner correctement. Nous vous conseillons de règler la taille de votre écran à 100% pour une utilisation optimale de l'application.", "Petit réglage...");
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;

            this.Width = w - 70;
            this.Height = h - 70;

            //this.lbActivity.Visible = false;
            //this.lblActivity.Visible = false;

            
            int heightMagicalValue = 320;
            int widthMagicalValue = 1659;
            
            this.lstListeProjets.Height = this.Height - heightMagicalValue;
            this.lstListeProjets.Width = this.Width - widthMagicalValue;
            this.lstListeClients.Height = this.Height - heightMagicalValue;
            this.lstListeClients.Width = this.Width - widthMagicalValue;

            this.lstListeProjets.Location = new Point(this.lstListeClients.Location.X + this.lstListeClients.Width + 10, this.lstListeProjets.Location.Y);
            this.lblProjets.Location = new Point(this.lstListeProjets.Location.X, this.lblProjets.Location.Y);

            // Réglage des boutons de l'application
            this.btnNewClient.Width = this.lstListeClients.Width / 2 - 2;
            this.btnInfosClients.Width = this.lstListeClients.Width / 2 - 2;

            this.btnNewClient.Location = new Point(this.lstListeClients.Location.X + this.lstListeClients.Width / 2 + 4 , this.btnNewClient.Location.Y);
            this.btnInfosClients.Location = new Point(this.lstListeClients.Location.X, this.btnInfosClients.Location.Y);

            this.btnNewProject.Width = this.lstListeProjets.Width;
            this.btnNewProject.Location = new Point(this.lstListeProjets.Location.X, this.btnNewProject.Location.Y);

            //w : 2081 - 1140 = 961
            //h : 1492 - 214 = 1278
            this.lbDay1.Width = this.Width - 941;
            
            this.lblDay1.Location = new Point(this.Width - 30 - this.lbDay1.Width, this.lblDay1.Location.Y);
            this.lbDay1.Location = new Point(this.Width - 30 - this.lbDay1.Width, this.lbDay1.Location.Y);

            int size = this.lbDay1.Width / 3 - 2;
            this.lbDay2.Width = size;
            this.lbDay3.Width = size;
            this.lbDay4.Width = size;
            this.lbDay5.Width = size;
            this.lbDay6.Width = size;
            this.lbDay7.Width = size;
            
            this.lbDay2.Location = new Point(this.lbDay1.Location.X, this.lbDay2.Location.Y);
            this.lbDay5.Location = new Point(this.lbDay1.Location.X, this.lbDay5.Location.Y);
            
            this.lbDay4.Location = new Point(this.lbDay1.Location.X + size + 4, this.lbDay4.Location.Y);
            this.lbDay6.Location = new Point(this.lbDay1.Location.X + size + 4, this.lbDay6.Location.Y);

            this.lbDay3.Location = new Point(this.lbDay4.Location.X + size + 4, this.lbDay3.Location.Y);
            this.lbDay7.Location = new Point(this.lbDay4.Location.X + size + 4, this.lbDay7.Location.Y);

            this.lblDay2.Location = new Point(this.lbDay2.Location.X, this.lblDay2.Location.Y);
            this.lblDay3.Location = new Point(this.lbDay3.Location.X, this.lblDay3.Location.Y);
            this.lblDay4.Location = new Point(this.lbDay4.Location.X, this.lblDay4.Location.Y);
            this.lblDay5.Location = new Point(this.lbDay5.Location.X, this.lblDay5.Location.Y);
            this.lblDay6.Location = new Point(this.lbDay6.Location.X, this.lblDay6.Location.Y);
            this.lblDay7.Location = new Point(this.lbDay7.Location.X, this.lblDay7.Location.Y);

            this.lbActivity.Location = new Point(this.lstListeProjets.Location.X + this.lstListeProjets.Width + 10, this.lstListeProjets.Location.Y);

            int activityWidth = (this.lblDay1.Location.X - 10) - (this.lstListeProjets.Location.X + this.lstListeProjets.Width + 10);
            int activityHeight = this.lbDay5.Bottom - this.lbActivity.Top;
            
            this.lbActivity.Width = activityWidth;
            this.lbActivity.Height = activityHeight;

            this.lblActivity.Location = new Point(this.lbActivity.Location.X, this.lblProjets.Location.Y);
        }

        #endregion

        private void FrmWaviewMember_Load(object sender, EventArgs e)
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
