using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flower_Management_System.Database;
using Flower_Management_System.Customer_Management;
using System.IO;

namespace Flower_Management_System.Flower_Management
{
    public partial class Flower_Management_Form : Form
    {
        System_Database_SQL Flower = new System_Database_SQL();

        public Flower_Management_Form()
        {
            InitializeComponent();
        }

        // +--------------+
        // | MAIN SETTING |
        // +--------------+
        // -------------------------------------------------------------------------
        private void Flower_Management_Form_Load(object sender, EventArgs e)
        {
            Flower_Management_Form_Setting();
            Label_Setting();
            Button_Setting();
            TextBox_Setting();
            PictureBox_Setting();
            DataGridView_Setting();
            Database_setting();
        }

        // -------------------------------------------------------------------------

        // +------------------+
        // | FUNCTION SETTING |
        // +------------------+

        // -------------------------------------------------------------------------

        //      +--------------+
        //      | FORM SETTING |
        //      +--------------+

        // -------------------------------------------------------------------------
        private void Flower_Management_Form_Setting()
        {
            this.BackColor = Color.FromArgb(237, 28, 36);
            this.TransparencyKey = Color.FromArgb(237, 28, 36);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        // -------------------------------------------------------------------------

        //      +---------------+
        //      | LABEL SETTING |
        //      +---------------+

        // -------------------------------------------------------------------------
        private void Label_Setting()
        {
            Label_Title_Setting();
            Label_Attribute_Setting();
        }

        // -------------------------------------------------------------------------
        private void Label_Title_Setting()
        {
            LB_Title.Text = "FLOWER MANAGEMENT";
            LB_Title.Font = new Font("Impact", 25, FontStyle.Regular);
            LB_Title.BackColor = Color.Transparent;
        }
        private void Label_Attribute_Setting()
        {
            LB_Name.Text = "Name :";
            LB_Name.Font = new Font("Segoe UI Semibold", 14, FontStyle.Regular);
            LB_Name.BackColor = Color.Transparent;

            LB_ID.Text = "ID :";
            LB_ID.Font = new Font("Segoe UI Semibold", 14, FontStyle.Regular);
            LB_ID.BackColor = Color.Transparent;

            LB_Price.Text = "Price :";
            LB_Price.Font = new Font("Segoe UI Semibold", 14, FontStyle.Regular);
            LB_Price.BackColor = Color.Transparent;

            LB_UseFor.Text = "Use For :";
            LB_UseFor.Font = new Font("Segoe UI Semibold", 14, FontStyle.Regular);
            LB_UseFor.BackColor = Color.Transparent;

            LB_Country.Text = "Country :";
            LB_Country.Font = new Font("Segoe UI Semibold", 14, FontStyle.Regular);
            LB_Country.BackColor = Color.Transparent;
        }
        private void Label_Attribute_Data_Setting()
        {
            LB_Name_Data.Text = "...";
            LB_Name.Font = new Font("Segoe UI Semibold", 14, FontStyle.Regular);
            LB_Name_Data.BackColor = Color.Transparent;

            LB_ID_Data.Text = "...";
            LB_Name.Font = new Font("Segoe UI Semibold", 14, FontStyle.Regular);
            LB_ID_Data.BackColor = Color.Transparent;

            LB_Price_Data.Text = "...";
            LB_Name.Font = new Font("Segoe UI Semibold", 14, FontStyle.Regular);
            LB_Price_Data.BackColor = Color.Transparent;

            LB_Country_Data.Text = "...";
            LB_Name.Font = new Font("Segoe UI Semibold", 14, FontStyle.Regular);
            LB_Country_Data.BackColor = Color.Transparent;
        }
        // -------------------------------------------------------------------------

        //      +----------------+
        //      | BUTTON SETTING |
        //      +----------------+

        // -------------------------------------------------------------------------
        private void Button_Setting()
        {
            Button_Search_Setting();
            Button_Add_Employee_Setting();
            Button_Update_Employee_Setting();
            Button_Delete_Employee_Setting();
            Button_Save_Employee_Setting();
            Button_Close_Form_Setting();
            Button_Refresh_Form_Setting();
        }

        // -------------------------------------------------------------------------
        private void Button_Search_Setting()
        {
            BT_Search.FlatStyle = FlatStyle.Flat;
            BT_Search.FlatAppearance.BorderSize = 0;
        }
        private void Button_Add_Employee_Setting()
        {
            BT_Add.FlatStyle = FlatStyle.Flat;
            BT_Add.FlatAppearance.BorderSize = 0;
        }
        private void Button_Update_Employee_Setting()
        {
            BT_Update.FlatStyle = FlatStyle.Flat;
            BT_Update.FlatAppearance.BorderSize = 0;
        }
        private void Button_Delete_Employee_Setting()
        {
            BT_Delete.FlatStyle = FlatStyle.Flat;
            BT_Delete.FlatAppearance.BorderSize = 0;
        }
        private void Button_Save_Employee_Setting()
        {
            BT_Save.FlatStyle = FlatStyle.Flat;
            BT_Save.FlatAppearance.BorderSize = 0;
        }
        private void Button_Close_Form_Setting()
        {
            BT_CLose_Form.FlatStyle = FlatStyle.Flat;
            BT_CLose_Form.FlatAppearance.BorderSize = 0;
        }
        private void Button_Refresh_Form_Setting()
        {
            BT_Refresh.FlatStyle = FlatStyle.Flat;
            BT_Refresh.FlatAppearance.BorderSize = 0;
        }
        // -------------------------------------------------------------------------
        private void BT_Search_Click(object sender, EventArgs e)
        {
            string search_name_query = "select * from Flower where FullName collate Latin1_General_CS_AS like N'%" + TB_Search.Text + "%'";
            this.Data_Grid_View.DataSource = Flower.Search_Value_From_Database(search_name_query);
            Bing_Data();
        }
        private void BT_Refresh_Click(object sender, EventArgs e)
        {
            Database_setting();
        }
        private void BT_Add_Click(object sender, EventArgs e)
        {
            Open_Add_Flower_Form();
        }
        private void BT_Update_Click(object sender, EventArgs e)
        {
            Open_Update_Flower_Form();
        }
        private void BT_Delete_Click(object sender, EventArgs e)
        {
            string delete_query_from_Customer_table = "delete from Flower where ID = '" + LB_ID_Data.Text + "'";
            Flower.Basic_Query(delete_query_from_Customer_table);
            Database_setting();
        }
        private void BT_Save_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BT_CLose_Form_Click(object sender, EventArgs e)
        {
            Close();
        }
        // -------------------------------------------------------------------------
        private void BT_Search_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void BT_Search_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        // -------------------------------------------------------------------------
        private void BT_Add_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void BT_Add_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        // -------------------------------------------------------------------------
        private void BT_Update_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void BT_Update_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        // -------------------------------------------------------------------------
        private void BT_Delete_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void BT_Delete_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        // -------------------------------------------------------------------------
        private void BT_Save_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void BT_Save_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        // -------------------------------------------------------------------------
        private void BT_CLose_Form_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void BT_CLose_Form_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        // -------------------------------------------------------------------------
        private void BT_Refresh_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void BT_Refresh_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        // -------------------------------------------------------------------------

        //      +-----------------+
        //      | TEXTBOX SETTING |
        //      +-----------------+

        // -------------------------------------------------------------------------
        private void TextBox_Setting()
        {
            TextBox_Search_Setting();
        }
        // -------------------------------------------------------------------------
        private void TextBox_Search_Setting()
        {
            TB_Search.BorderStyle = BorderStyle.None;
            TB_Search.Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold);
            TB_Search.Multiline = false;
            TB_Search.TextAlign = HorizontalAlignment.Center;
        }
        // -------------------------------------------------------------------------

