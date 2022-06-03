using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WavContact.Views.Member;
using WavContact.Models;
using WavContact.DB;
using System.Diagnostics;

namespace WavContact.Controllers.Member
{
    public class WavfiewMaterielController
    {
        private FrmWaviewGestionStock _frame;
        private List<Materiel> _materiels;
        private List<CategorieMateriel> _categories;

        public FrmWaviewGestionStock Frame { get => _frame; set => _frame = value; }
        private List<Materiel> Materiels { get => _materiels; set => _materiels = value; }
        private List<CategorieMateriel> Categories { get => _categories; set => _categories = value; }

        public WavfiewMaterielController(FrmWaviewGestionStock a_frame)
        {
            this.Frame = a_frame;

            this.UpdateMateriel();
            this.UpdateCategories();
        }

        public void UpdateMateriel()
        {
            this.Materiels = WavContactPDO.GetMateriel();
            this.Frame.UpdateMateriel(this.Materiels);
        }

        public void DisplayMateriel()
        {
            this.Frame.UpdateMateriel(this.Materiels);
        }

        public Tuple<Materiel, CategorieMateriel, int> SelectMateriel(Materiel m)
        {
                CategorieMateriel cm = GetCategorie(m);

                int i = 0;

                if (cm != null)
                    i = this.Categories.IndexOf(cm);
                else
                    m.IdCat = this.Categories[0].Id;

                return Tuple.Create(m, cm, i);
    
        }

        public CategorieMateriel GetCategorie(Materiel m)
        {
            foreach (CategorieMateriel item in this.Categories)
            {
                if (m.IdCat == item.Id)
                {
                    return item;
                }
            }

            return null;
        }

        public void UpdateCategories()
        {
            this.Categories = WavContactPDO.GetCategories();
            this.Frame.UpdateCatergories(this.Categories);
        }

        public void Filtrer(int index)
        {
            CategorieMateriel categorie = null;
            if (index == 0)
            {
                this.Frame.UpdateMateriel(this.Materiels);
            }
            else
            {
                categorie = this.Categories[index-1];

                List<Materiel> filtered = new List<Materiel>();
                foreach (Materiel item in this.Materiels)
                {
                    if (item.IdCat == categorie.Id)
                    {
                        filtered.Add(item);
                    }
                }

                this.Frame.UpdateMateriel(filtered);
            }
           
        }

        public void DeleteMateriel(Materiel m)
        {
            WavContactPDO.DeleteMaterial(m);
            this.UpdateMateriel();
        }

        public void Search(string search)
        {
            List<Materiel> filtered = new List<Materiel>();
            foreach (Materiel item in this.Materiels)
            {
                if (item.Nom.ToLower().Contains(search.ToLower()))
                {
                    filtered.Add(item);
                }
            }

            this.Frame.UpdateMateriel(filtered);
        }

        
    }
}
