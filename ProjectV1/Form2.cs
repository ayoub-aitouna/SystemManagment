using ProjectV1.model;
using ProjectV1.sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace ProjectV1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata()
        {
            sqlcn SqlConnection = new sqlcn();
         List<article_model> data = SqlConnection.View("select * from Artical"); 
            for (int i = 0; i < data.Count; i++)
            {
                item a = new item(data[i]);
                a.Anchor = AnchorStyles.None;
                adapter.Controls.Add(a);
            }
            this.adapter.AutoSize = true;
           
            this.adapter.AutoScroll = false;
            this.adapter.AutoScroll = true;
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
        private void getData_FromDabase()
        {

        }

        private void adapter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
