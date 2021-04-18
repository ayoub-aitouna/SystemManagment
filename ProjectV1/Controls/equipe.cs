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
using ProjectV1.model;
using ProjectV1.sql;

namespace ProjectV1
{
    public partial class equipe : UserControl
    {
        private const int MOde_entree = 200;
        private const int Mode_search = 300;
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
            progresbar.Show();
            model.equipement_model item = new model.equipement_model();
            item.CODE = int.Parse(code_equipemnt.Text);
            item.Nom_equipment = nom_equipe.Text;
            item.Matrucil = matricule_equipe.Text;
            if (!working_back.IsBusy)
            {
                working_back.RunWorkerAsync(item);
            }
           

        }

        private void add_Paint(object sender, PaintEventArgs e)
        {

        }

        private void equipe_Load(object sender, EventArgs e)
        {
            progresbar.Hide();
            hideAll(add);

            //style data gride view
            StyleDatagridview();
        }

        private void working_back_DoWork(object sender, DoWorkEventArgs e)
        {
            model.equipement_model item = (model.equipement_model) e.Argument;
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@nom", SqlDbType.VarChar, 40);
            param[0].Value = item.Nom_equipment;

            param[1] = new SqlParameter("@matircile", SqlDbType.VarChar, 40);
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
        private void working_back_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progresbar.Hide();
            List<object> parameters = e.Result as List<object>;
            int i = int.Parse( parameters[0].ToString());
            equipement_model item = (equipement_model)parameters[1];
           
            if (i ==-1)
            {
                MessageBox.Show("errure d'ajouter");
            }
            else
            {

                add_success add_Success = new add_success(item);
                add_Success.ShowDialog();
            }
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            hideAll(view);
            view_data.Enabled = false;
            progresbar.Show();
            if (!worker_back_view.IsBusy)
            {
                worker_back_view.RunWorkerAsync("select * from equipement");
            }
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
            events.Add(new EventHandler(this.search_event));

            switch (_mode_)
            {
                case MOde_entree:
                    ajouterequipe.Text = "Entree";
                    ClearEvents(ajouterequipe, events);
                    ajouterequipe.Click += events[0];
                    break;
                
                case Mode_search:
                    ajouterequipe.Text = "Researche";
                    ClearEvents(ajouterequipe, events);
                    ajouterequipe.Click += events[1];
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
            view_data.Enabled = false;
            progresbar.Show();
            if (!worker_back_view.IsBusy)
            {
       
                worker_back_view.RunWorkerAsync("select * from equipement where code like '" + code_equipemnt.Text+"'");
            }
            hideAll(view);
        }

        private void Entree_Click(object sender, EventArgs e)
        {
            hideAll(add);
            mode(MOde_entree);
        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            hideAll(add);
            mode(Mode_search);

           
         

        }
        private void setview_data(List<equipement_model> data)
        {
           
            view_data.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(12, 66, 132);
            view_data.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            view_data.DataSource = data;
          
            
        }
        private void worker_back_view_DoWork(object sender, DoWorkEventArgs e)
        {
            sqlcn SqlConnection = new sqlcn();
            e.Result = SqlConnection.Viewequipe(e.Argument.ToString());
        }

        private void worker_back_view_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<equipement_model> q = (List<equipement_model>)e.Result;
            
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
    }
}
