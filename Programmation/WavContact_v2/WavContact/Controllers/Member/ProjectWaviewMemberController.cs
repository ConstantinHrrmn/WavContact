using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public ProjectWaviewMemberController(FrmWaviewProject a_frm, Project a_project)
        {
            this.frm = a_frm;
            this.project = a_project;
            this.DisplayProjectInformationsInForm();
            this.UpdateDocuments();
        }

        public void UpdateDocuments()
        {
            this.frm.UpdateDocumentList(WavFTP.listFiles(this.project));
           
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
