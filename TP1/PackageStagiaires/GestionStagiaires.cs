using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TP1.PackageGroupes;
using PackageGroupes;
namespace TP1.PackageStagiaires
{
    class GestionStagiaires
    {
        private static List<Stagiaire> listeStagiaires = new List<Stagiaire>();

        public GestionStagiaires()
        {
            
        }

        public GestionStagiaires(bool Remplissage)
        {
            for (int i = 1; i <= 2; i++)
                GestionGroupes.ListeGroupes.Add(new Groupe(i,"TDI" + i));

            for (int i = 1; i <= 1; i++)
                listeStagiaires.Add(new Stagiaire(i, "FAKIHNAI " , "ZAKARIA" ,GestionGroupes.ListeGroupes[i-1]));
        }

        public void Ajouter(Stagiaire s)
        {
            listeStagiaires.Add(s);
        }

        public void Supprimer(int index)
        {
            listeStagiaires.RemoveAt(index);
        }

        public void Modifier(Stagiaire s)
        {
            foreach (Stagiaire stag in listeStagiaires)
            {
                if (stag.Id == s.Id){
                    stag.Nom = s.Nom;
                    stag.Prenom = s.Prenom;
                    stag.Groupe = s.Groupe;
                }
            }
        }


        public List<Stagiaire> Afficher()
        {
            return listeStagiaires;
        }

        public Stagiaire getStagiaire(int index)
        {
            return listeStagiaires.ElementAt(index);
        }

    }
}
