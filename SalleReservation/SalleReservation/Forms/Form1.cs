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
    public partial class Form1 : Form
    {
       public static DateTime now = DateTime.Now;
       public static int year = now.Year;
       public static int month = now.Month;
        private user currentUser;
       // int month, year;
        public Form1(user u)
        {
            InitializeComponent();
            this.currentUser = u;
            label2.Text = currentUser.nom + " " + currentUser.prenom;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            


        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 ConForm = new Form3();
            ConForm.StartPosition = FormStartPosition.CenterScreen;

            // Afficher le formulaire d'inscription
            ConForm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
      
            string namemonth = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = namemonth+" "+year;
            //first day of the month
            DateTime currentDate = DateTime.Today;
            DateTime startofthemonth = new DateTime(year, month, 1);
            //count of the days in a month
            int days = DateTime.DaysInMonth(year, month);
            //convert start to int 
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            //creat a blank userControl

            for(int i = 1; i <= dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                //ucblank.Visible = true;
                dayContainer.Controls.Add(ucblank);
            }

            //createUser controls for days :
            for(int i = 1;i<=days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);

                DateTime currentDateOfMonth = new DateTime(year, month, i);
                if (currentDateOfMonth <= currentDate)
                {
                    ucdays.BackColor = Color.Silver;
                    ucdays.Enabled = false;
                }

                dayContainer.Controls.Add(ucdays);
               // dayContainer.Controls.Add(ucdays);
            }

           

        }

       


        private void bPrev_Click(object sender, EventArgs e)
        {
            //clear container
            dayContainer.Controls.Clear();
            //increment month to go to next month;
            if (month != 1)
            {
                month--;
            }
            else
            {
                month = 12;
                year--;
            }
            //month++;

            string namemonth = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = namemonth + " " + year;

            displayDays();


        }

        private void bNext_Click(object sender, EventArgs e)
        {
            
            //clear container
            dayContainer.Controls.Clear();
            //increment month to go to next month;
            if (month != 12)
            {
                month++;
            }
            else
            {
                month = 1;
                year++;
            }

            string namemonth = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = namemonth + " " + year;
    
            displayDays();

        }

        private void dayContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            DateTime selectedDate = dateTimePicker1.Value;

            // Mettre à jour le mois et l'année actuels avec la date sélectionnée
            month = selectedDate.Month;
            year = selectedDate.Year;

            // Mettre à jour l'affichage des jours
            displayDays();
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ConsulterSalleM ConForm = new ConsulterSalleM();
            ConForm.StartPosition = FormStartPosition.CenterScreen;

            // Afficher le formulaire d'inscription
            ConForm.Show();
        }
    }
}
