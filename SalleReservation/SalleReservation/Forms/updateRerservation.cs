using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalleReservation.Forms
{
    
    public partial class updateRerservation : Form
    {
        public reservation re;
        public int idSalleOld;
        public updateRerservation(reservation r)
        {

            this.re = r;
            InitializeComponent();
        }

        private void updateRerservation_Load(object sender, EventArgs e)
        {
            idSalleOld =re.idS;
            dateR.Text = re.dateResrv.ToShortDateString();
            typeR.Text = re.typeReser;
            tfCIN.Text = re.CIN;
            tfNom.Text = re.nom;
            tfPrenom.Text = re.prenom;
            tfEmail.Text = re.email;
            tfTele.Text = re.tele;
            if (re.idS == 5)
            {
                salleR.Text = "Grande Salle";
            }
            else if (re.idS == 6 )
            {
                salleR.Text = "Petite Salle";
            }
            else if (re.idS == 7)
            {
                salleR.Text= "Mariage Salle";
            }

        }

        String salle;
        private void seConnecterBtn_Click(object sender, EventArgs e)
        {


            try
            {
                if (dateR == null || typeR == null || salleR == null)
                {
                    MessageBox.Show("les champs obligatoires !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method if any of the references is null
                }

                DateTime dateResrv;
                if (!DateTime.TryParse(dateR.Text, out dateResrv))
                {
                    // Parsing failed
                    MessageBox.Show("Invalid date format. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method or handle the error appropriately
                }

                re.dateResrv = DateTime.Parse(dateR.Text);
                re.typeReser = typeR.Text;
                re.CIN = tfCIN.Text;
                re.nom = tfNom.Text;
                re.prenom = tfPrenom.Text;
                re.email = tfEmail.Text;
                re.tele = tfTele.Text;
                re.idU = Form3.userApp.id;

                salle = salleR.Text;
                if (salle == "Grande Salle")
                {
                    re.idS = 5;
                }
                else if (salle == "Petite Salle")
                {
                    re.idS = 6;
                }
                else if (salle == "Mariage Salle")
                {
                    re.idS = 7;
                }
                

                // Check if there are any existing reservations for the selected salle
                using (ReserveSalleEntities cnx = new ReserveSalleEntities())
                {
                    // Récupérer toutes les réservations pour la date donnée
                    List<reservation> res = cnx.reservation
                             .Where(r => DbFunctions.TruncateTime(r.dateResrv) == re.dateResrv)
                             .ToList();
                    Console.WriteLine(res.Count);
                    if (res.Count != 0)
                    {
                        bool salleAlreadyReserved = false;

                        for (int i = 0; i < res.Count; i++)
                        {
                            if (res[i].idS!=idSalleOld && res[i].idS == re.idS)
                            {
                                salleAlreadyReserved = true;
                                break;
                            }
                        }

                        if (salleAlreadyReserved)
                        {
                            MessageBox.Show("Salle déjà réservée !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // modifier reservation only if salle is not already reserved
                            ModiferReservation(re);
                        }

                    }

                    else
                    {
                        // modifier  reservation if there are no existing reservations
                        ModiferReservation(re);
                    }
                }
            }
            catch (Exception ex)
            {
                // If an error occurs during registration, show an error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void ModiferReservation(reservation re)
        {
            using (ReserveSalleEntities cnx = new ReserveSalleEntities())
            {
                // Récupérer la réservation à partir de la base de données en utilisant son ID
                var reservationToUpdate = cnx.reservation.FirstOrDefault(r => r.id_r == re.id_r);
                if (reservationToUpdate != null)
                {
                    // Mettre à jour les propriétés de la réservation avec les nouvelles valeurs
                    reservationToUpdate.dateResrv = re.dateResrv;
                    reservationToUpdate.typeReser = re.typeReser;
                    reservationToUpdate.CIN = re.CIN;
                    reservationToUpdate.nom = re.nom;
                    reservationToUpdate.prenom = re.prenom;
                    reservationToUpdate.email = re.email;
                    reservationToUpdate.tele = re.tele;
                    reservationToUpdate.idS = re.idS;

                    // Enregistrer les modifications dans la base de données
                    cnx.SaveChanges();

                    // Afficher un message de succès
                    MessageBox.Show("La réservation a été modifiée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La réservation à modifier n'a pas été trouvée dans la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
