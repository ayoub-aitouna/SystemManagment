using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using System.Diagnostics;

namespace ProjectV1.Units
{
    public class Unit
    {
        private const int Mode_Sortee = 100;
        private const int MOde_entree = 200;
        private const int Mode_search = 300;

        public static int Mode_Sortee1
        {
            get
            {
                return Mode_Sortee;
            }
        }

        public static int MOde_entree1
        {
            get
            {
                return MOde_entree;
            }
        }

        public static int Mode_search1
        {
            get
            {
                return Mode_search;
            }
        }

        public void StyleDatagridview(DataGridView view_data,int fill)
        {
            view_data.BorderStyle = BorderStyle.None;
            view_data.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(226, 226, 226);
            view_data.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            view_data.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            view_data.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            view_data.BackgroundColor = Color.FromArgb(30, 30, 30);
            view_data.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            view_data.EnableHeadersVisualStyles = false;
            view_data.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            view_data.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            view_data.ColumnHeadersHeight = 40;

            view_data.RowTemplate.Height = 30;
            view_data.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            view_data.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            view_data.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            view_data.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            view_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            view_data.AllowUserToResizeRows = false;
            
            if (fill == 1)
            {
                view_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }

        //cette methode changer event entre evente de ajouter et de chercher
        public void mode(int _mode_,Control btn, EventHandler entree , EventHandler shearch)
        {
            List<EventHandler> events = new List<EventHandler>();

            events.Add(entree);
            events.Add(shearch);

            switch (_mode_)
            {
                case MOde_entree:
                    btn.Text = "Ajouter";
                    ClearEvents(btn, events);
                    btn.Click += events[0];
                    break;

                case Mode_search:
                    btn.Text = "Chercher";
                    ClearEvents(btn, events);
                    btn.Click += events[1];
                    break;
            }
        }


        public void mode(int _mode_, Control btn, EventHandler entree, EventHandler shearch,EventHandler sortee)
        {
            List<EventHandler> events = new List<EventHandler>();

            events.Add(entree);
            events.Add(sortee);
            events.Add(shearch);

            switch (_mode_)
            {
                case MOde_entree:
                    btn.Text = "Valider";
                    ClearEvents(btn, events);
                    btn.Click += events[0];
                    break;
                case Mode_Sortee:
                    btn.Text = "Valider";
                    ClearEvents(btn, events);
                    btn.Click += events[1];
                    break;
                case Mode_search:
                    btn.Text = "Chercher";
                    ClearEvents(btn, events);
                    btn.Click += events[2];
                    break;
            }
        }



        void ClearEvents(Control c, List<EventHandler> events)
        {
            foreach (var item in events)
            {
                Debug.WriteLine("constructor fired " + item.ToString());
                c.Click -= item;
            }
        }

        /*
       * Reset all the controls in the parent geven in the arguments
       */
        public void Controls_clear(Control C)
        {
            foreach (Control item in C.Controls)
            {
                // MessageBox.Show(item.GetType().ToString());
                if (item.GetType() == typeof(TextBox))
                    ((TextBox)item).Clear();
                if (item.GetType() == typeof(GunaTextBox))
                    ((GunaTextBox)item).Clear();
                if (item.GetType() == typeof(DateTimePicker))
                    ((DateTimePicker)item).Value = DateTime.Today;
                if (item.GetType() == typeof(RadioButton))
                    ((RadioButton)item).Checked = false;
                if (item.GetType() == typeof(PictureBox))
                    ((PictureBox)item).Image = null;
                if (item.Controls.Count != 0)
                    Controls_clear(item);
            }

        }
    }
}
