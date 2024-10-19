using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace SalleReservation.Forms
{

    public partial class UserControlDays : UserControl
    {
        public static List<reservation> rs;
        public static String static_day;
        public UserControlDays()
        {
            
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            displayEvents();
            if (rs != null && rs.Count == 3)
            {
                this.Enabled = false;
            }
            

        }

        public void days(int numday)
        {
            label1.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = label1.Text;
            timer1.Start();
            Reservation reservForm = new Reservation();
            reservForm.StartPosition = FormStartPosition.CenterScreen;
            reservForm.Show();
        }

        //new method to display events :
        private void displayEvents()
        {
            DateTime date = DateTime.Parse(Form1.year + "-" + Form1.month + "-" + label1.Text);

            using (ReserveSalleEntities cnx = new ReserveSalleEntities())
            {
                rs = cnx.reservation
                             .Where(r => DbFunctions.TruncateTime(r.dateResrv) == date.Date)
                             .ToList();

                if (rs.Count > 0)
                {
                    for (int i = 0; i < rs.Count; i++)
                    {
                        // Retrieve salle for each reservation
                        int salleId = rs[i].idS;
                        salle s = cnx.salle.FirstOrDefault(sa => sa.id_s == salleId);

                        if (s != null)
                        {
                            // Create a new label
                            Label label = new Label();
                            label.Text = s.type + "/" + rs[i].typeReser;
                            if (s.id_s == 5)
                            {
                                label.ForeColor = Color.Blue;
                            }
                            else if(s.id_s == 6){
                                label.ForeColor = Color.Red ;
                            }
                            else
                            {
                                label.ForeColor = Color.Green;
                            }
                            label.AutoSize = true;
                            // Position the label dynamically
                            label.Location = new Point(1, 25 + i * 13); // Adjust x, y, yOffset as needed

                            // Add the label to the form's controls
                            this.Controls.Add(label);
                        }
                    }
                }
                else
                    {
                        // Handle case where salle is not found for the reservation.
                        // You may want to log this or display an appropriate message.
                    }
                }
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvents();
            if (rs != null && rs.Count == 3)
            {
                this.Enabled = false;
            }
        }
    }

  
    }



