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

namespace ProjectV1
{
    public partial class equipe : UserControl
    {
        sql.sqlcn remplire = new sql.sqlcn();
        public equipe()
        {
            InitializeComponent();
        }

        private void progresbar_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            model.equipement_model item = new model.equipement_model();
            item.CODE = int.Parse(code_equipemnt.Text);
            item.Nom_equipment = nom_equipe.Text;
            item.Matrucil = matricule_equipe.Text;

        }

        private void add_Paint(object sender, PaintEventArgs e)
        {

        }

        private void equipe_Load(object sender, EventArgs e)
        {
            progresbar.Visible = false;
        }

        private void working_back_DoWork(object sender, DoWorkEventArgs e)
        {
            model.equipement_model item = (model.equipement_model) e.Argument;
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@nom", SqlDbType.VarChar, 40);
            param[0].Value = item.Nom_equipment;

            param[1] = new SqlParameter("@matricul", SqlDbType.VarChar, 40);
            param[1].Value = item.Matrucil;

            param[2] = new SqlParameter("@code", SqlDbType.Int);
            param[2].Value = item.CODE;

            remplire.openconx();
            
            int i = remplire.ExuteCommende("r_equipement", param);

            remplire.closecnx();

            List<object> parameters = new List<object>();
            parameters.Add(i);
            parameters.Add(item);
            e.Result = parameters;

        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {

            
        }
    }
}
