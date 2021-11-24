using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavContact.Models
{
    public class User
    {
        private string firstname;
        private string lastname;
        private List<Project> projets;

        public User(string fn, string ln)
        {
            this.Firstname = fn;
            this.Lastname = ln;
            this.Projets = new List<Project>();
        }

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public List<Project> Projets { get => projets; set => projets = value; }

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
