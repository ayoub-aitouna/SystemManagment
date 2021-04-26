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
using ProjectV1.Encrypting;
using System.Data.SqlClient;
using ProjectV1.Units;


namespace ProjectV1.Controls
{
    public partial class User_Login : UserControl
    {
        private IUserSuccessfullyAuthenticated userSuccessfullyAuthenticated;
        private FileIO fileio = new FileIO();
        private bool Is_Hashed ;
        private bool IsFirstTime = true;



        public User_Login()
        {
            InitializeComponent();
        }

        public bool UserSuccessfullyAuthenticated { get; private set; }

        sql.sqlcn remplire = new sql.sqlcn();
        Hash hash = new Hash();
        loginclasse itm = new loginclasse();
       
        private void btn_ajoute_Click(object sender, EventArgs e)
        {
            itm.User = username.Text;
            if (Is_Hashed)
            {
                itm.Pasword = pasword.Text;
             
            }
            else
            {
                itm.Pasword = hash.Hashing(pasword.Text);
            }
            progresbar.Show();
            if (!backlogin.IsBusy)
            {
                backlogin.RunWorkerAsync();
            }
        }

        public void load(IUserSuccessfullyAuthenticated userSuccessfullyAuthenticated)
        {
            this.userSuccessfullyAuthenticated = userSuccessfullyAuthenticated;
        }

        private void backlogin_DoWork(object sender, DoWorkEventArgs e)
        {

            SqlParameter[] param = new SqlParameter[2];
            remplire.openconx();
            param[0] = new SqlParameter("@user_nm", SqlDbType.VarChar, 40);
            param[0].Value = itm.User;

            param[1] = new SqlParameter("@passwrd", SqlDbType.VarChar, 250);
            param[1].Value = itm.Pasword;

            DataTable dt = remplire.Selectdata("f_logine", param);
            remplire.closecnx();
            e.Result = dt;

        }

    

        private void backlogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progresbar.Hide();
            DataTable dt = (DataTable)e.Result;
            if (dt.Rows.Count > 0)
            {
                if (remamber.Checked)
                {
                    loginclasse user = new loginclasse();
                    user.User = dt.Rows[0][1].ToString();
                    user.Pasword = dt.Rows[0][2].ToString();
                    user.Type = "admin";
                    fileio.writeXml(user);
                   
                }
                userSuccessfullyAuthenticated.UserSuccessfullyAuthenticated();




            }
            else
            {
                MessageBox.Show("votre nom d'utilisateur ou mot de passe sont incorrects\n"+hash.Hashing(pasword.Text));
              
            }

        }

        private void User_Login_Load(object sender, EventArgs e)
        {
            progresbar.Hide();
            pasword.PasswordChar = '*';
           
            loginclasse user = new FileIO().getXmldata();
            if (user != null)
            {
                username.Text = user.User.ToString();
                pasword.Text = user.Pasword.ToString();
                Is_Hashed = true;   
            }
          
            

            


        }

        private void pasword_Enter(object sender, EventArgs e)
        {
            if (IsFirstTime)
            {
                pasword.Text = "";
                Is_Hashed = false;
                IsFirstTime = false;
            }
           
        }
    }
}
