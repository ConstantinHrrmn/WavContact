using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavContact.Models
{
    public class CategorieMateriel
    {
        private int _id;
        private string _nom;

        public CategorieMateriel() { }
        public CategorieMateriel(int a_id, string a_nom)
        {
            this.Id = a_id;
            this.Nom = a_nom;
        }

        public override string ToString()
        {
            return string.Format("({0}) {1}", this.Id, this.Nom);
        }

        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
    }
}
