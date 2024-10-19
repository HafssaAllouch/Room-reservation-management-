using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalleReservation.Forms
{
    public partial class Form3 : Form
    {
        public static user userApp;
        String email;
        String pass;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void seConnecterBtn_Click(object sender, EventArgs e)
        {

            email = emailTf.Text;
            pass = passTf.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
            {
                // If either email or password is empty, display an error message
                MessageBox.Show("Email and password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Proceed with further actions since both email and password are not empty
                // Your code for processing the email and password goes here
                using (ReserveSalleEntities cnx = new ReserveSalleEntities())
                {
                    userApp = cnx.user.FirstOrDefault(u => u.email == email && u.password == pass);

                    if (userApp != null)
                    {
                        // User with provided email and password exists in the database
                       // MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Proceed with further actions such as opening a new form or performing other tasks
                        this.Hide();

                        // Créer une instance du accueil
                        Form1 AccForm = new Form1(userApp);
                        

                        // Afficher le formulaire d'inscription
                        AccForm.Show();
                    }
                    else
                    {
                        // No user found with the provided email and password
                        MessageBox.Show("Invalid email or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            
        }

        private void InscrireBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

           


            this.Hide();

            // Créer une instance du formulaire d'inscription
            Form2 inscriptionForm = new Form2();
            inscriptionForm.StartPosition = FormStartPosition.CenterScreen;

            // Afficher le formulaire d'inscription
            inscriptionForm.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
