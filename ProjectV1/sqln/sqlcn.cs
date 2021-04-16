using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using ProjectV1.model;
using System.Collections;

namespace ProjectV1.sql
{
    class sqlcn
    {
        private static String connetionString = @"Data Source=den1.mssql8.gear.host;Initial Catalog=asass;User ID=asass;Password=Dg39ZO9g6_9?";
        SqlConnection cnn;
        SqlDataReader datareader;
          //SqlConnection macn = new SqlConnection("Data Source = DESKTOP-FA5E9KJ; Initial Catalog = db_artical; Integrated Security = True");
        SqlConnection macn = new SqlConnection(connetionString);

        //open connection 
        public void openconx()
        {
            if (macn.State !=ConnectionState.Open)
           
                macn.Open();
            
        }
        //close connection 
        public void closecnx()
        {
            if (macn.State !=ConnectionState.Closed)
            
                macn.Close();
            
        }
        //reder data
        public  DataTable Selectdata(string stored_procedure,SqlParameter[] param)
        {
            SqlCommand macommende = new SqlCommand();
            macommende.CommandType = CommandType.StoredProcedure;
            macommende.CommandText = stored_procedure;
            if (param !=null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    macommende.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public void update(article_model item)
        {
            SqlCommand macommende = new SqlCommand();
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            macommende.Connection = cnn;

            macommende.CommandType = CommandType.Text;
            macommende.CommandText = @"UPDATE Artical SET  Barcode = @barcode,  nom = @nom,  description_inter = @description_inter,
                                         descroption_fabrication = @descroption_fabrication,  code_fabrication= @code_fabrication,
                                         prix= @prix, Quontitier= @Quontitier, date_entre= @date_entre, img= @img
                                        WHERE ref=" + item.Id;
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
            param[4].Value = item.Code_fabrication;

            param[5] = new SqlParameter("@prix", SqlDbType.Int);
            param[5].Value = item.Prix;

            param[6] = new SqlParameter("@Quontitier", SqlDbType.Int);
            param[6].Value = item.Quontitier1;

            param[7] = new SqlParameter("@date_entre", SqlDbType.Date);
            param[7].Value = item.Date_entre ;

            param[8] = new SqlParameter("@img", SqlDbType.Image);
            param[8].Value = item.Img;

            macommende.Parameters.AddRange(param);
            cnn.Close();
            cnn.Open();

            macommende.ExecuteNonQuery();

            cnn.Close();
        }
        //methode insert ,delet ,update
        public int ExuteCommende(string stored_procedure, SqlParameter[] param)
        {
            int i=0;
            SqlCommand macommende = new SqlCommand();
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            macommende.Connection = cnn;

            macommende.CommandType = CommandType.StoredProcedure;
            macommende.CommandText = stored_procedure;
      
            if (param !=null)
            {
                macommende.Parameters.AddRange(param);
                i =  macommende.ExecuteNonQuery();
                cnn.Close();
            }
            return i;
         
        }

        public List<article_model> View(String cmnd) {
            List<article_model> data = new List<article_model>();
          
            SqlCommand req = new SqlCommand();
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            req.Connection = cnn;
            req.CommandType = CommandType.Text; // Changer le type de la requete en text (non pas procedure)
            req.CommandText = cmnd;
            req.Parameters.Clear();
            datareader = req.ExecuteReader();
            while (datareader.Read())
            {

                article_model item = new article_model();
                item.Id = (int)datareader.GetValue(0);
                item.Barcode1 = (String)datareader.GetValue(1);
                item.Nom = (String)datareader.GetValue(2);
                item.Description_inter = (String)datareader.GetValue(3);
                item.Descroption_fabrication = (String)datareader.GetValue(4);
                item.Code_fabrication = (String)datareader.GetValue(5);
                item.Prix = (double)datareader.GetValue(6);
                item.Quontitier1 = (int)datareader.GetValue(7);
                item.Date_entre = (DateTime)datareader.GetValue(8);
                item.Img = (Byte[])datareader.GetValue(9);
                data.Add(item);
               // data.Add(new article_model((int)datareader.GetValue(0), (String)datareader.GetValue(1),(String) datareader.GetValue(2),(String) datareader.GetValue(3), (String)datareader.GetValue(4), (String)datareader.GetValue(5),(float) datareader.GetValue(6), (int)datareader.GetValue(7), (DateTime)datareader.GetValue(8),(byte[]) datareader.GetValue(9)));
            }

            cnn.Close();

            return data;
        }
    }
  
}
