using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.model
{
  public  class model_client
    {
        int code_client;
        string nom_client;
        string email_client;
        string adress_client;
        string numerophone_client;
        public model_client(int code, string nom, string email, string adres, string numerophone)
        {
            this.code_client = code;
            this.nom_client = nom;
            this.email_client = email;
            this.adress_client = adres;
            this.numerophone_client = numerophone;

        }
        public model_client()
        {


        }
        public int Code_client
        {
            get
            {
                return code_client;
            }
            set
            {
                code_client = value;
            }
        }
        public String Nom_client
        {
            get
            {
                return nom_client;
            }
            set
            {
                nom_client = value;
            }
        }
        public string Email_client
        {

            get
            {
                return email_client;
            }
            set
            {
                email_client = value;
            }
        }
        public string Adress_client
        {
            get
            {
                return adress_client;
            }
            set
            {
                adress_client = value;
            }

        }

        public string Numerophone_client
        {
            get
            {
                return numerophone_client;
            }
            set
            {
                numerophone_client = value;
            }


        }
    }
}
