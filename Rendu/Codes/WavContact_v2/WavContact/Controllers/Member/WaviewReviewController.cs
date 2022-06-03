using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WavContact.DB;
using WavContact.Models;
using WavContact.Views;
using WavContact.Metier;

namespace WavContact.Controllers.Member
{
    public class WaviewReviewController
    {
        private FrmReviewClients _frm;

        List<User> clients;
        
        public FrmReviewClients Frm { get => _frm; set => _frm = value; }

        public WaviewReviewController(FrmReviewClients frm)
        {
            this.Frm = frm;
        }
        
        public void LoadData()
        {
            this.clients = WavContactPDO.UnactiveCLients();
            this.Frm.UpdateData(this.clients);
        }

        public void DeleteUser(User u) 
        {
            Mailing.SendMessage(u.Email, "Votre compte n'as pas été approuvé...", "Bonjour, malheureusement votre compte n'a pas été approuvé par l'administrateur. Veuillez contacter l'administrateur pour plus d'informations.");
            WavContactPDO.DeleteUser(u);
            WavActivity.AjoutActiviteCustom(u, null, "Inscription rejetée !");
            this.LoadData();
        }

        public void ActivateUser(User u)
        {
            string pass = WavContactPDO.GeneratePass(5);
            Mailing.SendMessage(u.Email, "Votre compte a été approuvé...", "Bonjour, votre compte a été approuvé par l'administrateur. Vous pouvez désormais vous connecter. \n\n Votre mot de passe est : " + pass +"\n\n" + "Lien pour télécharger l'application WavContact : https://waview.ch/client/download \n Lien pour WavMap : https://waview.ch/wavcontact/map \n\n Nous avons hâte de commencer vos projets ! \n L'équipe Waview" );
            WavContactPDO.ActivateUser(u);
            WavContactPDO.ResetUserPassword(u.Email, pass);
            WavActivity.AjoutActiviteCustom(u, null, "Compte activé !");
            this.LoadData();
        }
            
    }
}
