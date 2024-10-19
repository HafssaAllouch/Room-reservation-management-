using SalleReservation.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalleReservation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form3 form = new Form3();
            
            //Form1 form = new Form1(new user());
            form.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(form);
        }
    }
}
