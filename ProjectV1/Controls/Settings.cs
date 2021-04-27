using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectV1.sql;
using ProjectV1.model;

namespace ProjectV1.Controls
{
    public partial class Settings : UserControl
    {
        public Units.Unit _units = new Units.Unit();
        public Settings()
        {
            InitializeComponent();
        }

      

        private void Settings_Load(object sender, EventArgs e)
        {
            _units.StyleDatagridview(view_data,1);
            if (!view.IsBusy)
            {
                view.RunWorkerAsync("select * from logine");
            }
        }
        private void view_DoWork(object sender, DoWorkEventArgs e)
        {
            sqlcn SqlConnection = new sqlcn();
            e.Result = SqlConnection.ViewUser(e.Argument.ToString());
        }

        private void view_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            setview_data((List<loginclasse>)e.Result);
        }

        private void setview_data(List<loginclasse> data)
        {

            view_data.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(12, 66, 132);
            view_data.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            view_data.DataSource = data;
           // view_data.Columns["ref"].Visible = false;
           
        }
    }
}
