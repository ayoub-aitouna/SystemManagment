using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using ProjectV1.model;
using ProjectV1.sql;
using Guna.UI.WinForms;
namespace ProjectV1
{
    public partial class articlee : UserControl
    {
        
        private const int Mode_Sortee = 100;
        private const int MOde_entree = 200;
        private const int Mode_search = 300;
        List<article_model> selectedRows = new List<article_model>();
        sql.sqlcn remplire = new sql.sqlcn();
        public articlee()
        {
            InitializeComponent();
        }
        /*
      * on userControl loaded
      */
        private void articlee_Load(object sender, EventArgs e)
        {
            progresbar.Visible = false;
            mode(MOde_entree);
            List<article_model> data = loaddata("select * from Artical");
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            foreach (var item in data)
            {
                coll.Add(item.Nom);
            }
            desination.AutoCompleteMode = AutoCompleteMode.Suggest;
            desination.AutoCompleteSource = AutoCompleteSource.CustomSource;
            desination.AutoCompleteCustomSource = coll;
            StyleDatagridview();
            setview_data(data);

        }
        /*
         * When a user clicks on add button this method get exuted 
         * what is does is it get the input and asinge them to an 
         * model class and run a background aysnc 
              */
        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {

            progresbar.Show();
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] imag = ms.ToArray();

