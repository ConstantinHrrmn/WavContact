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

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public int Valider { get => valider; set => valider = value; }

        public Project()
        {

        }

        public Project(int a_id, string a_name, string a_description, int a_valider)
        {
            this.Id = a_id;
            this.Name = a_name;
            this.Description = a_description;
            this.Valider = a_valider;
        }

        public override string ToString()
        {
            return this.Name;
        }

       
    }
}
