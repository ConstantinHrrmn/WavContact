﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WavContact.Views;
using WavContact.Models;

namespace WavContact.Controllers
{
    class ProjectWaviewMemberController
    {
        private FrmWaviewProjet frm;
        private Project project;

        public ProjectWaviewMemberController(FrmWaviewProjet a_frm, Project a_project)
        {
            this.frm = a_frm;
            this.project = a_project;
            this.DisplayProjectInformationsInForm();
        }

        public void DisplayProjectInformationsInForm()
        {
            this.frm.DisplayProjectInformations(this.project);
        }
    }
}