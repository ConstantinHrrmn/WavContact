using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavContact.Models
{
    public class Project
    {
        private int id;
        private string name;
        private string description;
        private int valider;
        private string commentaire;

        private User _owner;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public int Valider { get => valider; set => valider = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
        public User Owner { get => _owner; set => _owner = value; }

        public Project()
        {

        }

        public Project(int a_id, string a_name, string a_description, int a_valider, string a_commentaire)
        {
            this.Id = a_id;
            this.Name = a_name;
            this.Description = a_description;
            this.Valider = a_valider;
            this.Commentaire = a_commentaire;
        }

        public override string ToString()
        {
            return this.Name;
        }

       
    }
}
