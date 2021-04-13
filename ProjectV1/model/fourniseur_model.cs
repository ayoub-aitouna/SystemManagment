using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.model
{
    class fourniseur_model
    {
        int code_fourniseur;
        string nom;
        string email;
        string adress;
        int numerophone;
        public fourniseur_model(int code,string nom,string email,string adres,int numerophone)
        {
            this.code_fourniseur = code;
            this.nom = nom;
            this.email = email;
            this.adress = adres;
            this.numerophone = numerophone;

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
    
        public int Numerophone
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
