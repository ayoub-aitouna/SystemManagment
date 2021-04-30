using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.model
{
  public  class fourniseur_model
    {

        int _ref;
        int code_fourniseur;
        string nom;
        string email;
        string adress;
        string numerophone;
        string fax;
        public fourniseur_model(int code,string nom,string email,string adres,string numerophone,string fax)
        {
            this.code_fourniseur = code;
            this.nom = nom;
            this.email = email;
            this.adress = adres;
            this.numerophone = numerophone;
            this.fax = fax;

        }
        public fourniseur_model()
        {
           

        }
        public int Ref
        {
            get
            {
                return _ref;
            }

            set
            {
                _ref = value;
            }
        }
        
        public int Code_fourniseur
        {
            get
            {
                return code_fourniseur;
            }
            set
            {
              code_fourniseur = value ;
            }
        }
        public String Fax
        {
            get
            {
                return fax;
            }
            set
            {
                fax = value;
            }
        }
        public String Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }
        public string Email
        {

            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                adress = value;
            }

        }
    
        public string Numerophone
        {
            get
            {
                return numerophone;
            }
            set
            {
                numerophone = value;
            }


        }

       
    }
}