            article_model item = new article_model();
            item.Barcode1 = barcode.Text;
            item.Nom = desination.Text;
            item.Description_inter = reference_intrene.Text;
            item.Descroption_fabrication = reference_fabricant.Text;
            item.Code_fabrication = code_ean.Text;
            item.Prix = Double.Parse( prix.Text);
            item.Quontitier1 =int.Parse( quantitier.Text);
            item.Date_entre =DateTime.Parse( date.Value.ToShortDateString());
            item.Img = imag;
            if (!add_data_worker.IsBusy)
            {
                add_data_worker.RunWorkerAsync(item);
            }


        }


  
        /*
         * get image from machin files and asing it to pictur box
         */
        private void upload_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (OP.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(OP.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        /*
         * on View CLick
         * show data of table in data grid view  
         * 
             */
        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
          
      
            hideAll(View);
           
            if (!viewData_worker.IsBusy)
            {
                progresbar.Show();
                viewData_worker.RunWorkerAsync("select * from Artical");
            }
            
        }
        /*
        * hide all the controls in the given parent exept the control in geven as argumnet 
             */
        private void hideAll(Control control)
        {
          

            foreach (var item in Container.Controls)
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

 

      
        /*
         * on sortee click 
         * change mode of usercontrol to sotree
             */
        private void sortee(object sender, EventArgs e)
        {
            hideAll(Add);
            mode(Mode_Sortee);
           

        }
      
   

        private void View_click(object sender, EventArgs e)
        {

        }

        /*change button mod {
         * Name
         * click_Event
         * 
         * }*/
        private void mode(int _mode_)
        {
            List<EventHandler> events = new List<EventHandler>();
            events.Add(new EventHandler(this.gunaGradientButton1_Click));
            events.Add(new EventHandler(this.sortee_event));
            events.Add(new EventHandler(this.search_event));

            switch (_mode_)
            {
                case MOde_entree:
                   gunaGradientButton1.Text = "Entree";
                    ClearEvents(gunaGradientButton1, events);
                    gunaGradientButton1.Click += events[0];
                    break;
                case Mode_Sortee:
                    gunaGradientButton1.Text = "Sortee";
                    ClearEvents(gunaGradientButton1, events);
                    gunaGradientButton1.Click += events[1];
                    break;
                case Mode_search:
                    gunaGradientButton1.Text = "Researche";
                    ClearEvents(gunaGradientButton1, events);
                    gunaGradientButton1.Click += events[2];
                    break;
            }
        }
        /*
         * clear all the event of the button
         */
        void ClearEvents(Control c,List<EventHandler> events)
        {
            foreach (var item in events)
            {
                c.Click -= item;
            }
        }
        /*
         *    /*
         * when the user chose the entree mode 
         * it shows the panel named add 
         * and chande the event of the button to 
         * serve the purpose 
         * get data that matches the user input 
         * then list them as solled items
         */
        private void sortee_event(object sender, EventArgs e)
        {
            List<article_model> data = loaddata("select * from Artical where nom like '" + desination.Text+"'");
            setview_data(data);
            hideAll(View);
            Controls_clear(Add);
           
        }


        /*
      * when the user chose the entree mode 
      * it shows the panel named add 
      * and chande the event of the button to 
      * serve the purpose of searching for data on database 
      */
        private void search_event(object sender, EventArgs e)
        {
            List<article_model> data = loaddata("select * from Artical where nom like '" + desination.Text + "'");
            setview_data(data);
            hideAll(View);
            Controls_clear(Add);

        }


        /*
         * when the user chose the entree mode 
         * it shows the panel named add 
         * and chande the event of the button to 
         * serve the purpose of adding data to database 
         */
        private void Entree_Click(object sender, EventArgs e)
        {
            hideAll(Add);
            mode(MOde_entree);
            Controls_clear(Add);
        }

        /*
         * get data from databse and asing it to a class object 
         * data retrived depends on the query given in the argumtens 
         */
        private List<article_model> loaddata(String query)
        {
            sqlcn SqlConnection = new sqlcn();
            return SqlConnection.View(query);
        
        }
     
        /*
         * bind the data retrived to a datagrid view
         * set the image cell mod to Zoom
         */
        private void setview_data(List<article_model> data)
        {
            view_data.EnableHeadersVisualStyles = false;
            view_data.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(12, 66, 132);
            view_data.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            

            view_data.DataSource = data;
            view_data.DataSource = data;
            for (int i = 0; i < view_data.Columns.Count; i++)
                if (view_data.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)view_data.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
        }

        /*
         * Reset all the controls in the parent geven in the arguments
         */
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
        /*
         * when the user edite on a cell of datagridview
         */
        private void view_data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection a = view_data.Rows[e.RowIndex].Cells;
         
            string value = a[2].Value.ToString();
         
            article_model model = new article_model();
            model.Id = int.Parse(a[0].Value.ToString());
            model.Barcode1 = a[1].Value.ToString();
            model.Nom = a[2].Value.ToString();
            model.Description_inter = a[3].Value.ToString();
            model.Descroption_fabrication= a[4].Value.ToString();
            model.Code_fabrication = a[5].Value.ToString();
            model.Prix=double.Parse( a[6].Value.ToString());
            model.Quontitier1 = int.Parse(a[7].Value.ToString());
            model.Date_entre = DateTime.Parse(a[8].Value.ToString());
            model.Img = (byte[])a[9].Value;

            sqlcn sql = new sqlcn();
            sql.update(model);
            MessageBox.Show("les données ont été mises à jour ");
          

        }
        /*
         * retrive data and bind it to a datagridview 
         * in the background thread
         */
        private void view_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            sqlcn SqlConnection = new sqlcn();
            e.Result= SqlConnection.View(e.Argument.ToString());
        }
        /*
         * when the view background thread complets 
         * progress bar visibity set to false
         * and bind the retrived data to datagridview
         */
        private void view_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progresbar.Hide();
            setview_data((List<article_model>)e.Result);
        }
        /*
         * start an async task to add data to database 
         */
        private void add_data_worker_DoWork(object sender, DoWorkEventArgs e)
        {

            article_model item = (article_model)e.Argument;
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@barcode", SqlDbType.VarChar, 40);
            param[0].Value = item.Barcode1;

            param[1] = new SqlParameter("@nom", SqlDbType.VarChar, 40);
            param[1].Value = item.Nom;

            param[2] = new SqlParameter("@description_inter", SqlDbType.VarChar, 40);
            param[2].Value = item.Description_inter;

            param[3] = new SqlParameter("@descroption_fabrication", SqlDbType.VarChar, 40);
            param[3].Value = item.Descroption_fabrication;

            param[4] = new SqlParameter("@code_fabrication", SqlDbType.Int);
            param[4].Value = int.Parse( item.Code_fabrication);

            param[5] = new SqlParameter("@prix", SqlDbType.Int);
            param[5].Value = item.Prix;

            param[6] = new SqlParameter("@Quontitier", SqlDbType.Int);
            param[6].Value = item.Quontitier1;

            param[7] = new SqlParameter("@date_entre", SqlDbType.Date);
            param[7].Value = item.Date_entre;

            param[8] = new SqlParameter("@img", SqlDbType.Image);
            param[8].Value = item.Img;

            remplire.openconx();
            //foreach (var item in param)
            //{
            //    MessageBox.Show("" + item);
            //}
            int i = remplire.ExuteCommende("r_Article", param);
          
            remplire.closecnx();

            e.Result = i;

        }
        /*
         * when the ayscn task of adding data complete 
         */
        private void add_data_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int RUN_CODE = (int)e.Result;
            progresbar.Hide();
            if (RUN_CODE == -1)
            {
                MessageBox.Show("Error en Entree");
            }
            Controls_clear(Add);
        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            mode(Mode_search);
            hideAll(Add);

        }

        void StyleDatagridview()
        {
            view_data.BorderStyle = BorderStyle.None;
            view_data.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
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
            view_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }


        /*
         * when the user click on button validate 
         * it checks the selectedrow list 
         * if it got an item in it 
         * if dowsnot it show a message box asking the user to selected the wanted rows
         */
        private void valide_Click(object sender, EventArgs e)
        {
            if (selectedRows.Count > 0)
            {
                foreach (var item in selectedRows)
                {
                    MessageBox.Show("data is " + item.Id);
                }
            }
            else
            {
                MessageBox.Show("Please selecte at less an item ");
            }
        }
        /*
         * when the user select a row o multiple rows of data grid view 
         * it get stored in list of arcticle model 
         * and if it unselected them the list get cleared 
         */
        private void view_data_SelectionChanged(object sender, EventArgs e)
        {
          
            if (view_data.SelectedRows.Count > 0)
            {
                selectedRows.Clear();
                for (int i = 0; i < view_data.SelectedRows.Count; i++)
                {
                    DataGridViewCellCollection a = view_data.SelectedRows[i].Cells;
                    string value = a[2].Value.ToString(); 
                    article_model model = new article_model();
                    model.Id = int.Parse(a[0].Value.ToString());
                    model.Barcode1 = a[1].Value.ToString();
                    model.Nom = a[2].Value.ToString();
                    model.Description_inter = a[3].Value.ToString();
                    model.Descroption_fabrication = a[4].Value.ToString();
                    model.Code_fabrication = a[5].Value.ToString();
                    model.Prix = double.Parse(a[6].Value.ToString());
                    model.Quontitier1 = int.Parse(a[7].Value.ToString());
                    model.Date_entre = DateTime.Parse(a[8].Value.ToString());
                    model.Img = (byte[])a[9].Value;
                    selectedRows.Add(model);

                }

            }
            else
            {
                selectedRows.Clear();
            }

        }
    }
}
