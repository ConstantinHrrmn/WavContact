using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            Thread t = new Thread(new ThreadStart(DisplayDocuments));
            t.Start();
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
