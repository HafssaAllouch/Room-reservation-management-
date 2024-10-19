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
    public partial class Home : Form
    {
        private user currentUser;
        public Home(user u)
        {
            InitializeComponent();
            this.currentUser = u;
            label2.Text = currentUser.nom + " " + currentUser.prenom;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            ConsulterReservation ConForm = new ConsulterReservation();
            ConForm.StartPosition = FormStartPosition.CenterScreen;

            // Afficher le formulaire d'inscription
            ConForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1(Form3.userApp);
            form.Show();
        }
    }
}
