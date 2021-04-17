using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
namespace ProjectV1
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
        }

   
        private void panel7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        

        private void Form1_Load(object sender, EventArgs e)
        {
            hideAll(dashboard1, dashboard_button);


        }

        private void hideAll(Control control,Control button)
        {
            

            foreach (var item in MENU.Controls)
            {
                if (item.GetType() == typeof(GunaGradientButton))
                {
                    GunaGradientButton gunabutton = (GunaGradientButton)item;
                    GunaGradientButton targetButton = (GunaGradientButton)button;
                    if (gunabutton == targetButton)
                    {
                        gunabutton.BaseColor1 = Color.FromArgb(218, 233, 252);
                        gunabutton.BaseColor2 = Color.FromArgb(218, 233, 252);

                    }else if(gunabutton.Name== "exite")
                    {

                    }
                    else
                    {
                        gunabutton.BaseColor1 = Color.Transparent;
                        gunabutton.BaseColor2 = Color.Transparent;
                    }
                }
            }

            foreach (var item in homa_container.Controls)
            {

                Control a = (Control)item;
                if (control != null && a == control)
                {

                    a.Show();
                   

                }
                else
                {
                    a.Hide();
                  
                }

            }
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            hideAll(dashboard1,dashboard_button);
        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {

           hideAll(articlee1, article);
            
            
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            hideAll(equipe1,equipment);
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            hideAll(fourni1,forneseur);
        }


        private void users_Click(object sender, EventArgs e)
        {
            hideAll(cLients1, users);
        }

        private void settings_Click(object sender, EventArgs e)
        {

            hideAll(null, settings);
        }
    }
}