        //      +----------------------+
        //      | DATAGRIDVIEW SETTING |
        //      +----------------------+

        // -------------------------------------------------------------------------
        private void DataGridView_Setting()
        {
            this.Data_Grid_View.AllowUserToAddRows = false;
            this.Data_Grid_View.AllowUserToDeleteRows = false;
            this.Data_Grid_View.AllowUserToResizeColumns = false;
            this.Data_Grid_View.AllowUserToResizeRows = false;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            this.Data_Grid_View.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.BackgroundColor = Color.White;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.BorderStyle = BorderStyle.None;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.MultiSelect = false;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.Columns[0].DataPropertyName = "ID";
            this.Data_Grid_View.Columns[0].Width = 110;
            this.Data_Grid_View.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.Data_Grid_View.Columns[1].DataPropertyName = "FullName";
            this.Data_Grid_View.Columns[1].Width = 275;
            this.Data_Grid_View.Columns[2].DataPropertyName = "Price";
            this.Data_Grid_View.Columns[2].Visible = false;
            this.Data_Grid_View.Columns[3].DataPropertyName = "UseFor";
            this.Data_Grid_View.Columns[3].Visible = false;
            this.Data_Grid_View.Columns[4].DataPropertyName = "Country";
            this.Data_Grid_View.Columns[4].Visible = false;
            this.Data_Grid_View.Columns[5].DataPropertyName = "Picture";
            this.Data_Grid_View.Columns[5].Visible = false;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            this.Data_Grid_View.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            this.Data_Grid_View.ColumnHeadersDefaultCellStyle.ForeColor = Color.Navy;
            this.Data_Grid_View.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            this.Data_Grid_View.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // căn giữa chữ ô header
                                                                                                                     // -------------------------------------------------------------------------
            this.Data_Grid_View.ColumnHeadersHeight = 50;
            this.Data_Grid_View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.Cursor = Cursors.Hand;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.EnableHeadersVisualStyles = false;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.DefaultCellStyle.BackColor = Color.White;
            this.Data_Grid_View.DefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            this.Data_Grid_View.DefaultCellStyle.ForeColor = Color.Black;
            this.Data_Grid_View.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            this.Data_Grid_View.DefaultCellStyle.SelectionBackColor = Color.MediumPurple;
            this.Data_Grid_View.DefaultCellStyle.SelectionForeColor = Color.White;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.RowHeadersVisible = false; // false : có thể chỉnh design theo ý mình
                                                           // -------------------------------------------------------------------------
            this.Data_Grid_View.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.RowTemplate.Height = 49;
            this.Data_Grid_View.RowTemplate.ReadOnly = true;
            this.Data_Grid_View.RowTemplate.Resizable = DataGridViewTriState.False;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Data_Grid_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] imageData = (byte[])Data_Grid_View.CurrentRow.Cells[7].Value;
            try
            {
                MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length);
                ms.Write(imageData, 0, imageData.Length);
                PB_Picture.Image = Image.FromStream(ms, true);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        // -------------------------------------------------------------------------

