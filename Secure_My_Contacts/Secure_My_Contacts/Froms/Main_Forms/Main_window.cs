using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secure_My_Contacts.Froms.Main_Forms
{
    public partial class Main_window : Form
    {
        public Main_window()
        {
            InitializeComponent();
        }

        private void export_Button_Click(object sender, EventArgs e)
        {
            Export_Window Export = new Export_Window();
            Export.ShowDialog();
        }

        private void import_Button_Click(object sender, EventArgs e)
        {
            Import_Window Import = new Import_Window();
            Import.ShowDialog();
        }

        private void about_Button_Click(object sender, EventArgs e)
        {
            AboutUs_Window AboutUs = new AboutUs_Window();
            AboutUs.ShowDialog();
        }

        private void all_Contacts_Button_Click(object sender, EventArgs e)
        {
            // Visible
            Category_label.Visible = true;
            Category_comboBox.Visible = true;

            Delete_button.Visible = false;
            Restore_button.Visible = false;
            Undo_button.Visible = false;
            Select_all_button.Visible = false;
            Empty_trash_button.Visible = false;

            // Button coloring
            all_Contacts_Button.FillColor = Color.FromArgb(15, 19, 119);
            all_Contacts_Button.BorderColor = Color.RoyalBlue;
            all_Contacts_Button.ForeColor = Color.White;

            recycle_Bin_Button.FillColor = Color.FromArgb(44, 61, 80);
            recycle_Bin_Button.BorderColor = Color.FromArgb(44, 61, 80);
            recycle_Bin_Button.ForeColor = Color.FromArgb(203, 233, 255);
        }

        private void recycle_Bin_Button_Click(object sender, EventArgs e)
        {
            // Visible
            Category_label.Visible = false;
            Category_comboBox.Visible = false;

            Delete_button.Visible = false;
            Restore_button.Visible = false;
            Undo_button.Visible = false;
            Select_all_button.Visible = false;

            Empty_trash_button.Visible = true;

            // Button coloring
            recycle_Bin_Button.FillColor = Color.FromArgb(15, 19, 119);
            recycle_Bin_Button.BorderColor = Color.RoyalBlue;
            recycle_Bin_Button.ForeColor = Color.White;

            all_Contacts_Button.FillColor = Color.FromArgb(44, 61, 80);
            all_Contacts_Button.BorderColor = Color.FromArgb(44, 61, 80);
            all_Contacts_Button.ForeColor = Color.FromArgb(203, 233, 255);
        }
    }
}
