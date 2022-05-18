using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavContact.DB
{
    public class Calendat
    {
        private int _jour;
        private string _projet;
        private DateTime _debut;
        private DateTime _fin;

        public int Jour { get => _jour; set => _jour = value; }
        public DateTime Debut { get => _debut; set => _debut = value; }
        public DateTime Fin { get => _fin; set => _fin = value; }
        public string Projet { get => _projet; set => _projet = value; }

        public Calendat(int jour, string projet, DateTime debut, DateTime fin)
        {
            _jour = jour;
            _projet = projet;
            _debut = debut;
            _fin = fin;
        }

        public override string ToString()
        {
            return this.Projet;
        }

        public string ToString(DateTime actual)
        {
            if (this.Debut.Date >= actual.Date)
            {
                return string.Format("[Début : {0}] {1}", this.Debut.ToShortTimeString(), this.Projet);
            }else if(this.Fin.Date <= actual.Date)
            {
                return string.Format("[Fin : {0}] {1}", this.Fin.ToShortTimeString(), this.Projet);
            }
            else
            {
                return string.Format("[Toute la journée] {0}", this.Projet);
            }
        }
    }
}
