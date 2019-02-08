using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public class Films
    {
        private int Id;
        private string Titre;
        private string Realisateur;
        private DateTime DateDeSortie;
        private string Resume;
        private string Genre;
        private int Duree;

        public Films(int id, string titre, string realisateur, DateTime dateDeSortie, string resume, 
            string genre, int duree)
        {
            Id1 = id;
            Titre1 = titre;
            Realisateur1 = realisateur;
            DateDeSortie1 = dateDeSortie;
            Resume1 = resume;
            Genre1 = genre;
            Duree1 = duree;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Titre1 { get => Titre; set => Titre = value; }
        public string Realisateur1 { get => Realisateur; set => Realisateur = value; }
        public DateTime DateDeSortie1 { get => DateDeSortie; set => DateDeSortie = value; }
        public string Resume1 { get => Resume; set => Resume = value; }
        public string Genre1 { get => Genre; set => Genre = value; }
        public int Duree1 { get => Duree; set => Duree = value; }
    }

    
}
