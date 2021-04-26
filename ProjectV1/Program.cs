using ProjectV1.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjectV1.Program;

namespace ProjectV1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
         static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form2 login_form = new Form2();
           // Form1 main_form = new Form1();
            //Application.Run(login_form);
            //if (login_form.UserSuccessfullyAuthenticated)
            //{
                Application.Run(new Form1());
            //}
        }
      
 

      
    }
}
