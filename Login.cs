using System;
using System.Windows.Forms;

namespace GestionNotesExamesApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Utilisateur user = Authentification.VerifierLogin(username, password);

            if (user != null)
            {
                MessageBox.Show($"Bienvenue, {user.Role} !", "Connexion réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirection selon le rôle
                if (user.Role == "admin")
                {
                    new AdminForm().Show();
                }
                else if (user.Role == "teacher")
                {
                    new TeacherForm().Show();
                }
                else if (user.Role == "student")
                {
                    new StudentForm().Show();
                }

                this.Hide(); // Fermer le formulaire de connexion
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect !", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
