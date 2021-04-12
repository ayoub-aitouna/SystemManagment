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
    public partial class equipement : UserControl
    {
        sql.sqlcn remplire = new sql.sqlcn();
        public equipement()
        {
            InitializeComponent();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            SqlParameter[] param = new SqlParameter[9];
            param[1] = new SqlParameter("@nom", SqlDbType.VarChar, 40);
            param[1].Value = nom.Text;

            param[2] = new SqlParameter("@matircile", SqlDbType.Int);
            param[2].Value = r_equipement.Text;

          



            remplire.openconx();
            remplire.ExuteCommende("r_Fourniseur", param);
            remplire.closecnx();
        }
    }
}
