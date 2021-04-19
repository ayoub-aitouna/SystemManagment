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
        private const int MOde_entree = 200;
        private const int Mode_search = 300;
        public CLients()
        {
            InitializeComponent();
        }
        private void CLients_Load(object sender, EventArgs e)
        {
            progresbar.Hide();
            StyleDatagridview();
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

        void StyleDatagridview()
        {
            view_data.BorderStyle = BorderStyle.None;
            view_data.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(226, 226, 226);
            view_data.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            view_data.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            view_data.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            view_data.BackgroundColor = Color.FromArgb(30, 30, 30);
            view_data.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            view_data.EnableHeadersVisualStyles = false;
            view_data.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            view_data.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            view_data.ColumnHeadersHeight = 40;
            view_data.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            view_data.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            view_data.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            view_data.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;


            view_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



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


            if (!background_ajoute.IsBusy)
            {
                background_ajoute.RunWorkerAsync(item);
            }
        }
        void ClearEvents(Control c, List<EventHandler> events)
        {
            foreach (var item in events)
            {
                c.Click -= item;
            }
        }
        //cette methode changer event entre evente de ajouter et de chercher
        private void mode(int _mode_)
        {
            List<EventHandler> events = new List<EventHandler>();

            events.Add(new EventHandler(this.gunaGradientButton1_Click));
            events.Add(new EventHandler(this.gunaGradientButton6_Click));

            switch (_mode_)
            {
                case MOde_entree:
                    btn_ajoute.Text = "Entree";
                    ClearEvents(btn_ajoute, events);
                    btn_ajoute.Click += events[0];
                    break;

                case Mode_search:
                    btn_ajoute.Text = "Researche";
                    ClearEvents(btn_ajoute, events);
                    btn_ajoute.Click += events[1];
                    break;
            }
        }
        private void background_ajoute_DoWork(object sender, DoWorkEventArgs e)
        {
            model.model_client item = (model.model_client)e.Argument;
            SqlParameter[] param = new SqlParameter[5];
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
                MessageBox.Show("BIEN FAITE");
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


        }
        private void background_view_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<model_client> q = (List<model_client>)e.Result;

            progresbar.Hide();
            view_data.Enabled = true;

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
            mode(Mode_search);
        }

        private void ajoute_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Entree_Click(object sender, EventArgs e)
        {
            hideAll(ajoute);
            mode(MOde_entree);
        }
    }
}
