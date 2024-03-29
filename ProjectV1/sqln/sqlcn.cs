﻿using System;
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
        private static String connetionString = @"Data Source=.;Initial Catalog=SystemManagment;Integrated Security=True";


        SqlDataReader datareader;

          //SqlConnection macn = new SqlConnection("Data Source = DESKTOP-FA5E9KJ; Initial Catalog = db_artical; Integrated Security = True");
        SqlConnection cnn = new SqlConnection(connetionString);

        //open connection 
        public void openconx()
        {
          
                if (cnn.State != ConnectionState.Open)

                    cnn.Open();   
            
        }
        //close connection 
        public void closecnx()
        {
            if (cnn.State !=ConnectionState.Closed)

                cnn.Close();
            
        }
        //reder data
        public  DataTable Selectdata(string stored_procedure,SqlParameter[] param)
        {
            SqlCommand macommende = new SqlCommand();
            macommende.Connection = cnn;
            
            macommende.CommandType = CommandType.StoredProcedure;
            macommende.CommandText = stored_procedure;
            if (param !=null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    macommende.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(macommende);
            DataTable dt = new DataTable();
            da.Fill(dt);
          
            return dt;

        }

        public void update(article_model item)
        {
            SqlCommand macommende = new SqlCommand();
            openconx();
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
            

            macommende.ExecuteNonQuery();

         
        }
        public void update(equipement_model item)
        {
            SqlCommand macommende = new SqlCommand();
            openconx();
            macommende.Connection = cnn;

            macommende.CommandType = CommandType.Text;
            macommende.CommandText = @"UPDATE equipement SET  code = @code,  nom = @nom,  matircile = @matricile
                                        WHERE ref=" + item.Ref;
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@code", SqlDbType.VarChar, 40);
            param[0].Value = item.CODE;

            param[1] = new SqlParameter("@nom", SqlDbType.VarChar, 40);
            param[1].Value = item.Nom_equipment;

            param[2] = new SqlParameter("@matricile", SqlDbType.VarChar, 40);
            param[2].Value = item.Matrucil;
          
            macommende.Parameters.AddRange(param);
         

            macommende.ExecuteNonQuery();

           
        }
        public void update(model_client item)
        {
            SqlCommand macommende = new SqlCommand();
            openconx();
            macommende.Connection = cnn;

            macommende.CommandType = CommandType.Text;
            macommende.CommandText = @"UPDATE Client SET  code = @code,  nom = @nom,  phone = @phone,adress=@adress,Email=@Email
                                        WHERE ref=" + item.Ref;
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@code", SqlDbType.VarChar, 40);
            param[0].Value = item.Code_client;

            param[1] = new SqlParameter("@nom", SqlDbType.VarChar, 40);
            param[1].Value = item.Nom_client;
            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 40);
            param[2].Value = item.Numerophone_client;
            param[3] = new SqlParameter("@adress", SqlDbType.VarChar, 40);
            param[3].Value = item.Adress_client;
            param[4] = new SqlParameter("@Email", SqlDbType.VarChar, 40);
            param[4].Value = item.Email_client;

            param[5] = new SqlParameter("@fax", SqlDbType.VarChar, 40);
            param[5].Value = item.Fax;

            macommende.Parameters.AddRange(param);
           

            macommende.ExecuteNonQuery();

           
        }
        public void update(fourniseur_model item)
        {
            SqlCommand macommende = new SqlCommand();
            openconx();
            macommende.Connection = cnn;

            macommende.CommandType = CommandType.Text;
            macommende.CommandText = @"UPDATE fourniseur SET  code = @code,  nom = @nom,  phone = @phone , adress=@adress , Email=@Email
                                        WHERE ref=" + item.Ref;
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


            param[5] = new SqlParameter("@fax", SqlDbType.VarChar, 40);
            param[5].Value = item.Fax;

            macommende.Parameters.AddRange(param);
          

            macommende.ExecuteNonQuery();

           
        }
        //methode insert ,delet ,update
        public int ExuteCommende(string stored_procedure, SqlParameter[] param)
        {
            int i=0;
            SqlCommand macommende = new SqlCommand();
            openconx();
            macommende.Connection = cnn;

            macommende.CommandType = CommandType.StoredProcedure;
            macommende.CommandText = stored_procedure;
      
            if (param !=null)
            {
                macommende.Parameters.AddRange(param);
                try
                {
                    i = macommende.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    return -1;
                }
                
              
            }
            return i;
         
        }

        public List<article_model> View(String cmnd) {
            List<article_model> data = new List<article_model>();
          
            SqlCommand req = new SqlCommand();
            openconx();
            req.Connection = cnn;
            req.CommandType = CommandType.Text; // Changer le type de la requete en text (non pas procedure)
            req.CommandText = cmnd;
            req.Parameters.Clear();
            datareader = req.ExecuteReader();
            while (datareader.Read())
            {

                article_model item = new article_model();
                item.Id = (int)datareader.GetValue(0);
                item.Bon_entrer = (int)datareader.GetValue(1);
                item.Barcode1 = (String)datareader.GetValue(2);
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

    

            return data;
        }

        public SqlDataReader Data_View(String cmnd)
        {
           

            SqlCommand req = new SqlCommand();
            openconx();

            req.Connection = cnn;
            req.CommandType = CommandType.Text; // Changer le type de la requete en text (non pas procedure)
            req.CommandText = cmnd;
            req.Parameters.Clear();
            return req.ExecuteReader();
   
          
          

         
        }
        public List<equipement_model> Viewequipe(String cmnd)
        {
            List<equipement_model> data = new List<equipement_model>();

            SqlCommand req = new SqlCommand();
            openconx();

            req.Connection = cnn;
            req.CommandType = CommandType.Text; // Changer le type de la requete en text (non pas procedure)
            req.CommandText = cmnd;
            req.Parameters.Clear();
            datareader = req.ExecuteReader();
            while (datareader.Read())
            {

                equipement_model item = new equipement_model();
                item.Matrucil = datareader.GetValue(0).ToString();
                item.Nom_equipment = datareader.GetValue(1).ToString();
                item.CODE = int.Parse(datareader.GetValue(2).ToString());
           
      
                data.Add(item);                // data.Add(new article_model((int)datareader.GetValue(0), (String)datareader.GetValue(1),(String) datareader.GetValue(2),(String) datareader.GetValue(3), (String)datareader.GetValue(4), (String)datareader.GetValue(5),(float) datareader.GetValue(6), (int)datareader.GetValue(7), (DateTime)datareader.GetValue(8),(byte[]) datareader.GetValue(9)));
            }

    

            return data;
        }
        public List<fourniseur_model> Viewfourniseur(String cmnd)
        {
            List<fourniseur_model> data = new List<fourniseur_model>();

            SqlCommand req = new SqlCommand();
            openconx();
            req.Connection = cnn;
            req.CommandType = CommandType.Text; // Changer le type de la requete en text (non pas procedure)
            req.CommandText = cmnd;
            req.Parameters.Clear();
            datareader = req.ExecuteReader();
            while (datareader.Read())
            {

                fourniseur_model item = new fourniseur_model();
                item.Ref = int.Parse(datareader.GetValue(0).ToString());
                item.Code_fourniseur = int.Parse( datareader.GetValue(1).ToString());
                item.Nom = datareader.GetValue(2).ToString();
                item.Numerophone =datareader.GetValue(3).ToString();
                item.Adress = datareader.GetValue(4).ToString();
                item.Email = datareader.GetValue(5).ToString();
                item.Fax = datareader.GetValue(6).ToString();

                data.Add(item);                // data.Add(new article_model((int)datareader.GetValue(0), (String)datareader.GetValue(1),(String) datareader.GetValue(2),(String) datareader.GetValue(3), (String)datareader.GetValue(4), (String)datareader.GetValue(5),(float) datareader.GetValue(6), (int)datareader.GetValue(7), (DateTime)datareader.GetValue(8),(byte[]) datareader.GetValue(9)));
            }

    

            return data;
        }
        public List<model_client> ViewClient(String cmnd)
        {
            List<model_client> data = new List<model_client>();

            SqlCommand req = new SqlCommand();
            openconx();

            req.Connection = cnn;
            req.CommandType = CommandType.Text; // Changer le type de la requete en text (non pas procedure)
            req.CommandText = cmnd;
            req.Parameters.Clear();
            datareader = req.ExecuteReader();
            while (datareader.Read())
            {

                model_client item = new model_client();
                item.Ref = int.Parse(datareader.GetValue(0).ToString());
                item.Code_client = int.Parse(datareader.GetValue(1).ToString());
                item.Nom_client = datareader.GetValue(2).ToString();
                item.Adress_client = datareader.GetValue(3).ToString();
                item.Numerophone_client = datareader.GetValue(4).ToString();
                item.Email_client = datareader.GetValue(5).ToString();
                item.Fax= datareader.GetValue(6).ToString();


                data.Add(item);                // data.Add(new article_model((int)datareader.GetValue(0), (String)datareader.GetValue(1),(String) datareader.GetValue(2),(String) datareader.GetValue(3), (String)datareader.GetValue(4), (String)datareader.GetValue(5),(float) datareader.GetValue(6), (int)datareader.GetValue(7), (DateTime)datareader.GetValue(8),(byte[]) datareader.GetValue(9)));
            }

    

            return data;
        }
        public List<loginclasse> ViewUser(String cmnd)
        {
            List<loginclasse> data = new List<loginclasse>();

            SqlCommand req = new SqlCommand();
            openconx();

            req.Connection = cnn;
            req.CommandType = CommandType.Text; // Changer le type de la requete en text (non pas procedure)
            req.CommandText = cmnd;
            req.Parameters.Clear();
            datareader = req.ExecuteReader();
            while (datareader.Read())
            {

                loginclasse item = new loginclasse();

                item.User = datareader.GetValue(1).ToString();
                item.Pasword = datareader.GetValue(2).ToString();
                item.Type = datareader.GetValue(3).ToString();
               
                data.Add(item);
                // data.Add(new article_model((int)datareader.GetValue(0), (String)datareader.GetValue(1),(String) datareader.GetValue(2),(String) datareader.GetValue(3), (String)datareader.GetValue(4), (String)datareader.GetValue(5),(float) datareader.GetValue(6), (int)datareader.GetValue(7), (DateTime)datareader.GetValue(8),(byte[]) datareader.GetValue(9)));
            }

         

            return data;
        }
    }
  
}
