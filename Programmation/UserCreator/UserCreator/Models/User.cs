using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavContact.Models
{
    public class User
    {
        private int role_id;
        private string firstname;
        private string lastname;
        private List<Project> projets;

        public User(string fn, string ln, int ri)
        {
            this.Firstname = fn;
            this.Lastname = ln;
            this.Role_id = ri;
            this.Projets = new List<Project>();
        }

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public List<Project> Projets { get => projets; set => projets = value; }
        public int Role_id { get => role_id; set => role_id = value; }

        public void AddProject(Project p)
        {
            this.Projets.Add(p);
        }

        public override string ToString()
        {
            return this.Firstname + " " + this.Lastname;
        }
    }
}
