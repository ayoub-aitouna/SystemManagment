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
        List<equipement_model> selectedRows = new List<equipement_model>();
        sql.sqlcn remplire = new sql.sqlcn();
         Units.Unit _units = new Units.Unit();

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
            _units.Controls_clear(add);
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
            _units.StyleDatagridview(view_data,1);
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
        //private void mode(int _mode_)
        //{
        //    List<EventHandler> events = new List<EventHandler>();
           
        //    events.Add(new EventHandler(this.gunaGradientButton1_Click));
        //    events.Add(new EventHandler(this.search_event));

        //    switch (_mode_)
        //    {
        //        case MOde_entree:
        //            ajouterequipe.Text = "Entree";
        //            ClearEvents(ajouterequipe, events);
        //            ajouterequipe.Click += events[0];
        //            break;
                
        //        case Mode_search:
        //            ajouterequipe.Text = "Researche";
        //            ClearEvents(ajouterequipe, events);
        //            ajouterequipe.Click += events[1];
        //            break;
        //    }
        //}

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
            _units.Controls_clear(add);

            if (!worker_back_view.IsBusy)
            {
       
                worker_back_view.RunWorkerAsync("select * from equipement where code like '" + code_equipemnt.Text+"'");
            }
            hideAll(view);
        }

        private void Entree_Click(object sender, EventArgs e)
        {
            hideAll(add);
            _units.mode(Units.Unit.MOde_entree1, ajouterequipe, new EventHandler(this.gunaGradientButton1_Click), new EventHandler(this.search_event));

        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            hideAll(add);
            _units.mode(Units.Unit.Mode_search1, ajouterequipe, new EventHandler(this.gunaGradientButton1_Click), new EventHandler(this.search_event));





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
            view_data.Columns["ref"].Visible = false;
        }

        private void view_data_SelectionChanged(object sender, EventArgs e)
        {
            if (view_data.SelectedRows.Count > 0)
            {
                selectedRows.Clear();
                for (int i = 0; i < view_data.SelectedRows.Count; i++)
                {
                    DataGridViewCellCollection a = view_data.SelectedRows[i].Cells;
                    string value = a[2].Value.ToString();
                    equipement_model model = new equipement_model();
               
                    selectedRows.Add(model);

                }

            }
            else
            {
                selectedRows.Clear();
            }
        }

        private void view_data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection a = view_data.Rows[e.RowIndex].Cells;

            string value = a[2].Value.ToString();
            progresbar.Show();
            equipement_model model = new equipement_model();
            model.Ref = int.Parse(a[0].Value.ToString());
            model.CODE = int.Parse(a[1].Value.ToString());
            model.Nom_equipment = a[2].Value.ToString();
            model.Matrucil = a[3].Value.ToString();
            

            if (!update_data_DoWork.IsBusy)
            {
                update_data_DoWork.RunWorkerAsync(model);
            }

        }

        private void update_data_DoWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            progresbar.Hide();
            equipement_model model = ((equipement_model)e.Result);
            add_success add_Success = new add_success(model);
            add_Success.ShowDialog();
        }

   
        private void update_data_DoWork_DoWork(object sender, DoWorkEventArgs e)
        {

            equipement_model model = ((equipement_model)e.Argument);
            sqlcn sql = new sqlcn();
            MessageBox.Show(model.Ref + "" + model.CODE + "" + model.Nom_equipment + "" + model.Matrucil);
            sql.update(model);
            e.Result = model;
        }
    }
}
