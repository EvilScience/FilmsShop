using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    class DataAccess
    {
        public static string SqlConnectionString = @"Server=.\SQLExpress;Database=FilmsShop;Trusted_Connection=Yes";
        public static void AddFilms(Films film)
        {
            SqlConnection Connection = new SqlConnection(SqlConnectionString);
            Connection.Open();
            SqlCommand FirstInsert =
                 new SqlCommand("INSERT INTO Films (Titre_F, Realisateur_F, DateDeSortie_F , Resume_F , Genre_F , Duree_F) " +
                 "VALUES (@Titre,@Realisateur,@DateDeSortie,@Resume,@Genre,@Duree)", Connection);

            FirstInsert.Parameters.AddWithValue("@Titre", film.Titre);
            FirstInsert.Parameters.AddWithValue("@Realisateur", film.Realisateur);
            FirstInsert.Parameters.AddWithValue("@DateDeSortie", film.DateDeSortie);
            FirstInsert.Parameters.AddWithValue("@Resume", film.Resume);
            FirstInsert.Parameters.AddWithValue("@Genre", film.Genre);
            FirstInsert.Parameters.AddWithValue("@Duree",film.Duree);
            FirstInsert.ExecuteNonQuery();
            Connection.Close();
        }


        private static void AddPersonnes(Personnes personne)
        {
            SqlConnection Connection = new SqlConnection(SqlConnectionString);
            Connection.Open();
            SqlCommand FirstInsert =
                 new SqlCommand("INSERT INTO Personnes (Nom_F, Prenom_F, DateDeNaissance_F , Adresse_F , Ville_F , " +
                 "CodePostal_F , Taille_P , Poids_P, Age_P) " +
                 "VALUES (@Nom,@Prenom,@DateDeNaissance,@Adresse,@Ville,@CodePostal,@Taille,@Poids)", Connection);

            FirstInsert.Parameters.AddWithValue("@Nom", personne.Nom);
            FirstInsert.Parameters.AddWithValue("@Prenom", personne.Prenom);
            FirstInsert.Parameters.AddWithValue("@DateDeNaissance", personne.DateDeNaissance);
            FirstInsert.Parameters.AddWithValue("@Adresse", personne.Adresse);
            FirstInsert.Parameters.AddWithValue("@Ville", personne.Ville);
            FirstInsert.Parameters.AddWithValue("@CodePostal", personne.CodePostal);
            FirstInsert.Parameters.AddWithValue("@Taille", personne.Taille);
            FirstInsert.Parameters.AddWithValue("@Poids", personne.Poids);
            FirstInsert.ExecuteNonQuery();
            Connection.Close();
        }
    }
}
