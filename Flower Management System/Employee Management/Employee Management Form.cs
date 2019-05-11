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
using System.Threading;

namespace Flower_Management_System.Employee_Management
{
    public partial class Employee_Management_Form : Form
    {
        System_Database_SQL Employee = new System_Database_SQL();
        public Employee_Management_Form()
        {
            InitializeComponent();
        }

        // +--------------+
        // | MAIN SETTING |
        // +--------------+

        // -------------------------------------------------------------------------
        private void Employee_Management_Form_Load(object sender, EventArgs e)
        {
            Employee_Management_Form_Setting();
            Label_Setting();
            Button_Setting();
            TextBox_Setting();
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
        private void Employee_Management_Form_Setting()
        {
            this.BackColor = Color.FromArgb(237, 28, 36);
            this.TransparencyKey = Color.FromArgb(237, 28, 36);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(1120, 650);
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
            LB_Title.Text = "EMPLOYEE MANAGEMENT";
            LB_Title.Font = new Font("Impact", 25, FontStyle.Regular);
            LB_Title.Location = new Point(97, 52);
            LB_Title.BackColor = Color.Transparent;
        }
        private void Label_Attribute_Setting()
        {
            LB_Name.Text = "Name :";
            LB_Name.Font = new Font("Segoe UI Semibold", 16, FontStyle.Regular);
            LB_Name.BackColor = Color.Transparent;

            LB_ID.Text = "ID :";
            LB_ID.Font = new Font("Segoe UI Semibold", 16, FontStyle.Regular);
            LB_ID.BackColor = Color.Transparent;

            LB_Birthday.Text = "Birthday :";
            LB_Birthday.Font = new Font("Segoe UI Semibold", 16, FontStyle.Regular);
            LB_Birthday.BackColor = Color.Transparent;

            LB_Gender.Text = "Gender :";
            LB_Gender.Font = new Font("Segoe UI Semibold", 16, FontStyle.Regular);
            LB_Gender.BackColor = Color.Transparent;

            LB_Nationality.Text = "Nationality :";
            LB_Nationality.Font = new Font("Segoe UI Semibold", 16, FontStyle.Regular);
            LB_Nationality.BackColor = Color.Transparent;

            LB_Position.Text = "Position :";
            LB_Position.Font = new Font("Segoe UI Semibold", 16, FontStyle.Regular);
            LB_Position.BackColor = Color.Transparent;

            LB_Salary.Text = "Salary :";
            LB_Salary.Font = new Font("Segoe UI Semibold", 16, FontStyle.Regular);
            LB_Salary.BackColor = Color.Transparent;
        }
        private void Label_Attribute_Data_Setting()
        {
            int distance_between_attribute_label = 66;

            LB_Name_Data.Text = "...";
            LB_Name_Data.Text = LB_Name_Data.Text.ToUpper();
            LB_Name_Data.Font = new Font("Segoe UI Semibold", 16, FontStyle.Regular);
            LB_Name_Data.Location = new Point(LB_Name.Location.X + 87, LB_Name.Location.Y);
            LB_Name_Data.BackColor = Color.Transparent;

            LB_ID_Data.Text = "...";
            LB_ID_Data.Font = new Font("Segoe UI Semibold", 16, FontStyle.Regular);
            LB_ID_Data.Location = new Point(LB_ID.Location.X + 51, LB_Name.Location.Y + distance_between_attribute_label);
            LB_ID_Data.BackColor = Color.Transparent;

            LB_Birthday_Data.Text = "...";
            LB_Birthday_Data.Font = new Font("Segoe UI Semibold", 16, FontStyle.Regular);
            LB_Birthday_Data.Location = new Point(LB_Birthday.Location.X + 112, LB_Name.Location.Y + (distance_between_attribute_label * 2));
            LB_Birthday_Data.BackColor = Color.Transparent;

            LB_Gender_Data.Text = "...";
            LB_Gender_Data.Font = new Font("Segoe UI Semibold", 16, FontStyle.Regular);
            LB_Gender_Data.Location = new Point(LB_Gender.Location.X + 100, LB_Birthday.Location.Y);
            LB_Gender_Data.BackColor = Color.Transparent;

            LB_Nationality_Data.Text = "...";
            LB_Nationality_Data.Font = new Font("Segoe UI Semibold", 16, FontStyle.Regular);
            LB_Nationality_Data.Location = new Point(LB_Nationality.Location.X + 135, LB_Name.Location.Y + (distance_between_attribute_label * 3));
            LB_Nationality_Data.BackColor = Color.Transparent;

            LB_Position_Data.Text = "...";
            LB_Position_Data.Font = new Font("Segoe UI Semibold", 16, FontStyle.Regular);
            LB_Position_Data.Location = new Point(LB_Position.Location.X + 106, LB_Name.Location.Y + (distance_between_attribute_label * 4));
            LB_Position_Data.BackColor = Color.Transparent;

            LB_Salary_Data.Text = "...";
            LB_Salary_Data.Font = new Font("Segoe UI Semibold", 16, FontStyle.Regular);
            LB_Salary_Data.Location = new Point(LB_Salary.Location.X + 101, LB_Name.Location.Y + (distance_between_attribute_label * 5));
            LB_Salary_Data.BackColor = Color.Transparent;

            LB_Money_Symbol.Location = new Point(LB_Salary.Location.X + 82, LB_Name.Location.Y + (distance_between_attribute_label * 5));
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
            string search_name_query = "select * from Employee where FullName collate Latin1_General_CS_AS like N'%" + TB_Search.Text + "%'";
            this.Data_Grid_View.DataSource = Employee.Search_Value_From_Database(search_name_query);
            Bing_Data();
        }
        private void BT_Refresh_Click(object sender, EventArgs e)
        {
            TB_Search.Text = String.Empty;
            Database_setting();
        }
        private void BT_Add_Click(object sender, EventArgs e)
        {
            Open_Add_Employee_Form();
        }
        private void BT_Update_Click(object sender, EventArgs e)
        {
            Open_Update_Employee_Form();
        }
        private void BT_Delete_Click(object sender, EventArgs e)
        {
            string delete_query_from_Account_table = "delete from Account where Employee_ID = '" + LB_ID_Data.Text + "'";
            Employee.Basic_Query(delete_query_from_Account_table);
            string delete_query_from_Employee_table = "delete from Employee where ID = '" + LB_ID_Data.Text + "'";
            Employee.Basic_Query(delete_query_from_Employee_table);
            Database_setting();
        }
        private void BT_Save_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BT_CLose_Form_Click(object sender, EventArgs e)
        {
            Close();
            this.Dispose();
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
            TB_Search.Location = new Point(83, 126);
            TB_Search.BorderStyle = BorderStyle.None;
            TB_Search.Font = new Font("Segoe UI Semibold", 20, FontStyle.Bold);
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
            this.Data_Grid_View.Location = new Point(23, 204);
            // -------------------------------------------------------------------------
            this.Data_Grid_View.Columns[0].DataPropertyName = "ID";
            this.Data_Grid_View.Columns[0].Width = 124;
            this.Data_Grid_View.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.Data_Grid_View.Columns[1].DataPropertyName = "FullName";
            this.Data_Grid_View.Columns[1].Width = 420;
            this.Data_Grid_View.Columns[2].DataPropertyName = "Birthday";
            this.Data_Grid_View.Columns[2].Visible = false;
            this.Data_Grid_View.Columns[3].DataPropertyName = "Gender";
            this.Data_Grid_View.Columns[3].Visible = false;
            this.Data_Grid_View.Columns[4].DataPropertyName = "PhoneNumber";
            this.Data_Grid_View.Columns[4].Visible = false;
            this.Data_Grid_View.Columns[5].DataPropertyName = "Nationality";
            this.Data_Grid_View.Columns[5].Visible = false;
            this.Data_Grid_View.Columns[6].DataPropertyName = "Position";
            this.Data_Grid_View.Columns[6].Visible = false;
            this.Data_Grid_View.Columns[7].DataPropertyName = "Salary";
            this.Data_Grid_View.Columns[7].Visible = false;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            this.Data_Grid_View.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
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
            this.Data_Grid_View.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 15, FontStyle.Regular);
            this.Data_Grid_View.DefaultCellStyle.ForeColor = Color.Black;
            this.Data_Grid_View.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            this.Data_Grid_View.DefaultCellStyle.SelectionBackColor = Color.Black;
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
        // -------------------------------------------------------------------------

        //      +------------------+
        //      | DATABASE SETTING |
        //      +------------------+

        // -------------------------------------------------------------------------
        private void Database_setting()
        {
            Get_Employee_Database();
            Bing_Data();
        }
        // -------------------------------------------------------------------------
        private void Get_Employee_Database()
        {
            string query_SQL_command = "select * from Employee order by ID asc";
            Data_Grid_View.DataSource =  Employee.Get_Database(query_SQL_command);
        }
        public void Bing_Data()
        {
            LB_Name_Data.DataBindings.Clear();
            LB_Name_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "FullName");

            LB_ID_Data.DataBindings.Clear();
            LB_ID_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "ID");

