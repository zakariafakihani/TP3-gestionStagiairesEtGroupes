using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP1.PackageGroupes
{
    class GestionGroupes
    {
        private static List<Groupe> listeGroupes = new List<Groupe>();

        internal static List<Groupe> ListeGroupes
        {
            get { return GestionGroupes.listeGroupes; }
            set { GestionGroupes.listeGroupes = value; }
        }

        public GestionGroupes()
        {
            
        }


        public void Ajouter(Groupe g)
        {
            listeGroupes.Add(g);
        }

        public void Supprimer(int index)
        {
            listeGroupes.RemoveAt(index);
        }

        public void Modifier(Groupe g)
        {
            foreach (Groupe gM in listeGroupes)
            {
                if (gM.Id == g.Id)
                    gM.Nom = g.Nom;
            }
        }


        public List<Groupe> Afficher()
        {
            return listeGroupes;
        }

        public Groupe getGroupe(int index)
        {
            return listeGroupes.ElementAt(index);
        }

    }
}
