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
    class WavfiewMaterielController
    {
        private FrmWaviewGestionStock _frame;
        private List<Materiel> _materiels;
        private List<CategorieMateriel> _categories;

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

        public Tuple<Materiel, CategorieMateriel, int> SelectMateriel(int index)
        {
            if (index >= 0 && index < this.Materiels.Count)
            {
                CategorieMateriel cm = GetCategorie(this.Materiels[index]);

                int i = 0;

                if (cm != null)
                    i = this.Categories.IndexOf(cm);
                else
                    this.Materiels[index].IdCat = this.Categories[0].Id;

                return Tuple.Create(this.Materiels[index], cm, i);
            }
            return null;
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

        public FrmWaviewGestionStock Frame { get => _frame; set => _frame = value; }
        private List<Materiel> Materiels { get => _materiels; set => _materiels = value; }
        private List<CategorieMateriel> Categories { get => _categories; set => _categories = value; }
    }
}
