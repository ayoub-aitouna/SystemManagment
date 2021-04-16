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
using ProjectV1.sql;
using System.Data;
using System.Data.SqlClient;

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

            if ((!Sortee_aysnc.IsBusy) && quantitie.Text != "")
            {
                if (item.Quontitier1 < int.Parse(quantitie.Text))
                {
                    MessageBox.Show("la quantité maximale possible est : "+item.Quontitier1);
                    quantitie.Text = item.Quontitier1.ToString();
                }
                else
                {
                    Sortee_aysnc.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("erreur, veuillez réessayer");
            }
        }

        private void Sortee_aysnc_DoWork(object sender, DoWorkEventArgs e)
        {
            sqlcn sqlConnection = new sqlcn();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@barcode", SqlDbType.VarChar, 40);
            param[0].Value = item.Barcode1;

            param[1] = new SqlParameter("@nom", SqlDbType.VarChar, 40);
            param[1].Value = item.Nom;

            param[2] = new SqlParameter("@description_inter", SqlDbType.VarChar, 40);
            param[2].Value = item.Description_inter;

            param[3] = new SqlParameter("@descroption_fabrication", SqlDbType.VarChar, 40);
            param[3].Value = item.Descroption_fabrication;

            param[4] = new SqlParameter("@code_fabrication", SqlDbType.Int);
            param[4].Value = int.Parse(item.Code_fabrication);

            param[5] = new SqlParameter("@prix", SqlDbType.Int);
            param[5].Value = item.Prix;

            param[6] = new SqlParameter("@Quontitier", SqlDbType.Int);
            param[6].Value = int.Parse(quantitie.Text);

            param[7] = new SqlParameter("@date_sortee", SqlDbType.Date);
            param[7].Value = item.Date_entre;

            param[8] = new SqlParameter("@img", SqlDbType.Image);
            param[8].Value = item.Img;

           e.Result = sqlConnection.ExuteCommende("r_Artical_Sortee",param);

        }

        private void Sortee_aysnc_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (((int)e.Result) == -1)
            {
                MessageBox.Show("erreur, veuillez réessayer");
            }
            else {

                add_success added_dialog = new add_success(item);
                added_dialog.BackColor = Color.FromArgb(250, 250, 250);
                added_dialog.StartPosition = FormStartPosition.CenterScreen;
                added_dialog.ShowDialog();
            }
        
        }

        private void quantitie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

           
        }
    }
}
