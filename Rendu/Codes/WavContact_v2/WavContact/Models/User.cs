﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavContact.Models
{
    public class User
    {
        private int id;
        private int role_id;

        private string firstname;
        private string lastname;
        private string email;
        private string phone;

        private List<Project> projets;

        private int unread;

        public User()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i">Id de la database</param>
        /// <param name="em">Email</param>
        /// <param name="fn">prenom</param>
        /// <param name="ln">nom</param>
        /// <param name="ri">Role de l'id</param>
        /// <param name="ph">telephone</param>
        public User(int i, string em, string fn, string ln, int ri, string ph)
        {
            this.First_name = fn;
            this.Last_name = ln;
            this.IdRole = ri;
            this.Id = i;
            this.Email = em;
            this.Phone = ph;
            this.Projets = new List<Project>();
        }

        public string First_name { get => firstname; set => firstname = value; }
        public string Last_name { get => lastname; set => lastname = value; }
        public List<Project> Projets { get => projets; set => projets = value; }
        public int IdRole { get => role_id; set => role_id = value; }
        public string Email { get => email; set => email = value; }
        public int Id { get => id; set => id = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Unread { get => unread; set => unread = value; }

        public void AddProject(Project p)
        {
            this.Projets.Add(p);
        }

        public override string ToString()
        {
            return this.First_name + " " + this.Last_name;
        }

        public string ToChatList()
        {
            return this.First_name + " " + this.Last_name + (this.unread > 0 ? " ("+this.unread+")" : "") ;
        }
    }
}