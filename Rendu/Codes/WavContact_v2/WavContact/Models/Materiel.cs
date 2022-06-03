using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavContact.Models
{
    public class Materiel
    {
        private int _id;
        private int _idCat;
        private string _nom;
        private string _description;
        private double _prix;
        private int _quantite;

        public Materiel() { }
        public Materiel(int a_id, int a_idCat, string a_nom, string a_description, double a_prix, int a_quantite)
        {
            this.Id = a_id;
            this.IdCat = a_idCat;
            this.Nom = a_nom;
            this.Description = a_description;
            this.Prix = a_prix;
            this.Quantite = a_quantite;
        }

        public override string ToString()
        {
            return string.Format("({0}) {1} [{2}x]", this.Id, this.Nom, this.Quantite);
        }

        public int Id { get => _id; set => _id = value; }
        public int IdCat { get => _idCat; set => _idCat = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Description { get => _description; set => _description = value; }
        public double Prix { get => _prix; set => _prix = value; }
        public int Quantite { get => _quantite; set => _quantite = value; }
    }
}
