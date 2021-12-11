using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavContact.Models
{
    class ClientForWaview
    {
        string name;
        private List<Project> projets;

        public ClientForWaview(string name)
        {
            this.name = name;
            this.Projets = new List<Project>();
        }

        public string Name { 
            get => name; 
            set => name = value; 
        }

        public override string ToString()
        {
            return this.name;
        }

        public List<Project> Projets { 
            get => projets; 
            set => projets = value; 
        }

        public void AddProject(Project p)
        {
            this.Projets.Add(p);
        }
    }
}
