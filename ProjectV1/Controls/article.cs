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
using ProjectV1.dialog;
using Guna.UI.WinForms;
using System.Threading.Tasks;
using System.Threading;
using ProjectV1.Units;
using System.Collections;

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
       public Unit _units = new Unit();

        private int Breake =1;

        List<article_model> selectedRows = new List<article_model>();
        sql.sqlcn remplire = new sql.sqlcn();
        private string View_select_Comand = " select * from Artical where Quontitier != 0";

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
            if (!viewData_worker.IsBusy)
            {
                viewData_worker.RunWorkerAsync(View_select_Comand);
            }
            _units.mode(Units.Unit.MOde_entree1, add_button, new EventHandler(this.gunaGradientButton1_Click), new EventHandler(this.search_event), new EventHandler(this.sortee_event));
            _units.StyleDatagridview(view_data, 1);
            

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
                MessageBox.Show("Il faut remplire Quantitier , designation ,prix et image");
            }
            else
            {
              
               
                    progresbar.Show();
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] imag = ms.ToArray();

                    article_model item = new article_model();
                    item.Barcode1 = barcode.Text;
                if (desination.Text != "") { item.Nom = desination.Text; }
                    item.Description_inter = reference_intrene.Text;
                    item.Descroption_fabrication = reference_fabricant.Text;
                    item.Code_fabrication = code_ean.Text;
                     item.Prix = Double.Parse(prix.Text);
                if (quantitier.Text != "") { item.Quontitier1 = int.Parse(quantitier.Text); } 
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
            foreach (Control item in bon_entre.Controls)
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
           
            runViewAsync(View_select_Comand, gunaGradientButton4,0);
            view_data.Enabled = false;
            progresbar.Show();
            

        }

        private void runViewAsync(String cmnd,Control btn,int a)
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


        enum arguments
        {
            commande,
            type
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
            label9.Text = "bon_sortie";
            hideAll(bon_entre);
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
            _units.Controls_clear(bon_entre);


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
            _units.Controls_clear(bon_entre);

        }


        /*
         * when the user chose the entree mode 
         * it shows the panel named add 
         * and chande the event of the button to 
         * serve the purpose of adding data to database 
         */
        private void Entree_Click(object sender, EventArgs e)
        {
            hideAll(bon_entre);
            label9.Text = "Bon_Entré";
            Menu_chosen(Entree);
            changeToSorteMode(false);
            _units.mode(Units.Unit.MOde_entree1, add_button, new EventHandler(this.gunaGradientButton1_Click), new EventHandler(this.search_event), new EventHandler(this.sortee_event));

            _units.Controls_clear(bon_entre);
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
        private void setview_data(List<Articl_sortie> data)
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
            model.Bon_entrer = int.Parse(a[1].Value.ToString());
            model.Barcode1 = a[2].Value.ToString();
            model.Fourniseur = a[3].Value.ToString();
            model.Nom = a[4].Value.ToString();
            model.Description_inter = a[5].Value.ToString();
            model.Descroption_fabrication = a[6].Value.ToString();
            model.Code_fabrication = a[7].Value.ToString();
            model.Prix = int.Parse(a[8].Value.ToString());
            model.Quontitier1 = int.Parse(a[9].Value.ToString());
            model.Date_entre = DateTime.Parse(a[10].Value.ToString());

            model.Img = (byte[])a[11].Value;



            //article_model item = new article_model();
            //item.Id = (int)datareader.GetValue(0);
            //item.Barcode1 = (String)datareader.GetValue(1);
            //item.Bon_entrer = (int)datareader.GetValue(2);
            //item.Nom = (String)datareader.GetValue(3);
            //item.Description_inter = (String)datareader.GetValue(4);
            //item.Fourniseur = (string)datareader.GetValue(5);
            //item.Descroption_fabrication = (String)datareader.GetValue(6);
            //item.Code_fabrication = (String)datareader.GetValue(7);
            //item.Prix = (double)datareader.GetValue(8);
            //item.Quontitier1 = (int)datareader.GetValue(9);
            //item.Date_entre = (DateTime)datareader.GetValue(10);
            //item.Img = (Byte[])datareader.GetValue(11);

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
           
           
                SqlDataReader datareader = SqlConnection.Data_View(e.Argument.ToString());
                List<article_model> data = new List<article_model>();
                while (datareader.Read())
                {
                article_model item = new article_model();
                    item.Id = (int)datareader.GetValue(0);        
                    item.Barcode1 = (String)datareader.GetValue(1);
                item.Bon_entrer = (int)datareader.GetValue(2);
                item.Nom = (String)datareader.GetValue(3);
                    item.Description_inter = (String)datareader.GetValue(4);
                item.Fourniseur = (string)datareader.GetValue(5);
                    item.Descroption_fabrication = (String)datareader.GetValue(6);
                    item.Code_fabrication = (String)datareader.GetValue(7);
                    item.Prix = (double)datareader.GetValue(8);
                    item.Quontitier1 = (int)datareader.GetValue(9);
                    item.Date_entre = (DateTime)datareader.GetValue(10);        
                    item.Img = (Byte[])datareader.GetValue(11);
                    data.Add(item);
                    // data.Add(new article_model((int)datareader.GetValue(0), (String)datareader.GetValue(1),(String) datareader.GetValue(2),(String) datareader.GetValue(3), (String)datareader.GetValue(4), (String)datareader.GetValue(5),(float) datareader.GetValue(6), (int)datareader.GetValue(7), (DateTime)datareader.GetValue(8),(byte[]) datareader.GetValue(9)));
                }
                e.Result = data;


           
             
            

        }

      
        /*
         * when the view background thread complets 
         * progress bar visibity set to false
         * and bind the retrived data to datagridview
         */
        private void view_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
          //  ArrayList arguments = e.Argument as 
            progresbar.Hide();
            view_data.Enabled = true;
            List<article_model> data = e.Result as List<article_model>;
            setview_data(data);
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            AutoCompleteStringCollection Barcodecoll = new AutoCompleteStringCollection();

            foreach (var item in data)
            {
                coll.Add(item.Nom);
                Barcodecoll.Add(item.Barcode1);
            }
            desination.AutoCompleteMode = AutoCompleteMode.Suggest;
            desination.AutoCompleteSource = AutoCompleteSource.CustomSource;
            desination.AutoCompleteCustomSource = coll;


            barcode.AutoCompleteMode = AutoCompleteMode.Suggest;
            barcode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            barcode.AutoCompleteCustomSource = Barcodecoll;


        }
        /*
         * start an async task to add data to database 
         */
        private void add_data_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            article_model item = (article_model)e.Argument;
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@barcode", SqlDbType.VarChar, 40);
            param[0].Value = item.Barcode1;

            param[1] = new SqlParameter("@bon_entrer", SqlDbType.Int);
            param[1].Value = item.Bon_entrer;

            param[2] = new SqlParameter("@nom", SqlDbType.VarChar, 40);
            param[2].Value = item.Nom;

            param[3] = new SqlParameter("@description_inter", SqlDbType.VarChar, 40);
            param[3].Value = item.Description_inter;

            param[4] = new SqlParameter("@fourniseur", SqlDbType.VarChar, 40);
            param[4].Value = item.Barcode1;

            param[5] = new SqlParameter("@descroption_fabrication", SqlDbType.VarChar, 40);
            param[5].Value = item.Descroption_fabrication;

            param[6] = new SqlParameter("@code_fabrication", SqlDbType.Int);
          
            param[6].Value = int.Parse(item.Code_fabrication == "" ? "0" : item.Code_fabrication);

            param[7] = new SqlParameter("@prix", SqlDbType.Int);
            param[7].Value = item.Prix;

            param[8] = new SqlParameter("@Quontitier", SqlDbType.Int);
            param[8].Value = item.Quontitier1;

            param[9] = new SqlParameter("@date_entre", SqlDbType.Date);
            param[9].Value = item.Date_entre;

            param[10] = new SqlParameter("@img", SqlDbType.Image);
            param[10].Value = item.Img;

           

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
            _units.Controls_clear(bon_entre);

        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            Menu_chosen(gunaGradientButton6);
            _units.mode(Units.Unit.Mode_search1, add_button, new EventHandler(this.gunaGradientButton1_Click), new EventHandler(this.search_event), new EventHandler(this.sortee_event));
            changeToSorteMode(true);
            hideAll(bon_entre);

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
                try
                {
                    for (int i = 0; i < view_data.SelectedRows.Count; i++)
                    {
                        DataGridViewCellCollection a = view_data.SelectedRows[i].Cells;
                        string value = a[2].Value.ToString();
                        article_model model = new article_model();
                        model.Id = int.Parse(a[0].Value.ToString());
                        model.Barcode1 = a[1].Value.ToString();
                        model.Bon_entrer = int.Parse(a[2].Value.ToString());
                        model.Nom = a[3].Value.ToString();
                        model.Description_inter = a[4].Value.ToString();
                        model.Fourniseur = a[5].Value.ToString();
                        model.Descroption_fabrication = a[6].Value.ToString();
                        model.Code_fabrication = a[7].Value.ToString();
                        model.Prix = double.Parse(a[8].Value.ToString());
                        model.Quontitier1 = int.Parse(a[9].Value.ToString());
                        model.Date_entre = DateTime.Parse(a[10].Value.ToString());
                        model.Img = (byte[])a[11].Value;                    
                        selectedRows.Add(model);

                    }
                }
                catch (Exception)
                {
                    try
                    {
                        for (int i = 0; i < view_data.SelectedRows.Count; i++)
                        {
                            DataGridViewCellCollection a = view_data.SelectedRows[i].Cells;
                            string value = a[2].Value.ToString();
                            Articl_sortie model = new Articl_sortie();
                            model.Id = int.Parse(a[0].Value.ToString());
                            model.Barcode1 = a[1].Value.ToString();
                            model.Nom = a[2].Value.ToString();
                            model.Description_inter = a[3].Value.ToString();
                            model.Descroption_fabrication = a[4].Value.ToString();
                            model.Code_fabrication = a[5].Value.ToString();
                            model.Prix = double.Parse(a[6].Value.ToString());
                            model.Quontitier1 = int.Parse(a[7].Value.ToString());
                            model.Date_entre = DateTime.Parse(a[8].Value.ToString());
                            model.Date_sortie = DateTime.Parse(a[9].Value.ToString());
                            model.Date_sortie = DateTime.Parse(a[9].Value.ToString());
                            model.Matricul = a[9].Value.ToString();
                            model.Img = (byte[])a[10].Value;
                            model.Bon_entrer = int.Parse(a[11].Value.ToString());
                            // selectedRows.Add(model);
                        }
                    }
                    catch (Exception)
                    {

                        //throw;
                    }
                    // throw;
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
            if (!ArticleSorieView.IsBusy)
            {
                ArticleSorieView.RunWorkerAsync("select * from Artical_Sortee INNER JOIN Artical on Artical.ref = Artical_Sortee.Id_Article");
            }
           

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

        private void ArticleSorieView_DoWork(object sender, DoWorkEventArgs e)
        {
            sqlcn SqlConnection = new sqlcn();


            SqlDataReader datareader = SqlConnection.Data_View(e.Argument.ToString());
            List<Articl_sortie> data = new List<Articl_sortie>();
            while (datareader.Read())
            {
                Articl_sortie item = new Articl_sortie();
                item.Id = (int)datareader.GetValue(0);
                item.Codeclient = (int)datareader.GetValue(2);
                item.Date_sortie = (DateTime)datareader.GetValue(3);
                item.Matricul = (String)datareader.GetValue(4);
                item.Quontitier1 = (int)datareader.GetValue(5);

                item.Barcode1 = (String)datareader.GetValue(7);
                item.Bon_entrer = (int)datareader.GetValue(8);
                item.Nom = (String)datareader.GetValue(9);
                item.Description_inter = (String)datareader.GetValue(11);
                item.Descroption_fabrication = (String)datareader.GetValue(12);
                item.Code_fabrication = (String)datareader.GetValue(13);
                item.Prix = (double)datareader.GetValue(14);
                item.Date_entre = (DateTime)datareader.GetValue(16);
                item.Img = (Byte[])datareader.GetValue(17);
                data.Add(item);
                // data.Add(new article_model((int)datareader.GetValue(0), (String)datareader.GetValue(1),(String) datareader.GetValue(2),(String) datareader.GetValue(3), (String)datareader.GetValue(4), (String)datareader.GetValue(5),(float) datareader.GetValue(6), (int)datareader.GetValue(7), (DateTime)datareader.GetValue(8),(byte[]) datareader.GetValue(9)));
            }
            e.Result = data;
        }

        private void ArticleSorieView_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progresbar.Hide();
            view_data.Enabled = true;
            setview_data((List<Articl_sortie>)e.Result);
            MessageBox.Show("le traitement est terminé");
        }

        private void Add_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void desination_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public interface Icloseall
    {
        void close(int i);
    }
}

