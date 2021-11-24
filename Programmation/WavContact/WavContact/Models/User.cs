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

        public User(string fn, string ln)
        {
            this.Firstname = fn;
            this.Lastname = ln;
        }

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }

        public override string ToString()
        {
            return this.Firstname + " " + this.Lastname;
        }
    }
}
