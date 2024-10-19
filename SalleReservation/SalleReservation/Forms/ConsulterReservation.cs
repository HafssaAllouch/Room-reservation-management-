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
    public partial class ConsulterReservation : Form
    {
        public ConsulterReservation()
        {
            InitializeComponent();
        }

        private void ConsulterReservation_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        void LoadData()
        {
            using (ReserveSalleEntities cnx = new ReserveSalleEntities())
            {
                // Récupérer les réservations pour un utilisateur spécifique avec le type de salle
                var reservationsForUser = cnx.reservation                                   
                                            .Select(r => new
                                            {
                                                r.id_r,
                                                r.dateResrv,
                                                r.CIN,
                                                r.nom,
                                                r.prenom,
                                                r.email,
                                                r.tele,
                                                TypeSalle = r.salle.type,
                                                r.typeReser,
                                                
                                                //r.idU
                                                // Remplacer idS par le type de salle
                                            })
                                            .ToList();
                dgReservation.DataSource = reservationsForUser;
            }
        }
        private void dgReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgReservation.Columns["Delete"].Index && e.RowIndex != -1)
            {
                // Demander la confirmation
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette réservation ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si l'utilisateur a confirmé la suppression
                if (result == DialogResult.Yes)
                {
                    // Récupérer l'ID de la réservation à supprimer
                    int reservationId = (int)dgReservation.Rows[e.RowIndex].Cells["idR"].Value;

                    // Supprimer la réservation correspondante en fonction de son ID
                    using (ReserveSalleEntities cnx = new ReserveSalleEntities())
                    {
                        var reservationToDelete = cnx.reservation.FirstOrDefault(r => r.id_r == reservationId);
                        if (reservationToDelete != null)
                        {
                            cnx.reservation.Remove(reservationToDelete);
                            cnx.SaveChanges();
                        }
                    }

                    // Recharger les données après la suppression
                    LoadData();
                }


            }
            else if (e.ColumnIndex == dgReservation.Columns["Update"].Index && e.RowIndex != -1)
            {
                using (ReserveSalleEntities cnx = new ReserveSalleEntities())
                {
                    int reservationId = (int)dgReservation.Rows[e.RowIndex].Cells["idR"].Value;
                    reservation re = cnx.reservation.FirstOrDefault(r => r.id_r == reservationId);
                    updateRerservation AccForm = new updateRerservation(re);
 
                    //AccForm.ShowDialog();
                    if (AccForm.ShowDialog() == DialogResult.OK)
                    {
                        // Recharger les données après la modification
                        LoadData();
                    }


                }
                LoadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1(Form3.userApp);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String cin = tfCIN.Text;
            if (cin != "")
            {
                using (ReserveSalleEntities cnx = new ReserveSalleEntities())
                {
                    // Récupérer les réservations pour un utilisateur spécifique avec le type de salle
                    var reservationsForUser = cnx.reservation
                                                .Where(r => r.CIN == cin)
                                                .Select(r => new
                                                {
                                                    r.id_r,
                                                    r.dateResrv,
                                                    r.CIN,
                                                    r.nom,
                                                    r.prenom,
                                                    r.email,
                                                    r.tele,
                                                    TypeSalle = r.salle.type,
                                                    r.typeReser,
                                                    
                                                 //   r.idU
                                                // Remplacer idS par le type de salle
                                            })
                                                .ToList();
                    dgReservation.DataSource = reservationsForUser;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}


   


