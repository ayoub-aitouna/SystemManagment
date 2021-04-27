using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.model
{
   public class loginclasse
    {
        string user;
        string pasword;
        string type;

        public loginclasse()
        {

        }
        public loginclasse(string usr,string pswd,string type)
        {
            this.user = usr;
            this.pasword = pswd;
            this.type = type;
        }
        public string User
        {
            get { return user; }
            set { user= value ; }
        }
        public string Pasword
        {

            get { return pasword; }
            set { pasword = value; }

        }
        public string Type
        {

            get { return type; }
            set { type = value; }
        }
    }
}