        //      +--------------------+
        //      | PICTUREBOX SETTING |
        //      +--------------------+

        // -------------------------------------------------------------------------
        private void PictureBox_Setting()
        {
            this.PB_Picture.BackColor = Color.Transparent;
            this.PB_Picture.BackgroundImageLayout = ImageLayout.Center;
            // -------------------------------------------------------------------------
            this.PB_Picture.Size = new Size(345, 378);
            this.PB_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        // -------------------------------------------------------------------------

        //      +------------------+
        //      | DATABASE SETTING |
        //      +------------------+

        // -------------------------------------------------------------------------
        private void Database_setting()
        {
            Get_Flower_Database();
            Bing_Data();
        }
        // -------------------------------------------------------------------------
        private void Get_Flower_Database()
        {
            string query_SQL_command = "select * from Flower order by ID asc";
            Data_Grid_View.DataSource = Flower.Get_Database(query_SQL_command);
        }
        public void Bing_Data()
        {
            LB_Name_Data.DataBindings.Clear();
            LB_Name_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "FullName");

            LB_ID_Data.DataBindings.Clear();
            LB_ID_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "ID");

            LB_Price_Data.DataBindings.Clear();
            LB_Price_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "Price");

            LB_UseFor_Data.DataBindings.Clear();
            LB_UseFor_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "UseFor");

            LB_Country_Data.DataBindings.Clear();
            LB_Country_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "Country");

            LB_Quantity_Data.DataBindings.Clear();
            LB_Quantity_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "Quantity");
        }
        // -------------------------------------------------------------------------

        //      +-----------+
        //      | OPEN FORM |
        //      +-----------+

        // -------------------------------------------------------------------------
        private void Open_Add_Flower_Form()
        {
            Add_Flower_Form add_flower_form = new Add_Flower_Form();
            add_flower_form.Show();
        }
        private void Open_Update_Flower_Form()
        {
            Update_Flower_Form Update_Employee_Form = new Update_Flower_Form();
            Update_Employee_Form.Show();
            Update_Employee_Form.ID = LB_ID_Data.Text;
            Update_Employee_Form.FullName = LB_Name_Data.Text;
            Update_Employee_Form.Price = LB_Price_Data.Text;
            Update_Employee_Form.UseFor = LB_UseFor_Data.Text;
            Update_Employee_Form.Country = LB_Country_Data.Text;
            Update_Employee_Form.Flower_Image = PB_Picture.Image;
        }
    }
}
