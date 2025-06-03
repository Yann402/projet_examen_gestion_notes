using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GestionNotesExamesApp
{
    public class Authentification
    {
        private static string filePath = "users.csv"; // Chemin du fichier

        // Lire les utilisateurs depuis le fichier CSV
        public static List<Utilisateur> LireUtilisateurs()
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>();

            if (!File.Exists(filePath))
            {
                // Optionnel : créer le fichier avec l'en-tête si nécessaire
                MessageBox.Show("Fichier users.csv non trouvé. Création du fichier.");
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    writer.WriteLine("Id,Username,Password,Role"); // En-tête
                }

                return utilisateurs; // Retourne liste vide (aucun utilisateur pour l’instant)
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool firstLine = true;
                while ((line = reader.ReadLine()) != null)
                {
                    if (firstLine) // Ignore l'en-tête
                    {
                        firstLine = false;
                        continue;
                    }

                    string[] data = line.Split(',');

                    if (data.Length < 4)
                        continue;

                    if (int.TryParse(data[0], out int id))
                    {
                        Utilisateur user = new Utilisateur(id, data[1], data[2], data[3]);
                        utilisateurs.Add(user);
                    }
                    else
                    {
                        MessageBox.Show($"Erreur : L’ID '{data[0]}' n'est pas un nombre valide.");
                    }
                }
            }

            return utilisateurs;
        }

        // Vérifier la connexion de l'utilisateur
        public static Utilisateur VerifierLogin(string username, string password)
        {
            List<Utilisateur> utilisateurs = LireUtilisateurs();

            return utilisateurs.FirstOrDefault(user => user.Username == username && user.Password == password);
        }

        // Ajouter un nouvel utilisateur au fichier CSV
        public static void AjouterUtilisateur(Utilisateur user)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true)) // "true" pour ajouter sans écraser
            {
                writer.WriteLine(user.ToString());
            }
        }
        public static int GenerateNewUserId(string role)
        {
            List<Utilisateur> utilisateurs = LireUtilisateurs();

            int idMin, idMax;

            switch (role.ToLower()) // Définition des plages d'ID
            {
                case "admin":
                    idMin = 1; idMax = 99;
                    break;
                case "teacher":
                    idMin = 100; idMax = 199;
                    break;
                case "student":
                    idMin = 200; idMax = 299;
                    break;
                default:
                    throw new Exception("Rôle inconnu !");
            }

            // Trouver le plus grand ID dans la plage définie
            int maxId = utilisateurs.Where(u => u.Id >= idMin && u.Id <= idMax)
                                    .Select(u => u.Id)
                                    .DefaultIfEmpty(idMin - 1) // Si aucun utilisateur, commence au min
                                    .Max();

            return maxId + 1; // Nouvel ID dans la bonne plage
        }
        public static void SauvegarderUtilisateurs(List<Utilisateur> utilisateurs)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false)) // "false" pour écraser le fichier
            {
                foreach (var user in utilisateurs)
                {
                    writer.WriteLine(user.ToString());
                }
            }
        }
    }
}
