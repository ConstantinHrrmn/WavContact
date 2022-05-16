using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavContact.DB
{
    public class Activity
    {
        private string _id;
        private string _prenom;
        private string _content;
        private string _maJ;

        public string Id { get => _id; set => _id = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Content { get => _content; set => _content = value; }
        public string MaJ { get => _maJ; set => _maJ = value; }

        public Activity()
        {
            
        }
        public Activity(string id, string prenom, string content, string maJ)
        {
            this.Id = id;
            this.Prenom = prenom;
            this.Content = content;
            this.MaJ = maJ;
        }

        public override string ToString()
        {
            return String.Format("{0} [{1}] : {2}", this.MaJ, this.Prenom, this.Content);
        }
    }
}
