using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WavContact.Views.Member;
using WavContact.DB;
using WavContact.Models;
using System.Threading;
using WavContact.Metier;

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

        public void UpdateMaterielPris()
        {
            Thread thread = new Thread(() =>
            {
                this.MaterielsTournage = WavContactPDO.GetMaterielForTournage(this.SelectedDate);
                this.Frm.UpdateMaterielPris(this.MaterielsTournage);
            });

            thread.Start();
        }

        public void UpdateMaterielDispo()
        {
            Thread thread = new Thread(() =>
            {
                this.MaterielsDispos = WavContactPDO.GetAvaibleMaterielForTournage(this.SelectedDate);
                this.Frm.UpdateMaterielDispo(this.MaterielsDispos);
            });

            thread.Start();
        }

        public void FiltrerAvaible(int index)
        {
            CategorieMateriel categorie = null;
            if (index == 0)
            {
                this.Frm.UpdateMaterielDispo(this.MaterielsDispos);
            }
            else
            {
                categorie = this.Categories[index - 1];

                List<Materiel> filtered = new List<Materiel>();
                foreach (Materiel item in this.MaterielsDispos)
                {
                    if (item.IdCat == categorie.Id)
                    {
                        filtered.Add(item);
                    }
                }

                this.Frm.UpdateMaterielDispo(filtered);
            }
        }

        public void FiltrerSelected(int index)
        {
            CategorieMateriel categorie = null;
            if (index == 0)
            {
                this.Frm.UpdateMaterielPris(this.MaterielsTournage);
            }
            else
            {
                categorie = this.Categories[index - 1];

                List<Materiel> filtered = new List<Materiel>();
                foreach (Materiel item in this.MaterielsTournage)
                {
                    if (item.IdCat == categorie.Id)
                    {
                        filtered.Add(item);
                    }
                }

                this.Frm.UpdateMaterielPris(filtered);
            }

        }


        private void Update()
        {
            this.UpdateMaterielPris();
            this.UpdateMaterielDispo();
        }

        public void Update(Tournage t)
        {
            this.SelectedDate = t;
            this.UpdateMaterielPris();
            this.UpdateMaterielDispo();
        }

        public void UpdateReservation(Materiel m, int amount)
        {
            WavContactPDO.UpdateReservation(this.Projet, this.SelectedDate, m, amount);
            this.Update();
        }

        public void NewReservation(Materiel m, int amount)
        {
            WavContactPDO.CreateReservation(this.Projet, this.SelectedDate, m, amount);
            this.Update();
        }

        public void UpdateTakenReservation(Materiel m, int extraAmount)
        {
            int q = this.GetTakenCount(m) + extraAmount;
            WavContactPDO.UpdateReservation(this.Projet, this.SelectedDate, m, q);
            this.Update();
        }

        public void DeleteReservation(Materiel m)
        {
            WavContactPDO.DeleteReservation(this.Projet, this.SelectedDate, m);
            this.Update();
        }

        public int AvaibleCount(Materiel toFind)
        {
            foreach (Materiel m in this.MaterielsDispos)
            {
                if (m.Id == toFind.Id)
                {
                    return m.Quantite;
                }
            }
            return 0;
        }

        public bool IsAllReadyTaken(Materiel m)
        {
            foreach (Materiel m2 in this.MaterielsTournage)
            {
                if (m2.Id == m.Id)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetTakenCount(Materiel m){
            foreach (Materiel m2 in this.MaterielsTournage)
            {
                if (m2.Id == m.Id)
                {
                    return m2.Quantite;
                }
            }
            return 0;
        }

        public void DisplayMateriel()
        {
            this.Frm.UpdateMaterielDispo(this.MaterielsDispos);
            this.Frm.UpdateMaterielPris(this.MaterielsTournage);
        }

        public void PrintList(bool export) 
        {
            WavPDFWriter.WritePDF(this.Projet, this.SelectedDate, this.MaterielsTournage, this.Categories, export);

            if (export)
            {
                User u = new User();
                u.Id = 0;
                WavActivity.AjoutDocument(u, this.Projet, " Liste de tournage [" + this.SelectedDate.Debut.ToShortDateString() + " - " + this.SelectedDate.Fin.ToShortDateString() + "]");
            }
            
        }
            

        public void Search(string search)
        {
            List<Materiel> filtered = new List<Materiel>();
            foreach (Materiel m in this.MaterielsDispos)
            {
                if (m.Nom.ToLower().Contains(search.ToLower()))
                {
                    filtered.Add(m);
                }
            }
            this.Frm.UpdateMaterielDispo(filtered);

            filtered = new List<Materiel>();
            foreach (Materiel m in this.MaterielsTournage)
            {
                if (m.Nom.ToLower().Contains(search.ToLower()))
                {
                    filtered.Add(m);
                }
            }
            this.Frm.UpdateMaterielPris(filtered);
        }
    }
}
