﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region WAVCONTACT using
using WavContact.Controllers;
using WavContact.Metier;
using WavContact.Views;
using WavContact.Models;
using WavContact.Views.Member;
using WavContact.DB;
using System.Threading;
using WavContact.Chat;
#endregion

namespace WavContact.Controllers
{
    public class WaviewMemberController
    {
        #region Variables privées
        private FrmWaviewPagePrincipale frm;
        private User connectedUser;

        private List<User> clients;
        #endregion

        #region GETTER / SETTER
        public User ConnectedUser { get => connectedUser; set => connectedUser = value; }
        #endregion

        /// <summary>
        /// Constructeur par défaut d'un controlleur de vue de la form Waview member
        /// </summary>
        /// <param name="a_frm">la form que controlle le controlleur</param>
        /// <param name="a_connectedUser">L'utilisateur connecté</param>
        public WaviewMemberController(FrmWaviewPagePrincipale a_frm, User a_connectedUser)
        {
            this.frm = a_frm;
            this.ConnectedUser = a_connectedUser;
            this.clients = new List<User>();
            this.clients = WavContact.DB.WavContactPDO.Clients();

            this.frm.LoadClients(this.clients);
            Thread tActivity = new Thread(LoadActivityMonitor);
            tActivity.Start();
        }

        

        public List<Project> GetProjectsForUser(User u)
        {
            u.Projets = WavContact.DB.WavContactPDO.ProjectsForUser(u);
            return u.Projets;
        }

        public void Logout()
        {
            PropertiesManager.Logout();
        }

        public void LoadProjectPage(Project p)
        {
            FrmWaviewProject frm = new FrmWaviewProject(p, this.ConnectedUser);
            frm.Show();
        }

        public void LoadActivityMonitor()
        {
            this.frm.UpdateActivityMonitor(WavContactPDO.GetLastActivites(15));
        }

        public void UpdateClients()
        {
            this.clients = WavContactPDO.Clients();
            this.frm.LoadClients(this.clients);
        }

        public void UpdateClient(User client)
        {
            
            WavContactPDO.UpdateUser(client);
            WavActivity.AjoutActiviteCustom(this.connectedUser, null, "Modification des informations de : " + client.ToString());
        }
        
        public void CreateClient(User client)
        {
            string password = WavContactPDO.GeneratePass(6);
            Mailing.SendMessage(client.Email, "Création de votre compte", "Bonjour \n\r Un administrateur Waview vient de vous créer un compte. Vous pouvez à présent profiter de WavContact et Wavmap. \n\r Votre mot de passe est : " + password + "\n\r Bonne journée ! \n\r L'équipe Waview");
            WavContactPDO.CreateClient(client, password);
            WavActivity.AjoutActiviteCustom(this.connectedUser, null, "Création du client : " + client.ToString());
        }

        public void UpdateChatCount()
        {
            Thread t = new Thread(() =>
            {
                int amount = WavChatPDO.GetUnreadMessagesCount(this.connectedUser);
                this.frm.UpdateChatCount(amount);
            });

            t.Start();
        }

        public void UpdateCalendar()
        {
            Thread t = new Thread(() =>
            {
                this.frm.UpdateCalendar(DateTime.Now, WavContactPDO.GetCalendar(DateTime.Now));
            });

            t.Start();
        }
        
        public void UpdateCalendar(DateTime firstDay)
        {
            Thread t = new Thread(() =>
            {
                this.frm.UpdateCalendar(firstDay, WavContactPDO.GetCalendar(firstDay));
            });

            t.Start();
        }

        public void UpdateUnactive()
        {
            Thread t = new Thread(() =>
            {

                int count = WavContactPDO.UnactiveCLients() != null ? WavContactPDO.UnactiveCLients().Count : 0;
                
                this.frm.UpdateUnactiveCount(count);
            });

            t.Start();
        }

        

    }
}