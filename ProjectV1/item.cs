using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectV1.model;

namespace ProjectV1
{
    public partial class item : UserControl
    {
        article_model data;
        public item(article_model data)
        {
            InitializeComponent();
            this.data = data;
        }

       
        private void item_Load(object sender, EventArgs e)
        {
            label1.Text = ""+data.Id;
            label2.Text = "" + data.Id;
            label3.Text = "" + data.Nom;
            label4.Text = "" + data.Date_entre;
            label5.Text = "" + data.Prix;
            label6.Text = "" + data.Quontitier1;
            label7.Text = "" + data.Code_fabrication;
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
