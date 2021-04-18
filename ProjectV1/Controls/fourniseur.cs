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

namespace ProjectV1
{
    public partial class fourni : UserControl
    {
        sql.sqlcn remplire = new sql.sqlcn();
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

        }

        private void ajoute_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fourni_Load(object sender, EventArgs e)
        {
            progresbar.Hide();
           
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
        private void mode(int _mode_)
        {
            List<EventHandler> events = new List<EventHandler>();

            events.Add(new EventHandler(this.gunaGradientButton1_Click));
            events.Add(new EventHandler(this.gunaGradientButton6_Click));

            switch (_mode_)
            {
                case MOde_entree:
                    ajoute.Text = "Entree";
                    ClearEvents(ajoute, events);
                    ajoute.Click += events[0];
                    break;

                case Mode_search:
                    ajoute.Text = "Researche";
                    ClearEvents(ajoute, events);
                    ajoute.Click += events[1];
                    break;
            }
        }
        void ClearEvents(Control c, List<EventHandler> events)
        {
            foreach (var item in events)
            {
                c.Click -= item;
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
            SqlParameter[] param = new SqlParameter[5];
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
                MessageBox.Show("BIEN FAITE");
                //add_success add_Success = new add_success(item);
                //add_Success.ShowDialog();
            }
        }
    }
}
