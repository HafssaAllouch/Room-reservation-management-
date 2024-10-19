using SalleReservation.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalleReservation
{


    public partial class Form2 : Form
    {
        user modelU = new user();
        private bool passwordVisible = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void seConnecterBtn_Click(object sender, EventArgs e)
        {
        try
        {
            modelU.nom = nom.Text;
            modelU.prenom = prenom.Text;
            modelU.numero = long.Parse(num.Text);
            modelU.email = email.Text;
            modelU.password = password.Text;
            using (ReserveSalleEntities cnx = new ReserveSalleEntities())
            {
                cnx.user.Add(modelU);
                cnx.SaveChanges();

            }
            // If the code reaches here, registration was successful
            MessageBox.Show("Registration complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

            // Créer une instance du formulaire d'inscription
            Form3 ConForm = new Form3();
            ConForm.StartPosition = FormStartPosition.CenterScreen;

            // Afficher le formulaire d'inscription
            ConForm.Show();
            }
        catch (Exception ex)
        {
            // If an error occurs during registration, show an error message
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


           
        }

        private void afficherPassword()
        {
            // Inverser l'état de visibilité du mot de passe
            passwordVisible = !passwordVisible;

            // Si le mot de passe doit être visible, afficher le mot de passe en clair
            // Sinon, masquer le mot de passe
            password.PasswordChar = passwordVisible ? '\0' : '*';

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bPrev_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form = new Form3();
            form.Show();
        }
    }
}
