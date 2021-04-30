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
using System.Data.SqlClient;
using ProjectV1.Encrypting;

namespace ProjectV1.Controls
{
    public partial class Settings : UserControl
    {
        public Units.Unit _units = new Units.Unit();
        sqlcn SqlConnection = new sqlcn();
        public Settings()
        {
            InitializeComponent();
        }

      

        private void Settings_Load(object sender, EventArgs e)
        {
            _units.StyleDatagridview(view_data,1);
            progesabar.Hide();
            if (!view.IsBusy)
            {
                view.RunWorkerAsync("select * from logine");
            }
        }
        private void view_DoWork(object sender, DoWorkEventArgs e)
        {
          
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

        private void upload_Click(object sender, EventArgs e)
        {
            loginclasse User = new loginclasse();
            User.User = Username.Text;
            User.Pasword = new Hash().Hashing(Password.Text);
            User.Type = type.SelectedText;
            progesabar.Show(); 
            if (!add.IsBusy)
            {
                add.RunWorkerAsync(User);
            }
        }

        private void add_DoWork(object sender, DoWorkEventArgs e)
        {
            loginclasse user = (loginclasse)e.Argument;
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@user", SqlDbType.VarChar, 40);
            param[0].Value = user.User;

            param[1] = new SqlParameter("@pass", SqlDbType.VarChar, 250);
            param[1].Value = user.Pasword;

            param[2] = new SqlParameter("@type", SqlDbType.VarChar, 40);
            param[2].Value = user.Type;

            SqlConnection.ExuteCommende("Add_User", param);
        }

        private void add_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progesabar.Hide();
            Username.Text = "";
            type.Text = "";
            type.SelectedValue = "";
            if (!view.IsBusy)
            {
                view.RunWorkerAsync("select * from logine");
            }
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
