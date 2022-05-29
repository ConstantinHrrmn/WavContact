using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavContact.Models
{
    public class Lieu
    {
        private int _id;
        private string _nom;
        private double _latitude;
        private double _longitude;
        private int _idTournage;
        private string _description;
        private string _pathImage;

        private Tournage _horaires;

        public Lieu()
        {
        }

        public Lieu(int id, string nom, double latitude, double longitude, int idTournage)
        {
            _id = id;
            _nom = nom;
            _latitude = latitude;
            _longitude = longitude;
            _idTournage = idTournage;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public double Lat { get => _latitude; set => _latitude = value; }
        public double Lon { get => _longitude; set => _longitude = value; }
        public Tournage Horaires { get => _horaires; set => _horaires = value; }
        public int IdTournage { get => _idTournage; set => _idTournage = value; }
        public string Description { get => _description; set => _description = value; }
        public string PathImage { get => _pathImage; set => _pathImage = value; }

        public override string ToString()
        {
            if (this.Horaires == null)
            {
                return String.Format("{0}", this.Nom);
            }
            else
            {
                return String.Format("{0} [{1} - {2}]", this.Nom, this.Horaires.Debut.ToShortDateString(), this.Horaires.Fin.ToShortDateString());
            }
            
        }

        public string ToMaps()
        {
            return string.Format("{0}{1}%2C{2}", "https://www.google.com/maps/search/?api=1&query=", this.Lat.ToString(), this.Lon.ToString());
        }
    }
}
