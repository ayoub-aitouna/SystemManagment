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
using ProjectV1.sql;
using System.Data.SqlClient;
using Guna.UI.WinForms;
using System.Diagnostics;

namespace ProjectV1
{
    public partial class fourni : UserControl
    {
        sql.sqlcn remplire = new sql.sqlcn();
        public Units.Unit units = new Units.Unit();
        private const int MOde_entree = 200;
        private const int Mode_search = 300;
        public fourni()
        {
            InitializeComponent();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
         

        }

        private void Entree_Click(object sender, EventArgs e)
        {
            hideAll(ajoute);
            units.mode(Units.Unit.MOde_entree1, btn_ajoute, new EventHandler(this.gunaGradientButton1_Click_1), new EventHandler(this.search_event));

        }

        private void ajoute_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fourni_Load(object sender, EventArgs e)
        {
            progresbar.Hide();
            units.StyleDatagridview(view_data,1);
            hideAll(ajoute);

        }
        private void hideAll(Control control)
        {


            foreach (var item in continer.Controls)
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
       
        void ClearEvents(Control c, List<EventHandler> events)
        {
            foreach (var item in events)
            {
               

                c.Click -= item;
            }
        }
        private void search_event(object sender, EventArgs e)
        {
           
            hideAll(panel_view);
            if (!back_fourniseur_view.IsBusy)
            {
                back_fourniseur_view.RunWorkerAsync("SELECT * from Fourniseur where code like '" + code_fourniseur.Text + "'");
            }
          

        }
  
        private void gunaGradientButton1_Click_1(object sender, EventArgs e)
        {
            progresbar.Show();
            
             fourniseur_model item = new fourniseur_model();
            item.Code_fourniseur = int.Parse(code_fourniseur.Text);
            item.Nom = nom.Text;
            item.Adress = adress_fourniseur.Text;
            item.Numerophone = numero_fourniseur.Text;
            item.Email = email_fourniseur.Text;
            item.Fax = fax.Text;

            if (!back_forniseur__add.IsBusy)
            {
                back_forniseur__add.RunWorkerAsync(item);
            }

        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {

        }

        private void back_forniseur__add_DoWork(object sender, DoWorkEventArgs e)
        {


            model.fourniseur_model item = (model.fourniseur_model)e.Argument;
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@code", SqlDbType.Int);
            param[0].Value = item.Code_fourniseur;

            param[1] = new SqlParameter("@nom", SqlDbType.VarChar, 40);
            param[1].Value = item.Nom;

            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 40);
            param[2].Value = item.Numerophone;


            param[3] = new SqlParameter("@adress", SqlDbType.VarChar, 40);
            param[3].Value = item.Adress;

            param[4] = new SqlParameter("@Email", SqlDbType.VarChar, 40);
            param[4].Value = item.Email;
            param[5] = new SqlParameter("@fax", SqlDbType.VarChar, 40);
            param[5].Value = item.Fax;

            remplire.openconx();

            int i = remplire.ExuteCommende("r_Fourniseur", param);

            remplire.closecnx();

            List<object> parameters = new List<object>();
            parameters.Add(i);
            parameters.Add(item);
            e.Result = parameters;
        }
        private void setview_data(List<fourniseur_model> data)
        {

            view_data.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(12, 66, 132);
            view_data.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            view_data.DataSource = data;
            view_data.Columns["Ref"].Visible = false;

        }
        private void back_forniseur__add_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            progresbar.Hide();
            List<object> parameters = e.Result as List<object>;
            int i = int.Parse(parameters[0].ToString());
            fourniseur_model item = (fourniseur_model)parameters[1];

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

        private void back_fourniseur_view_DoWork(object sender, DoWorkEventArgs e)
        {
            sqlcn SqlConnection = new sqlcn();
            e.Result = SqlConnection.Viewfourniseur(e.Argument.ToString());
        }

        private void back_fourniseur_view_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            List<fourniseur_model> q = (List<fourniseur_model>)e.Result;

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
            if (!back_fourniseur_view.IsBusy)
            {
                back_fourniseur_view.RunWorkerAsync("SELECT * from Fourniseur");
            }
        }

        private void view_data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            progresbar.Show();
            DataGridViewCellCollection a = view_data.Rows[e.RowIndex].Cells;

            MessageBox.Show(a[0].Value.ToString());
            fourniseur_model model = new fourniseur_model();
            model.Ref = int.Parse(a[0].Value.ToString());
            model.Code_fourniseur = int.Parse(a[1].Value.ToString());
            model.Nom = a[2].Value.ToString();
            model.Email = a[3].Value.ToString();
            model.Adress = a[4].Value.ToString();
            model.Numerophone = a[5].Value.ToString();
            model.Fax = a[6].Value.ToString();
            if (!update.IsBusy)
            {
                update.RunWorkerAsync(model);
            }
        }

        private void update_DoWork(object sender, DoWorkEventArgs e)
        {
            fourniseur_model model = ((fourniseur_model)e.Argument);
            sqlcn sql = new sqlcn();
            MessageBox.Show(model.ToString());
            sql.update(model);
            e.Result = model;
        }

        private void update_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progresbar.Hide();
            fourniseur_model model = ((fourniseur_model)e.Result);
            add_success add_Success = new add_success(model);
            add_Success.ShowDialog();
        }

        private void gunaGradientButton1_Click_2(object sender, EventArgs e)
        {

            hideAll(ajoute);
            units.mode(Units.Unit.Mode_search1, btn_ajoute, new EventHandler(this.gunaGradientButton1_Click_1), new EventHandler(this.search_event));
        }
    }
}
