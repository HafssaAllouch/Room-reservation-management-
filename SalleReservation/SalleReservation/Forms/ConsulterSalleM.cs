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
    public partial class ConsulterSalleM : Form
    {
        public ConsulterSalleM()
        {
            InitializeComponent();
        }

        private void bPrev_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1(Form3.userApp);
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ZoomImgForm form = new ZoomImgForm();
            form.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Img2Zoom form = new Img2Zoom();
            form.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Img3Zoom form = new Img3Zoom();
            form.Show();
        }
    }
}
