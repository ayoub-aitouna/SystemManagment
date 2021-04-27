﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using ProjectV1.model;
using ProjectV1.sql;
using ProjectV1.dialog;
using Guna.UI.WinForms;
using System.Threading.Tasks;
using System.Threading;
namespace ProjectV1
  
{
    /*
     * acrticle user control
	*youssef
     */
    public partial class articlee : UserControl , Icloseall
    {

        //private const int Mode_Sortee = 100;
        //private const int MOde_entree = 200;
        //private const int Mode_search = 300;
       public Units.Unit _units = new Units.Unit();

        private int Breake =1;

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
            Menu_chosen(Entree);
            progresbar.Visible = false;
            _units.mode(Units.Unit.MOde_entree1, add_button, new EventHandler(this.gunaGradientButton1_Click), new EventHandler(this.search_event), new EventHandler(this.sortee_event));

            List<article_model> data = loaddata("select * from Artical");
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            foreach (var item in data)
            {
                coll.Add(item.Nom);
            }
            desination.AutoCompleteMode = AutoCompleteMode.Suggest;
            desination.AutoCompleteSource = AutoCompleteSource.CustomSource;
            desination.AutoCompleteCustomSource = coll;
            Units.Unit units = new Units.Unit();
            units.StyleDatagridview(view_data,1);
            setview_data(data);

        }





