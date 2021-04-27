using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.model
{
    class Articl_sortie
    {
        int id;
        String Barcode;
        string nom;
        String description_inter;
        String descroption_fabrication;
        String code_fabrication;
        double prix;
        int Quontitier;
        DateTime date_entre;
        DateTime date_sortie;
        String matricul;
        Byte[] img;


        public Articl_sortie()
        {
           
        }

        public Articl_sortie(int id, string barcode, string nom, string description_inter, string descroption_fabrication, string code_fabrication, double prix, int quontitier, DateTime date_entre, DateTime date_sortie, string matricul, byte[] img)
        {
            this.id = id;
            this.Barcode = barcode;
            this.nom = nom;
            this.description_inter = description_inter;
            this.descroption_fabrication = descroption_fabrication;
            this.code_fabrication = code_fabrication;
            this.prix = prix;
            this.Quontitier = quontitier;
            this.date_entre = date_entre;
            this.date_sortie = date_sortie;
            this.matricul = matricul;
            this.img = img;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Barcode1
        {
            get
            {
                return Barcode;
            }

            set
            {
                Barcode = value;
            }
        }

        public string Nom
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

        public string Description_inter
        {
            get
            {
                return description_inter;
            }

            set
            {
                description_inter = value;
            }
        }

        public string Descroption_fabrication
        {
            get
            {
                return descroption_fabrication;
            }

            set
            {
                descroption_fabrication = value;
            }
        }

        public string Code_fabrication
        {
            get
            {
                return code_fabrication;
            }

            set
            {
                code_fabrication = value;
            }
        }

        public double Prix
        {
            get
            {
                return prix;
            }

            set
            {
                prix = value;
            }
        }

        public int Quontitier1
        {
            get
            {
                return Quontitier;
            }

            set
            {
                Quontitier = value;
            }
        }

        public DateTime Date_entre
        {
            get
            {
                return date_entre;
            }

            set
            {
                date_entre = value;
            }
        }

        public DateTime Date_sortie
        {
            get
            {
                return date_sortie;
            }

            set
            {
                date_sortie = value;
            }
        }

        public string Matricul
        {
            get
            {
                return matricul;
            }

            set
            {
                matricul = value;
            }
        }

        public byte[] Img
        {
            get
            {
                return img;
            }

            set
            {
                img = value;
            }
        }
    }
}
