using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavContactLogin
{
    public class User
    {
        private string firstname;
        private string lastname;

        public User(string fn, string ln)
        {
            this.firstname = fn;
            this.lastname = ln;
        }

        public override string ToString()
        {
            return this.firstname + " " + this.lastname;
        }
    }
}
