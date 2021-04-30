using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;
using ProjectV1.model;
using ProjectV1.sql;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;

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
            pictureBox1.Image = byteToImage(item.Img);
            
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
            
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@ArticleId", SqlDbType.Int);
            param[0].Value = item.Id;

            param[1] = new SqlParameter("@Quontitier", SqlDbType.Int);
            param[1].Value = int.Parse(quantitie.Text);

            param[2] = new SqlParameter("@date_sortie", SqlDbType.Date);
            param[2].Value = gunaDateTimePicker1.Value.ToString();

            param[3] = new SqlParameter("@matricul", SqlDbType.VarChar, 40);
            param[3].Value = matricule.Text.ToString();

           
            param[4] = new SqlParameter("@ClientId", SqlDbType.Int);
            param[4].Value = int.Parse(ClientId.Text);

            param[5] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[5].Value = int.Parse(quantitie.Text);
                         e.Result = sqlConnection.ExuteCommende("r_Artical_Sortee", param);
 
         
            

        }

        private void Sortee_aysnc_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (((int)e.Result) == -1)
            {
                MessageBox.Show("erreur, veuillez réessayer,\nveuillez vous assurer que vous avez inséré un identifiant ou une matricule client valide");
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
        private Bitmap byteToImage(byte[] data)
        {
            MemoryStream stream = new MemoryStream();
            stream.Write(data, 0, Convert.ToInt32(data.Length));

            Bitmap btmp = new Bitmap(stream ,false);
            stream.Dispose();
            return btmp;
        }

        private void matricule_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
