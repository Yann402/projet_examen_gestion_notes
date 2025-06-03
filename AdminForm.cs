using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GestionNotesExamesApp.Authentification;

namespace GestionNotesExamesApp
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void LoadUsers()
        {
            List<Utilisateur> utilisateurs = Authentification.LireUtilisateurs();

            MessageBox.Show($"Nombre d'utilisateurs chargés : {utilisateurs.Count}"); // Vérification

            dgvUsers.DataSource = null;
            dgvUsers.DataSource = utilisateurs; // Mise à jour du tableau
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            MessageBox.Show("Chargement des utilisateurs !");

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            int id = Authentification.GenerateNewUserId(txtRole.Text); // Fonction pour trouver un nouvel ID
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = txtRole.Text;

            Utilisateur newUser = new Utilisateur(id, username, password, role);
            Authentification.AjouterUtilisateur(newUser);

            MessageBox.Show("Utilisateur ajouté avec succès !");
            LoadUsers(); // Rafraîchir la liste
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>();

            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                if (row.Cells[0].Value != null) // Vérifier si la ligne n'est pas vide
                {
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    string username = row.Cells[1].Value.ToString();
                    string password = row.Cells[2].Value.ToString();
                    string role = row.Cells[3].Value.ToString();

                    utilisateurs.Add(new Utilisateur(id, username, password, role));
                }
            }

            Authentification.SauvegarderUtilisateurs(utilisateurs);
            MessageBox.Show("Modifications enregistrées avec succès !");
            LoadUsers();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                if (int.TryParse(dgvUsers.SelectedRows[0].Cells[0].Value?.ToString(), out int selectedId))
                {
                    List<Utilisateur> utilisateurs = Authentification.LireUtilisateurs();
                    utilisateurs = utilisateurs.Where(u => u.Id != selectedId).ToList();

                    Authentification.SauvegarderUtilisateurs(utilisateurs);
                    MessageBox.Show("Utilisateur supprimé avec succès !");
                    LoadUsers();
                }
            }
        }
    }
}
