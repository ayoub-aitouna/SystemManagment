using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.model
{
   public class equipement_model
    {
        int code;
        string nom_equipement;
        string matricil;
        public equipement_model()
        {

        }
        public equipement_model(int codee,string nome_equipement,string matricule)
        {
            this.code = codee;
            this.nom_equipement = nome_equipement;
            this.matricil = matricule;
        }
        public int CODE { get { return code; } set { code = value; } }
        public string Nom_equipment { get { return nom_equipement; } set { nom_equipement = value; } }
        public string Matrucil { get { return matricil; } set { matricil = value; } }


    }
}
