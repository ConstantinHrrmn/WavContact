using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WavContact.Views.Member;
using WavContact.DB;
using WavContact.Models;

namespace WavContact.Controllers.Member
{
    public class WaviewMaterielTournageController
    {
        private FrmMaterielTournage _frm;

        private List<CategorieMateriel> _categories;
        private List<Materiel> _materielsDispos;
        private List<Materiel> _materielsTournage;
        private List<Tournage> _tournages;

        private Project _projet;
        private Tournage _selectedDate;
        
        public WaviewMaterielTournageController(FrmMaterielTournage frm, Project p)
        {
            this.Frm = frm;
            this.Projet = p;
        }

        public FrmMaterielTournage Frm { get => _frm; set => _frm = value; }
        public List<CategorieMateriel> Categories { get => _categories; set => _categories = value; }
        public Project Projet { get => _projet; set => _projet = value; }
        public Tournage SelectedDate { get => _selectedDate; set => _selectedDate = value; }
        public List<Materiel> MaterielsDispos { get => _materielsDispos; set => _materielsDispos = value; }
        public List<Materiel> MaterielsTournage { get => _materielsTournage; set => _materielsTournage = value; }
        public List<Tournage> Tournages { get => _tournages; set => _tournages = value; }

        public void UpdateCategories()
        {
            this.Categories = WavContactPDO.GetCategories();
            this.Frm.UpdateCatergories(this.Categories);
        }
        
        public void UpdateTournages()
        {
            this.Tournages = WavContactPDO.GetTournageForProject(this.Projet);
            this.Frm.UpdateTournageDates(this.Tournages);
        }
    }
}
