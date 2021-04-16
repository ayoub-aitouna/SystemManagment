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
        int NumberOfDialogs;
        public details_Sortee(article_model item,Icloseall closeAll,int NumberOfDialogs)
        {
            InitializeComponent();
            this.item = item;
            this.closeAll = closeAll;
            this.NumberOfDialogs = NumberOfDialogs;
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
            if (NumberOfDialogs == 1)
            {
                CancelAll.Hide();
            }

        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            closeAll.close(-1);
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {

            add_success added_dialog = new add_success(item);
            added_dialog.BackColor = Color.FromArgb(250, 250, 250);
            added_dialog.StartPosition = FormStartPosition.CenterScreen;

            added_dialog.ShowDialog();

        }
    }
}
