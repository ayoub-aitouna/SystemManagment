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
            hideAll(ajoute);
            mode(MOde_entree);
        }

        private void ajoute_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fourni_Load(object sender, EventArgs e)
        {
            progresbar.Hide();
            StyleDatagridview();
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
        void ClearEvents(Control c, List<EventHandler> events)
        {
            foreach (var item in events)
            {
                c.Click -= item;
            }
        }
        private void search_event(object sender, EventArgs e)
        {
            //List<article_model> data = loaddata("select * from Artical where nom like '" + desination.Text + "'");
            //setview_data(data);

            back_fourniseur_view.RunWorkerAsync("SELECT * from Fourniseur where code like '" + code_fourniseur.Text + "'");
            hideAll(panel_view);
            Controls_clear(ajoute);

        }
        private void Controls_clear(Control C)
        {
            foreach (Control item in C.Controls)
            {
                // MessageBox.Show(item.GetType().ToString());
                if (item.GetType() == typeof(TextBox))
                    ((TextBox)item).Clear();
                if (item.GetType() == typeof(GunaTextBox))
                    ((GunaTextBox)item).Clear();
                if (item.GetType() == typeof(DateTimePicker))
                    ((DateTimePicker)item).Value = DateTime.Today;
                if (item.GetType() == typeof(RadioButton))
                    ((RadioButton)item).Checked = false;
                if (item.GetType() == typeof(PictureBox))
                    ((PictureBox)item).Image = null;
                if (item.Controls.Count != 0)
                    Controls_clear(item);
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
          

            hideAll(ajoute);
            mode(Mode_search);
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

            setview_data(q);
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
    }
}
