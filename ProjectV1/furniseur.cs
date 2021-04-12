using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace ProjectV1
{
    public partial class furniseur : UserControl
    {
        sql.sqlcn remplire = new sql.sqlcn();
        public furniseur()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {

            SqlParameter[] param = new SqlParameter[9];
            param[1] = new SqlParameter("@nom", SqlDbType.VarChar, 40);
            param[1].Value = nom_fourniseur.Text;

            param[2] = new SqlParameter("@phone", SqlDbType.Int);
            param[2].Value = int.Parse( phone.Text);

            param[3] = new SqlParameter("@adress", SqlDbType.VarChar, 40);
            param[3].Value = adress.Text;

            param[4] = new SqlParameter("@Email", SqlDbType.VarChar, 40);
            param[4].Value = e_mail.Text;

            param[5] = new SqlParameter("@website", SqlDbType.VarChar, 40);
            param[5].Value = website.Text;

           


            remplire.openconx();
            remplire.ExuteCommende("r_Fourniseur", param);
            remplire.closecnx();
        }
    }
}
