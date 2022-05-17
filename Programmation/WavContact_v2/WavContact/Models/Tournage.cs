using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavContact.Models
{
    public class Tournage
    {
        private int _id;
        private DateTime _debut;
        private DateTime _fin;

        public int Id { get => _id; set => _id = value; }
        public DateTime Debut { get => _debut; set => _debut = value; }
        public DateTime Fin { get => _fin; set => _fin = value; }

        public Tournage(int id, DateTime debut, DateTime fin)
        {
            _id = id;
            _debut = debut;
            _fin = fin;
        }

        public Tournage()
        {
        }

        public override string ToString()
        {
            return "Début : " + _debut.ToString("dd/MM/yyyy H:mm") + " --> Fin :" + _fin.ToString("dd/MM/yyyy H:mm");
        }
    }
}
