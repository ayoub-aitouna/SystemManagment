using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectV1.model;
using System.Drawing.Printing;
using System.IO;

namespace ProjectV1
{
    public partial class add_success : Form
    {
        string prgf;
        // generate a file name as the current date/time in unix timestamp format
        string file = "Article_entree"+(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds.ToString();

        // the directory to store the output.
        string  directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

       

        public add_success(article_model data)
        {
             prgf = @"Barcode " + data.Barcode1 + "\n Desination " + data.Nom + "\n quantitie " + data.Quontitier1 + "\n Prix " + data.Prix
                + "\n description_inter " + data.Description_inter + "\n descroption_fabrication " + data.Descroption_fabrication +
                "\n Date " + data.Date_entre;
            ;
            InitializeComponent();
        
        }
        public add_success(equipement_model equipement)
        {
            string prgf = @"code :"+equipement.CODE+"matricul :"+equipement.Matrucil +"nom :"+equipement.Nom_equipment;
            
            InitializeComponent();

        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           

            e.Graphics.DrawString(prgf, new Font("Neometric", 10, FontStyle.Regular), Brushes.Black, new Point(100, 50));

        }

        private void print_Click(object sender, EventArgs e)
        {

            printDialog.Document = printDocument;
            printDialog.ShowDialog();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
          
            string outfile = directory +@"\"+ file+".pdf"; 
            printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDocument.PrinterSettings.PrintToFile = true;
            if (!string.IsNullOrEmpty(outfile)) printDocument.PrinterSettings.PrintFileName = outfile;
            printDocument.Print();
            save.Text = "enregistrée";


        }
    }
}
