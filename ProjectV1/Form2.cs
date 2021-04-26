using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectV1.model;
using ProjectV1.Encrypting;

namespace ProjectV1.Units
{
    public partial class Form2 : Form
    {
       public bool UserSuccessfullyAuthenticated { get; private set; }

        sql.sqlcn remplire = new sql.sqlcn();
        Hash hash = new Hash();
        loginclasse itm = new loginclasse();
        public Form2()
        {
            InitializeComponent();


        }

        private void btn_ajoute_Click(object sender, EventArgs e)
        {
            itm.User = username.Text;
            itm.Pasword =  hash.Hashing(pasword.Text);

            progresbar.Show();
            if (!backlogin.IsBusy)
            {
                backlogin.RunWorkerAsync();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backlogin_DoWork(object sender, DoWorkEventArgs e)
        {

            SqlParameter[] param = new SqlParameter[2];
            remplire.openconx();
            param[0] = new SqlParameter("@user_nm", SqlDbType.VarChar, 40);
            param[0].Value = itm.User;

            param[1] = new SqlParameter("@passwrd", SqlDbType.VarChar, 40);
            param[1].Value = itm.Pasword;

            DataTable  dt = remplire.Selectdata("f_logine", param);
            remplire.closecnx();
            e.Result = dt;

        }

        private void login_Load(object sender, EventArgs e)
        {
            progresbar.Hide();
        }

        private void backlogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DataTable dt = (DataTable)e.Result;
            if (dt.Rows.Count > 0)
            {

                //MessageBox.Show("bien venu");
                //Form1 f = new Form1(this);
                //f.Show();
                ////this.Close();
                if (remamber.Checked)
                {

                }
                UserSuccessfullyAuthenticated = true;

                Close();
             
            }
            else
            {
                MessageBox.Show("erroe");
                progresbar.Hide();
            }
           
        }
    }
}