            LB_Birthday_Data.DataBindings.Clear();
            LB_Birthday_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "Birthday");

            LB_Gender_Data.DataBindings.Clear();
            LB_Gender_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "Gender");

            LB_PhoneNumer_Data.DataBindings.Clear();
            LB_PhoneNumer_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "PhoneNumber");

            LB_Nationality_Data.DataBindings.Clear();
            LB_Nationality_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "Nationality");

            LB_Position_Data.DataBindings.Clear();
            LB_Position_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "Position");

            LB_Salary_Data.DataBindings.Clear();
            LB_Salary_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "Salary");
        }
        // -------------------------------------------------------------------------

        //      +-----------+
        //      | OPEN FORM |
        //      +-----------+

        // -------------------------------------------------------------------------
        private void Open_Add_Employee_Form()
        {
            Add_Employee_Form Add_Employee_form = new Add_Employee_Form();
            Add_Employee_form.Show();
        }
        private void Open_Update_Employee_Form()
        {
            Update_Employee_Form Update_Employee_Form = new Update_Employee_Form();
            Update_Employee_Form.Show();
            Update_Employee_Form.ID = LB_ID_Data.Text;
            Update_Employee_Form.FullName = LB_Name_Data.Text;
            Update_Employee_Form.Birthday = LB_Birthday_Data.Text;
            Update_Employee_Form.Gender = LB_Gender_Data.Text;
            Update_Employee_Form.Nationality = LB_Nationality_Data.Text;
            Update_Employee_Form.Position = LB_Position_Data.Text;
            Update_Employee_Form.Salary = LB_Salary_Data.Text;
            Update_Employee_Form.PhoneNumber = LB_PhoneNumer_Data.Text;
        }
    }
}
