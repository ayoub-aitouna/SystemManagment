using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectV1.model;

namespace ProjectV1.dialog
{
    public partial class details_Sortee : Form
    {
        article_model item;
        Icloseall closeAll;
        public details_Sortee(article_model item,Icloseall closeAll)
        {
            InitializeComponent();
            this.item = item;
            this.closeAll = closeAll;
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void details_Sortee_Load(object sender, EventArgs e)
        {
            id.Text = item.Id.ToString();
            barcode.Text = item.Barcode1;
            prix.Text = item.Prix.ToString();
            desination.Text = item.Nom;
            description_inter.Text = item.Description_inter;
            descroption_fabrication.Text = item.Descroption_fabrication;
            codeean.Text = item.Code_fabrication;
            date.Text = item.Date_entre.ToShortDateString();

        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            closeAll.close(-1);
        }
    }
}
