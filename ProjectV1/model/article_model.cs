using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.model
{
   public class article_model
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
        Byte[] img;
        public article_model()
        {

        }
        public article_model(int id , String Barcode, string nom,
        String description_inter,
        String descroption_fabrication,
        String code_fabrication,
        double prix,
        int Quontitier,
        DateTime date_entre,
        Byte[] img)
        {
            this.id = id;
            this.Barcode = Barcode;
            this.nom = nom;
            this.description_inter = description_inter;
            this.descroption_fabrication = descroption_fabrication;
            this.code_fabrication = code_fabrication;
            this.prix = prix;
            this.Quontitier = Quontitier;
            this.date_entre = date_entre;
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

        public Byte[] Img
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
