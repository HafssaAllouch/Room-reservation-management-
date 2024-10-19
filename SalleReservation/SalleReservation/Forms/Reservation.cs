using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalleReservation.Forms
{
    public partial class Reservation : Form
    {
        
        
        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            dateR.Text = UserControlDays.static_day + "/" + Form1.month + "/" + Form1.year;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        String salle;
        private void seConnecterBtn_Click(object sender, EventArgs e)
        {
            reservation modelR = new reservation();
            
            try
            {
                if (dateR == null || typeR == null || salleR == null)
                {
                    MessageBox.Show("Une référence d'objet n'est pas définie d'objet.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method if any of the references is null
                }

                DateTime dateResrv;
                if (!DateTime.TryParse(dateR.Text, out dateResrv))
                {
                    // Parsing failed
                    MessageBox.Show("Invalid date format. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method or handle the error appropriately
                }

                modelR.dateResrv = DateTime.Parse(dateR.Text);
                modelR.typeReser = typeR.Text;
                modelR.CIN = tfCIN.Text;
                modelR.nom = tfNom.Text;
                modelR.prenom = tfPrenom.Text;
                modelR.email = tfEmail.Text;
                modelR.tele = tfTele.Text;
                modelR.idU = Form3.userApp.id;

                salle = salleR.Text.ToString();
                if (salle == "Grande Salle")
                {
                    modelR.idS = 5;
                }
                else if (salle == "Petite Salle")
                {
                    modelR.idS = 6;
                }
                else if (salle == "Mariage Salle")
                {
                    modelR.idS = 7;
                }

                // Check if there are any existing reservations for the selected salle
                using (ReserveSalleEntities cnx = new ReserveSalleEntities())
                {
                    // Récupérer toutes les réservations pour la date donnée
                    List<reservation> res = cnx.reservation
                             .Where(r => System.Data.Entity.DbFunctions.TruncateTime(r.dateResrv) == modelR.dateResrv)
                             .ToList();
                    Console.WriteLine(res.Count);
                    if (res.Count != 0)
                    {
                        bool salleAlreadyReserved = false;

                        for (int i = 0; i < res.Count; i++)
                        {
                            if (res[i].idS == modelR.idS)
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
                            // ajouter reservation only if salle is not already reserved
                            AddReservation(modelR);
                        }

                    }

                    else
                    {
                        // ajouter  reservation if there are no existing reservations
                        AddReservation(modelR);
                    }
                }
            }
            catch (Exception ex)
            {
                // If an error occurs during registration, show an error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddReservation(reservation modelR)
        {
            try
            {
                using (ReserveSalleEntities cnx = new ReserveSalleEntities())
                {
                    cnx.reservation.Add(modelR);
                    cnx.SaveChanges();
                }

                // If the code reaches here, registration was successful
                sendEmail(modelR,modelR.email);
                MessageBox.Show("Reservation effectuée!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception ex)
            {
                // If an error occurs during registration, show an error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void sendEmail(reservation res,String email)
        {
            string fromMail = "sallebooker@gmail.com";
            string fromPassword = "vpbahwstegsdhwow";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "reservation salle";
            message.To.Add(new MailAddress(email));
            message.Body = "<html><body>  vous avez reserver la salle "+salle+" pour votre "+res.typeReser+"<br>date de reservation : "+res.dateResrv.ToShortDateString()+"</body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }



    }
}
