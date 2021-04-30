using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectV1.Controls
{
    public partial class Rapport : UserControl
    {
        public Rapport()
        {
            InitializeComponent();
        }

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            showData(true);
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            showData(true);

        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            showData(true);

        }

        private void showData(bool b)
        {
            if (b)
            {
                data.Show();
                elemets.Hide();
            }
            else
            {
                elemets.Show();
                data.Hide();
            }
        }

        private void Rapport_Load(object sender, EventArgs e)
        {
            showData(false);
        }

        private void retourne_Click(object sender, EventArgs e)
        {
            showData(false);

        }
    }
}
