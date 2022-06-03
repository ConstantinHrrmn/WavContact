using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WavContact.Chat;
using WavContact.DB;
using WavContact.Models;
using WavContact.Signature;
using WavContact.Views.Member;

namespace WavContact.Controllers
{
    public class ProjectWaviewMemberController
    {
        private FrmWaviewProject frm;
        private Project project;
        private List<WavFile> files;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="a_frm">La forme mère</param>
        /// <param name="a_project">Le projet à afficher</param>
        public ProjectWaviewMemberController(FrmWaviewProject a_frm, Project a_project)
        {
            this.frm = a_frm;
            this.project = a_project;
            this.files = new List<WavFile>();
            
            this.DisplayProjectInformationsInForm();

            Thread tActivity = new Thread(new ThreadStart(GetActivity));
            Thread tDocuments = new Thread(new ThreadStart(DisplayDocuments));
            Thread tDates = new Thread(new ThreadStart(GetDates));
            Thread tPlaces = new Thread(new ThreadStart(GetPlaces));

            tActivity.Start();
            tDocuments.Start();
            tDates.Start();
            tPlaces.Start();

            WavFTP.CreateProjectDirectory(this.project);
        }

        /// <summary>
        /// Met à jour la description d'un projet
        /// Envoie dans la BDD
        /// Ajoute une activité 
        /// Met ajout la liste d'activité
        /// </summary>
        /// <param name="description">La nouvelle description</param>
        public void UpdateProjectDescription(string description)
        {
            this.project.Description = description;
            WavContactPDO.UpdateProject(this.project);
            WavActivity.AjoutActiviteCustom(this.frm.LoggedUser, this.project, "Modification de la description.");
            this.GetActivity();
        }

        /// <summary>
        /// Met à jour le commentaire d'un projet
        /// Envoie dans la BDD
        /// Ajoute une activité 
        /// Met ajout la liste d'activité
        /// </summary>
        /// <param name="commentary">Le commentaire a modifier</param>
        public void UpdateProjectCommentary(string commentary)
        {
            this.project.Commentaire = commentary;
            WavContactPDO.UpdateProject(this.project);
            WavActivity.AjoutActiviteCustom(this.frm.LoggedUser, this.project, "Modification du commentaire.");
            this.GetActivity();
        }

        /// <summary>
        /// Récupère les activités du projet
        /// Met a jour la liste d'activité dans la forme mère
        /// </summary>
        public void GetActivity()
        {
            this.frm.UpdateActivityList(WavActivity.GetActivities(this.project));
        }
        
        /// <summary>
        /// Ajout d'une date de tournage pour un projet
        /// Met a jour les informations
        /// </summary>
        public void AddDate()
        {
            FrmDatePicker frmPicker = new FrmDatePicker();
            if (frmPicker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DateTime debut = frmPicker.Debut;
                DateTime fin = frmPicker.Fin;

                Tournage t = new Tournage();
                t.Debut = debut;
                t.Fin = fin;

                WavContactPDO.CreateDateForProject(this.project, t);
                WavActivity.AjoutActiviteCustom(this.frm.LoggedUser, this.project, "Ajout d'une date");
                this.GetActivity();
                
                this.GetDates();
                
            }
        }

        /// <summary>
        /// Supprimer une date de tournage
        /// </summary>
        /// <param name="date">La date à supprimer</param>
        public void DeleteDate(Tournage date)
        {
            WavContactPDO.DeleteDate(date);
            WavActivity.AjoutActiviteCustom(this.frm.LoggedUser, this.project, "Suppression d'une date");
            this.GetActivity();
            this.GetDates();
        }

        /// <summary>
        /// Met à jour une date de Tournage
        /// </summary>
        /// <param name="tournage">La date de tournage mise a jour à envoyer dans la BDD</param>
        public void UpdateDate(Tournage tournage)
        {
            FrmDatePicker frmPicker = new FrmDatePicker(tournage.Debut, tournage.Fin);
            if (frmPicker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DateTime debut = frmPicker.Debut;
                DateTime fin = frmPicker.Fin;

                tournage.Debut = debut;
                tournage.Fin = fin;

                WavContactPDO.UpdateTournage(tournage);
                WavActivity.AjoutActiviteCustom(this.frm.LoggedUser, this.project, "Modification de la date du tournage.");
                this.GetActivity();

                this.GetDates();
            }
        }

        /// <summary>
        /// Récupère toutes les dates pour un projet
        /// Met a jour les dates dans la liste des dates
        /// </summary>
        public void GetDates()
        {
            this.frm.UpdateDateList(WavContactPDO.GetTournageForProject(this.project));
        }

