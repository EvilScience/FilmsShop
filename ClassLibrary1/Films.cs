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
        private string titre;
        private string realisateur;
        private DateTime dateDeSortie;
        private string resume;
        private string genre;
        private int duree;

        public Films()
        {
        }

        public Films(string titre, string realisateur, DateTime dateDeSortie, string resume, string genre, int duree)
        {
            this.Titre = titre;
            this.Realisateur = realisateur;
            this.DateDeSortie = dateDeSortie;
            this.Resume = resume;
            this.Genre = genre;
            this.Duree = duree;
        }

        public string Titre { get => titre; set => titre = value; }
        public string Realisateur { get => realisateur; set => realisateur = value; }
        public DateTime DateDeSortie { get => dateDeSortie; set => dateDeSortie = value; }
        public string Resume { get => resume; set => resume = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Duree { get => duree; set => duree = value; }
    }
}
