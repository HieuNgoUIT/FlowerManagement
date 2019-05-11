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

namespace Flower_Management_System.Account_Management
{
    public partial class Account_Management_Form : Form
    {
        System_Database_SQL Account = new System_Database_SQL();
        public string ID;
        public string username;
        public string password;

        public Account_Management_Form()
        {
            InitializeComponent();
        }

        private void Account_Management_Form_Load(object sender, EventArgs e)
        {
            Account_Management_Form_Setting();
            Button_Setting();
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
        private void Account_Management_Form_Setting()
        {
            this.BackColor = Color.FromArgb(237, 28, 36);
            this.TransparencyKey = Color.FromArgb(237, 28, 36);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(794, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
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
            this.Data_Grid_View.Location = new Point(36, 101);
            // -------------------------------------------------------------------------
            this.Data_Grid_View.Columns[0].DataPropertyName = "Employee_ID";
            this.Data_Grid_View.Columns[0].Width = 125;
            this.Data_Grid_View.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.Data_Grid_View.Columns[1].DataPropertyName = "Username";
            this.Data_Grid_View.Columns[1].Width = 290;
            this.Data_Grid_View.Columns[2].DataPropertyName = "Password";
            this.Data_Grid_View.Columns[2].Width = 290;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            this.Data_Grid_View.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            this.Data_Grid_View.ColumnHeadersDefaultCellStyle.ForeColor = Color.OrangeRed;
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
            this.Data_Grid_View.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            this.Data_Grid_View.DefaultCellStyle.SelectionForeColor = Color.White;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.RowHeadersVisible = false; // false : có thể chỉnh design theo ý mình
            // -------------------------------------------------------------------------
            this.Data_Grid_View.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.RowTemplate.Height = 50;
            this.Data_Grid_View.RowTemplate.ReadOnly = true;
            this.Data_Grid_View.RowTemplate.Resizable = DataGridViewTriState.False;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        // -------------------------------------------------------------------------

        //      +----------------+
        //      | BUTTON SETTING |
        //      +----------------+

        // -------------------------------------------------------------------------
        private void Button_Setting()
        {
            Button_Search_Setting();
            Button_Update_Account_Setting();
            Button_Delete_Account_Setting();
            Button_Save_Account_Setting();
            Button_Close_Form_Setting();
            Button_Refresh_Form_Setting();
        }

        // -------------------------------------------------------------------------
        private void Button_Search_Setting()
        {
            BT_Search.FlatStyle = FlatStyle.Flat;
            BT_Search.FlatAppearance.BorderSize = 0;
        }
        private void Button_Update_Account_Setting()
        {
            BT_Update.FlatStyle = FlatStyle.Flat;
            BT_Update.FlatAppearance.BorderSize = 0;
        }
        private void Button_Delete_Account_Setting()
        {
            BT_Delete.FlatStyle = FlatStyle.Flat;
            BT_Delete.FlatAppearance.BorderSize = 0;
        }
        private void Button_Save_Account_Setting()
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
            string search_name_query = "select * from Account where Employee_ID collate Latin1_General_CS_AS like N'%" + TB_Search.Text + "%'";
            this.Data_Grid_View.DataSource = Account.Search_Value_From_Database(search_name_query);
        }
        private void BT_Refresh_Click(object sender, EventArgs e)
        {
            Database_setting();
        }
        private void BT_Update_Click(object sender, EventArgs e)
        {
            Update_Account_Form U = new Update_Account_Form();
            U.Show();
            U.ID = ID;
            U.Username = username;
            U.Password = password;
        }
        private void BT_Delete_Click(object sender, EventArgs e)
        {
            string delete_query_from_Account_table = "delete from Account where Employee_ID = '" + ID + "'";
            Account.Basic_Query(delete_query_from_Account_table);
            Database_setting();
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
        private void BT_Refresh_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void BT_Refresh_MouseLeave(object sender, EventArgs e)
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

        private void BT_Save_Click(object sender, EventArgs e)
        {
            Close();
        }
        // -------------------------------------------------------------------------

        //      +------------------+
        //      | DATABASE SETTING |
        //      +------------------+

        // -------------------------------------------------------------------------
        private void Database_setting()
        {
            Get_Account_Database();
        }
        // -------------------------------------------------------------------------
        private void Get_Account_Database()
        {
            string query_SQL_command = "select * from Account order by Employee_ID asc";
            Data_Grid_View.DataSource = Account.Get_Database(query_SQL_command);
        }

        private void Data_Grid_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = this.Data_Grid_View.Rows[e.RowIndex].Cells[0].Value.ToString();
            username = this.Data_Grid_View.Rows[e.RowIndex].Cells[1].Value.ToString();
            password = this.Data_Grid_View.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        // -------------------------------------------------------------------------
    }
}
