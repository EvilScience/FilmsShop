using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmShopLibrary
{
    public class Personnes
    {
        private int id;
        private string nom;
        private string prenom;
        private DateTime dateDeNaissance;
        private string adresse;
        private string ville;
        private int codePostal;
        private int taille;
        private int poids;
        private int age;

        public Personnes()
        {
        }

        public Personnes(int id, string nom, string prenom, DateTime dateDeNaissance, string adresse, 
            string ville, int codePostal, int taille, int poids, int age)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.dateDeNaissance = dateDeNaissance;
            this.adresse = adresse;
            this.ville = ville;
            this.codePostal = codePostal;
            this.taille = taille;
            this.poids = poids;
            this.age = age;
        }



        static void SePresenter(Personnes personne)
        {
            Console.WriteLine("Bonjour je m'appelle " + personne.Prenom + personne.Nom + "." + " J'ai " + personne.age + 
               " J'habite a " + personne.Ville);
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateDeNaissance { get => dateDeNaissance; set => dateDeNaissance = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Ville { get => ville; set => ville = value; }
        public int CodePostal { get => codePostal; set => codePostal = value; }
        public int Taille { get => taille; set => taille = value; }
        public int Poids { get => poids; set => poids = value; }
    }
}
