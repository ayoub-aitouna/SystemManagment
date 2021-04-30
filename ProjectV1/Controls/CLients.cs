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
using System.Data.SqlClient;
using ProjectV1.sql;

namespace ProjectV1.Controls
{
    public partial class CLients : UserControl
    {
        sql.sqlcn remplire = new sql.sqlcn();
        Units.Unit units = new Units.Unit();
        public CLients()
        {
            InitializeComponent();
        }
        private void CLients_Load(object sender, EventArgs e)
        {
            progresbar.Hide();
          
            units.StyleDatagridview(view_data,1);
            hideAll(ajoute);
        }
        private void hideAll(Control control)
        {


            foreach (var item in continaire.Controls)
            {

                Control a = (Control)item;

                if (control != null && (a == control))
                {

                    a.Show();

                }
                else
                {
                    a.Hide();
                }

            }
        }

      

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            progresbar.Show();
            model_client item = new model_client();
            item.Code_client = int.Parse(code_client.Text);
            item.Nom_client = nom.Text;
            item.Adress_client = adress_client.Text;
            item.Numerophone_client = numero_client.Text;
            item.Email_client = email_client.Text;
            item.Fax = faxclient.Text;

            if (!background_ajoute.IsBusy)
            {
                background_ajoute.RunWorkerAsync(item);
            }
        }
     
      
        private void background_ajoute_DoWork(object sender, DoWorkEventArgs e)
        {
            model.model_client item = (model.model_client)e.Argument;
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@code", SqlDbType.Int);
            param[0].Value = item.Code_client;

            param[1] = new SqlParameter("@nom", SqlDbType.VarChar, 40);
            param[1].Value = item.Nom_client;

            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 40);
            param[2].Value = item.Numerophone_client;


            param[3] = new SqlParameter("@adress", SqlDbType.VarChar, 40);
            param[3].Value = item.Adress_client;

            param[4] = new SqlParameter("@Email", SqlDbType.VarChar, 40);
            param[4].Value = item.Email_client;

            param[5] = new SqlParameter("@fax", SqlDbType.VarChar, 40);
            param[5].Value = item.Fax;

            remplire.openconx();

            int i = remplire.ExuteCommende("r_client", param);

            remplire.closecnx();

            List<object> parameters = new List<object>();
            parameters.Add(i);
            parameters.Add(item);
            e.Result = parameters;
        }

        private void background_ajoute_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progresbar.Hide();
            List<object> parameters = e.Result as List<object>;
            int i = int.Parse(parameters[0].ToString());
            model_client item = (model_client)parameters[1];

            if (i == -1)
            {
                MessageBox.Show("errure d'ajouter");
            }
            else
            {
              
                units.Controls_clear(ajoute);
                add_success add_Success = new add_success(item);
                add_Success.ShowDialog();
            }
        }

        private void background_view_DoWork(object sender, DoWorkEventArgs e)
        {
            sqlcn SqlConnection = new sqlcn();
            e.Result = SqlConnection.ViewClient(e.Argument.ToString());
        }
        private void setview_data(List<model_client> data)
        {

            view_data.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(12, 66, 132);
            view_data.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            

            view_data.DataSource = data;
            view_data.Columns["Ref"].Visible = false;

        }
        private void background_view_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<model_client> q = (List<model_client>)e.Result;
            progresbar.Hide();
            view_data.Enabled = true;
            units.Controls_clear(ajoute);
            setview_data(q);
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            hideAll(panel_view);
            view_data.Enabled = false;
            progresbar.Show();
            if (!background_view.IsBusy)
            {
                background_view.RunWorkerAsync("SELECT * from Client");
            }
        }
        private void search_event(object sender, EventArgs e)
        {
            view_data.Enabled = false;
            progresbar.Show();
            if (!background_view.IsBusy)
            {

                background_view.RunWorkerAsync("select * from Client where code like '" + code_client.Text + "'");
            }
            hideAll(panel_view);
        }
        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            hideAll(ajoute);
            units.mode(Units.Unit.Mode_search1, btn_ajoute, new EventHandler(this.gunaGradientButton1_Click), new EventHandler(this.search_event));

        }

        private void ajoute_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Entree_Click(object sender, EventArgs e)
        {
           hideAll(ajoute);              
           units.mode(Units.Unit.MOde_entree1, btn_ajoute,new EventHandler(this.gunaGradientButton1_Click),new EventHandler(this.search_event));
        }

        private void update_DoWork(object sender, DoWorkEventArgs e)
        {
            model_client model = ((model_client)e.Argument);
            sqlcn sql = new sqlcn();
            sql.update(model);
            e.Result = model;
        }

        private void update_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progresbar.Hide();
            model_client model = ((model_client)e.Result);
            add_success add_Success = new add_success(model);
            add_Success.ShowDialog();
        }

        private void view_data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            progresbar.Show();
            DataGridViewCellCollection a = view_data.Rows[e.RowIndex].Cells;

            string value = a[2].Value.ToString();
            
            model_client model = new model_client();
            model.Ref = int.Parse(a[0].Value.ToString());
            model.Code_client = int.Parse(a[1].Value.ToString());
            model.Nom_client = a[2].Value.ToString();
            model.Email_client = a[3].Value.ToString();
            model.Adress_client = a[4].Value.ToString();
            model.Numerophone_client = a[5].Value.ToString();
            model.Fax = a[6].Value.ToString();
            if (!update.IsBusy)
            {
                update.RunWorkerAsync(model);
            }
        }

    
    }
}
