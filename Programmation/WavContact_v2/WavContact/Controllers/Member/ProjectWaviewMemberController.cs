using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WavContact.DB;
using WavContact.Models;
using WavContact.Views.Member;

namespace WavContact.Controllers
{
    public class ProjectWaviewMemberController
    {
        private FrmWaviewProject frm;
        private Project project;
        private List<WavFile> files;

        public ProjectWaviewMemberController(FrmWaviewProject a_frm, Project a_project)
        {
            this.frm = a_frm;
            this.project = a_project;
            this.files = new List<WavFile>();
            
            this.DisplayProjectInformationsInForm();

            Thread tActivity = new Thread(new ThreadStart(GetActivity));
            Thread tDocuments = new Thread(new ThreadStart(DisplayDocuments));

            tActivity.Start();
            tDocuments.Start();
        }

        public void UpdateProjectDescription(string description)
        {
            this.project.Description = description;
            WavContactPDO.UpdateProject(this.project);
            WavActivity.AjoutActiviteCustom(this.frm.LoggedUser, this.project, "Modification de la description.");
            this.GetActivity();
        }

        public void UpdateProjectCommentary(string commentary)
        {
            this.project.Commentaire = commentary;
            WavContactPDO.UpdateProject(this.project);
            WavActivity.AjoutActiviteCustom(this.frm.LoggedUser, this.project, "Modification du commentaire.");
            this.GetActivity();
        }

        public void GetActivity()
        {
            this.frm.UpdateActivityList(WavActivity.GetActivities(this.project));
        }
        
        public void DisplayDocuments()
        {
            this.files = WavFTP.listFiles(this.project);
            this.frm.UpdateDocumentList(this.files);

        }

        public WavFile SelectedFile(int index)
        {
            if (index >= 0 && index < this.files.Count)
            {
                return this.files[index];
            }

            return null;
        }

        public void DownloadFile(WavFile file)
        {
            WavFTP.CreateProjectDirectory(this.project);
            
            Thread th = new Thread(new ThreadStart(() =>
            {
                WavFTP.DownloadFile(file, this.project);
            }
            ));
            th.Start();
        }

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

        public void DisplayProjectInformationsInForm()
        {
            this.frm.ShowData(this.project);
        }

        public bool OpenFolderInExplorer()
        {
            return WavFTP.OpenProjectFolder(this.project);
        }
    }
}
