using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WavContact.Models;
using WavContact.Views.Member;

namespace WavContact.Controllers
{
    class ProjectWaviewMemberController
    {
        private FrmWaviewProject frm;
        private Project project;

        public ProjectWaviewMemberController(FrmWaviewProject a_frm, Project a_project)
        {
            this.frm = a_frm;
            this.project = a_project;
            this.DisplayProjectInformationsInForm();
        }

        public void DisplayProjectInformationsInForm()
        {
            this.frm.ShowData(this.project);
        }
    }
}
