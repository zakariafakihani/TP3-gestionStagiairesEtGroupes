﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TP1.PackageGroupes;
namespace TP1.PackageStagiaires
{
    class Stagiaire
    {
        private int id;
        private string nom;
        private string prenom;
        private Groupe groupe;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        internal Groupe Groupe
        {
            get { return groupe; }
            set { groupe = value; }
        }
     

        public Stagiaire(int id,string nom,string prenom,Groupe g)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Groupe = g;
        }

        


    }
}