        /*
         * When a user clicks on add button this method get exuted 
         * what is does is it get the input and asinge them to an 
         * model class and run a background aysnc 
              */
        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (prix.Text==""|| quantitier.Text==""|| desination.Text==""|| pictureBox1.Image == null)
            {
                MessageBox.Show("error de input");
            }
            else
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
                    if (prix.Text != "") item.Prix = Double.Parse(prix.Text);
                    item.Quontitier1 = int.Parse(quantitier.Text);
                    item.Date_entre = DateTime.Parse(date.Value.ToShortDateString());
                    item.Img = imag;
                    if (!add_data_worker.IsBusy)
                    {
                        add_data_worker.RunWorkerAsync(item);
                    }


                
            }
        }

        private bool checkInputs(Control C)
        {
            bool _check = false;
            foreach (Control item in Add.Controls)
            {   
                if (item.GetType() == typeof(GunaTextBox))
                {
                     if ((((GunaTextBox)item).Text.Length == 0))
                    {
                        return _check;
                    }
                }
               
            }
            return _check;
        
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
           
            runViewAsync("select * from Artical", gunaGradientButton4);
            view_data.Enabled = false;
            progresbar.Show();
            

        }

        private void runViewAsync(String cmnd,Control btn)
        {
           
            if (viewData_worker.IsBusy)
            {
                viewData_worker.CancelAsync();
                MessageBox.Show("S'il vous plaît, attendez. En traitement ");
            }
            else
            {
                viewData_worker.RunWorkerAsync(cmnd);
                Menu_chosen(btn);
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
            Menu_chosen(Sortie);
            hideAll(Add);
            changeToSorteMode(true);
            _units.mode(Units.Unit.Mode_Sortee1, add_button, new EventHandler(this.gunaGradientButton1_Click), new EventHandler(this.search_event), new EventHandler(this.sortee_event));



        }

        private void changeToSorteMode(bool v)
        {
            if (v)
            {
                reference_intrene.Hide();
                label5.Hide();
                reference_fabricant.Hide();
                label4.Hide();
                gunaElipsePanel1.Hide();
                upload.Hide();
           
            }
            else
            {
                reference_intrene.Show();
                label5.Show();
                reference_fabricant.Show();
                label4.Show();
                gunaElipsePanel1.Show();
                upload.Show();
            }
        }









        /*
         * clear all the event of the button
         */
        void ClearEvents(Control c, List<EventHandler> events)
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
            if (!viewData_worker.IsBusy)
            {
                viewData_worker.RunWorkerAsync(@"select * from Artical where nom like '" + desination.Text + "' OR Barcode like '" + barcode.Text
                                                + "' OR code_fabrication like '" + code_ean.Text + "' OR prix like '" + prix.Text+"'");
            }
            hideAll(View);
            _units.Controls_clear(Add);


        }


        /*
      * when the user chose the entree mode 
      * it shows the panel named add 
      * and chande the event of the button to 
      * serve the purpose of searching for data on database 
      */
        private void search_event(object sender, EventArgs e)
        {
            //List<article_model> data = loaddata("select * from Artical where nom like '" + desination.Text + "'");
            //setview_data(data);

            viewData_worker.RunWorkerAsync("select * from Artical where nom like '" + desination.Text + "'");
            hideAll(View);
            _units.Controls_clear(Add);

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
            Menu_chosen(Entree);
            changeToSorteMode(false);
            _units.mode(Units.Unit.MOde_entree1, add_button, new EventHandler(this.gunaGradientButton1_Click), new EventHandler(this.search_event), new EventHandler(this.sortee_event));

            _units.Controls_clear(Add);
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
       
            view_data.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(12, 66, 132);
            view_data.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            
            view_data.DataSource = data;
            view_data.Columns["Id"].Visible = false;
            for (int i = 0; i < view_data.Columns.Count; i++)
                if (view_data.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)view_data.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
        }

      
    
        /*
         * when the user edite on a cell of datagridview
         */
        private void view_data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection a = view_data.Rows[e.RowIndex].Cells;

            string value = a[2].Value.ToString();
            progresbar.Show();
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

            if (!update_data.IsBusy)
            {
                update_data.RunWorkerAsync(model);
            }
        
           

        }
        private void update_data_DoWork(object sender, DoWorkEventArgs e)
        {
            article_model model =((article_model)e.Argument);
            sqlcn sql = new sqlcn();
            sql.update(model);
            e.Result = model;
        }
        private void update_data_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progresbar.Hide();
            article_model model = ((article_model)e.Result);
            add_success add_Success = new add_success(model);
            add_Success.ShowDialog();
        }

        /*
         * retrive data and bind it to a datagridview 
         * in the background thread
         */
        private void view_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            sqlcn SqlConnection = new sqlcn();
            e.Result = SqlConnection.View(e.Argument.ToString());
          
        }

        private void viewData_worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
    
        }
        /*
         * when the view background thread complets 
         * progress bar visibity set to false
         * and bind the retrived data to datagridview
         */
        private void view_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progresbar.Hide();
            view_data.Enabled = true;         
            setview_data((List<article_model>)e.Result);
            MessageBox.Show("le traitement est terminé");
           
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
          
            param[4].Value = int.Parse(item.Code_fabrication == "" ? "0" : item.Code_fabrication);

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
           
            List<object> parameters = new List<object>();
            parameters.Add(i);
            parameters.Add(item);
            e.Result = parameters;

        }
        /*
         * when the ayscn task of adding data complete 
         */
        private void add_data_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<object> args = e.Result as List<object>;

            int RUN_CODE = (int)args[0];
            article_model data = (article_model)args[1];
          
            progresbar.Hide();
            if (RUN_CODE == -1)
            {
                MessageBox.Show("Error en Entree");
            }
            else
            {            
                add_success dialog = new add_success(data);       
                dialog.ShowDialog();
            }
            _units.Controls_clear(Add);

        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            Menu_chosen(gunaGradientButton6);
            _units.mode(Units.Unit.Mode_search1, add_button, new EventHandler(this.gunaGradientButton1_Click), new EventHandler(this.search_event), new EventHandler(this.sortee_event));
            changeToSorteMode(true);
            hideAll(Add);

        }

       



        /*
         * when the user click on button validate 
         * it checks the selectedrow list 
         * if it got an item in it 
         * if dowsnot it show a message box asking the user to selected the wanted rows
         */
        private void valide_Click(object sender, EventArgs e)
        {
            Breake = 1;
            if (selectedRows.Count > 0)
            {
                /*article_model item = selectedRows[selectedRows.Count - 1];
              details_Sortee sorteeDialog = new details_Sortee(item);
*/
                foreach (var item in selectedRows)
                {
                    if (Breake != -1)
                    {
                        Thread.Sleep(200);
                        details_Sortee sorteeDialog = new details_Sortee(item, this,selectedRows.Count);
                        sorteeDialog.ShowDialog(); 
                    }
                    else
                    {
                        MessageBox.Show("you had canseled all");
                        break;
                    }
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

      

        private void entree_print_Document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        public void close(int i)
        {
            //throw new NotImplementedException();
            Breake = i;
        }

        private void used_items(object sender, EventArgs e)
        {
           

            hideAll(View);
           
            view_data.Enabled = false;
            progresbar.Show();
         
            runViewAsync("select * from Artical_Sortee", used_items_button);

        }
        private void Menu_chosen(Control btn)
        {
            foreach (var item in menu_container.Controls)
            {

                GunaGradientButton a = (GunaGradientButton)item;

                if (btn != null && (a == btn))
                {

                    a.BaseColor1 = Color.FromArgb(184, 60, 247);
                    a.BaseColor2 = Color.FromArgb(184, 60, 247);

                }
                else
                {
                    a.BaseColor1 = Color.FromArgb(12, 66, 132);
                    a.BaseColor2 = Color.FromArgb(12, 66, 132);
                }

            }
        }
      
    }
    public interface Icloseall
    {
        void close(int i);
    }
}

