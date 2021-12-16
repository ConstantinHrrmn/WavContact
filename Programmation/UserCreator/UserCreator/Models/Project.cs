using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavContact.Models
{
    public class Project
    {
        private string name;
        public string Name { get => name; set => name = value; }


        public Project(string a_name)
        {
            this.name = a_name;
        }

        public override string ToString()
        {
            return this.name;
        }

       
    }
}