        /// <summary>
        /// Récupère tous les lieux pour le projet
        /// Met a jour la liste des lieux
        /// </summary>
        public void GetPlaces()
        {
            this.frm.UpdateLieuxList(WavContactPDO.GetLieuxPourProjet(this.project));
        }

        #region Documents
        /// <summary>
        /// Récupère et affiche les documents du projet
        /// </summary>
        public void DisplayDocuments()
        {
            this.files = WavFTP.listFiles(this.project);
            this.frm.UpdateDocumentList(this.files);

        }

        /// <summary>
        /// Retourne le fichier sélectionné à l'inex
        /// </summary>
        /// <param name="index">Index a sélectionner</param>
        /// <returns>Le fichier sélectionné</returns>
        public WavFile SelectedFile(int index)
        {
            if (index >= 0 && index < this.files.Count)
            {
                return this.files[index];
            }

            return null;
        }

        /// <summary>
        /// Téléchargement d'un fichier (dans un Thread)
        /// </summary>
        /// <param name="file">Le fichier à télécharger</param>
        public void DownloadFile(WavFile file)
        {
            
            Thread th = new Thread(new ThreadStart(() =>
            {
                WavFTP.DownloadFile(file, this.project);
            }
            ));
            th.Start();
        }

        /// <summary>
        /// Mise en ligne d'une fichier
        /// </summary>
        /// <param name="sourcePath">Le path du fichier à mettre en ligne</param>
        public void UploadFile(string sourcePath)
        {
            Thread th = new Thread(new ThreadStart(() =>
            {
                WavFTP.UploadFile(sourcePath, this.project);
                this.DisplayDocuments();

                WavActivity.AjoutDocument(this.frm.LoggedUser, this.project, Path.GetFileName(sourcePath));
                this.GetActivity();
            }
            ));
            th.Start();
        }

        /// <summary>
        /// Supprimer un fichier 
        /// </summary>
        /// <param name="file">Le fichier à supprimer</param>
        public void DeleteFile(WavFile file)
        {
            Thread th = new Thread(new ThreadStart(() =>
            {
                WavFTP.DeleteFile(file, this.project);
                this.DisplayDocuments();

                WavActivity.SuppressionDocument(this.frm.LoggedUser, this.project, file.Name);
                this.GetActivity();
            }
            ));
            th.Start();
        }
        #endregion

        /// <summary>
        /// Supprimer lieu du tournage
        /// </summary>
        /// <param name="lieu">Le lieu à supprimer</param>
        public void DeletePlace(Lieu lieu)
        {
            Tournage t = new Tournage();
            t.Id = lieu.IdTournage;
            WavContactPDO.DeletePlaceForProject(lieu, this.project, t);
            WavActivity.AjoutActiviteCustom(this.frm.LoggedUser, this.project, "Suppression d'un lieu ("+lieu.Nom+")");
            this.GetActivity();
            this.GetPlaces();
        }

        /// <summary>
        /// Affichage de toutes les informations du projet dans le formulaire
        /// </summary>
        public void DisplayProjectInformationsInForm()
        {
            this.frm.ShowData(this.project);
        }

        /// <summary>
        /// Ouverture du dossier du projet dans l'explorateur de fichiers
        /// </summary>
        /// <returns>True si le dossier à pu s'ouvrir, false si non</returns>
        public bool OpenFolderInExplorer()
        {
            return WavFTP.OpenProjectFolder(this.project);
        }

        /// <summary>
        /// Retourne le projet du controlleur
        /// </summary>
        /// <returns>Le projet</returns>
        public Project GetProject()
        {
            return this.project;
        }
        
        /// <summary>
        /// Permet de supprimer le projet de la BDD (Action irréversible)
        /// </summary>
        public void DeleteProject()
        {
            WavContactPDO.DeleteProject(this.project);
            WavActivity.AjoutActiviteCustom(this.frm.LoggedUser, "Suppression du projet : " + this.project.Name);
        }
  
        /// <summary>
        /// Permet de signer un document PDF
        /// </summary>
        /// <param name="u">L'utilisateur qui signe le document</param>
        /// <param name="file">Le fichier a signer</param>
        /// <param name="cert">Le chemin local du certificat pfx</param>
        /// <param name="pass">Le mot de passe du certificat</param>
        /// <returns>True si le document à bien été signé, False si une erreur survient</returns>
        public bool SignDocument(User u, WavFile file, string cert, string pass)
        {
            return WavSign.SignerDocument(u, file, this.project, cert, pass);
        }
    }
}
