using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flower_Management_System.Flower_Management;
using Flower_Management_System.Database;
using System.IO;

namespace Flower_Management_System.Cart_Management
{
    public partial class Cart_Management_Form : Form
    {
        System_Database_SQL Cart = new System_Database_SQL();

        public Cart_Management_Form()
        {
            InitializeComponent();
        }

        private void Cart_Management_Load(object sender, EventArgs e)
        {
            Cart_Management_Form_Setting();
            Label_Setting();
            Button_Setting();
            TextBox_Setting();
            PictureBox_Setting();
            DataGridView_Cart_Setting();
            DataGridView_Cart_Detail_Setting();
            Database_Cart_setting();
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
        private void Cart_Management_Form_Setting()
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
            Label_Attribute_Data_Setting();
        }

        // -------------------------------------------------------------------------
        private void Label_Title_Setting()
        {
            LB_Title.Text = "CART MANAGEMENT";
            LB_Title.Font = new Font("Impact", 25, FontStyle.Regular);
            LB_Title.BackColor = Color.Transparent;
        }
        private void Label_Attribute_Setting()
        {
            LB_CustomerID.BackColor = Color.Transparent;            
            LB_CardID.BackColor = Color.Transparent;            
            LB_DateBuy.BackColor = Color.Transparent;            
            LB_TotalPrice.BackColor = Color.Transparent;            
            LB_CustomerName.BackColor = Color.Transparent;
        }
        private void Label_Attribute_Data_Setting()
        {
            LB_CardID_Data.BackColor = Color.Transparent;
            LB_CustomerID_Data.BackColor = Color.Transparent;
            LB_CustomerName_Data.BackColor = Color.Transparent;
            LB_DateBuy_Data.BackColor = Color.Transparent;
            LB_Price_Data.BackColor = Color.Transparent;
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
            string search_name_query = "select Cart.ID, Customer_ID, Customer.FullName, OnDate, TotalPrice from Cart, Customer where Customer_ID = Customer.ID and Cart.ID like '%" + TB_Search.Text + "%'";
            this.Data_Grid_View.DataSource = Cart.Search_Value_From_Database(search_name_query);
            Bing_Cart_Data();
        }
        private void BT_Refresh_Click(object sender, EventArgs e)
        {
            Database_Cart_setting();
        }
        private void BT_Add_Click(object sender, EventArgs e)
        {
            Open_Add_Cart_Form();
        }
        private void BT_Delete_Click(object sender, EventArgs e)
        {
            string delete_query_from_CartDetail_table = "delete from CartDetail where Cart_ID = '" + LB_CardID_Data.Text + "'";
            Cart.Basic_Query(delete_query_from_CartDetail_table);
            string delete_query_from_Cart_table = "delete from Cart where ID = '" + LB_CardID_Data.Text + "'";
            Cart.Basic_Query(delete_query_from_Cart_table);
            Database_Cart_setting();
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
        private void DataGridView_Cart_Setting()
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
            this.Data_Grid_View.Columns[1].DataPropertyName = "Customer_ID";
            this.Data_Grid_View.Columns[2].DataPropertyName = "OnDate";
            this.Data_Grid_View.Columns[3].DataPropertyName = "TotalPrice";
            // -------------------------------------------------------------------------
            this.Data_Grid_View.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            this.Data_Grid_View.ColumnHeadersDefaultCellStyle.ForeColor = Color.OrangeRed;
            this.Data_Grid_View.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            this.Data_Grid_View.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // căn giữa chữ ô header
            // -------------------------------------------------------------------------
            this.Data_Grid_View.ColumnHeadersHeight = 35;
            this.Data_Grid_View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.Cursor = Cursors.Hand;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.EnableHeadersVisualStyles = false;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.DefaultCellStyle.BackColor = Color.White;
            this.Data_Grid_View.DefaultCellStyle.ForeColor = Color.Black;
            this.Data_Grid_View.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            this.Data_Grid_View.DefaultCellStyle.SelectionBackColor = Color.OrangeRed;
            this.Data_Grid_View.DefaultCellStyle.SelectionForeColor = Color.White;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.RowHeadersVisible = false; // false : có thể chỉnh design theo ý mình
                                                           // -------------------------------------------------------------------------
            this.Data_Grid_View.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.RowTemplate.Height = 35;
            this.Data_Grid_View.RowTemplate.ReadOnly = true;
            this.Data_Grid_View.RowTemplate.Resizable = DataGridViewTriState.False;
            // -------------------------------------------------------------------------
            this.Data_Grid_View.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void DataGridView_Cart_Detail_Setting()
        {
            this.DGV_CartDetail.AllowUserToAddRows = false;
            this.DGV_CartDetail.AllowUserToDeleteRows = false;
            this.DGV_CartDetail.AllowUserToResizeColumns = false;
            this.DGV_CartDetail.AllowUserToResizeRows = false;
            // -------------------------------------------------------------------------
            this.DGV_CartDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            this.DGV_CartDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            // -------------------------------------------------------------------------
            this.DGV_CartDetail.BackgroundColor = Color.White;
            // -------------------------------------------------------------------------
            this.DGV_CartDetail.BorderStyle = BorderStyle.None;
            // -------------------------------------------------------------------------
            this.DGV_CartDetail.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            // -------------------------------------------------------------------------
            this.DGV_CartDetail.MultiSelect = false;
            // -------------------------------------------------------------------------
            this.DGV_CartDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            // -------------------------------------------------------------------------
            this.DGV_CartDetail.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            this.DGV_CartDetail.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkViolet;
            this.DGV_CartDetail.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            this.DGV_CartDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // căn giữa chữ ô header
            // -------------------------------------------------------------------------
            this.DGV_CartDetail.ColumnHeadersHeight = 35;
            this.DGV_CartDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            // -------------------------------------------------------------------------
            this.DGV_CartDetail.Cursor = Cursors.Hand;
            // -------------------------------------------------------------------------
            this.DGV_CartDetail.EnableHeadersVisualStyles = false;
            // -------------------------------------------------------------------------
            this.DGV_CartDetail.DefaultCellStyle.BackColor = Color.White;
            this.DGV_CartDetail.DefaultCellStyle.ForeColor = Color.Black;
            this.DGV_CartDetail.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            this.DGV_CartDetail.DefaultCellStyle.SelectionBackColor = Color.DarkViolet;
            this.DGV_CartDetail.DefaultCellStyle.SelectionForeColor = Color.White;
            // -------------------------------------------------------------------------
            this.DGV_CartDetail.RowHeadersVisible = false; // false : có thể chỉnh design theo ý mình
                                                           // -------------------------------------------------------------------------
            this.DGV_CartDetail.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            // -------------------------------------------------------------------------
            this.DGV_CartDetail.RowTemplate.Height = 35;
            this.DGV_CartDetail.RowTemplate.ReadOnly = true;
            this.DGV_CartDetail.RowTemplate.Resizable = DataGridViewTriState.False;
            // -------------------------------------------------------------------------
            this.DGV_CartDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Data_Grid_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] imageData = (byte[])Data_Grid_View.CurrentRow.Cells[5].Value;
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
        private void Database_Cart_setting()
        {
            Get_Cart_Database();
            Bing_Cart_Data();
        }
        private void Database_Cart_Detail_setting()
        {
            Get_Cart_Detail_Database();
            Bing_Cart_Detail_Data();
        }
        // -------------------------------------------------------------------------
        private void Get_Cart_Database()
        {
            string query_SQL_command = "select Cart.ID, Customer_ID, Customer.FullName, OnDate, TotalPrice from Cart, Customer where Customer_ID = Customer.ID order by Cart.ID asc";
            Data_Grid_View.DataSource = Cart.Get_Database(query_SQL_command);
        }
        public void Bing_Cart_Data()
        {
            LB_CardID_Data.DataBindings.Clear();
            LB_CardID_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "ID");

            LB_CustomerID_Data.DataBindings.Clear();
            LB_CustomerID_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "Customer_ID");

            LB_CustomerName_Data.DataBindings.Clear();
            LB_CustomerName_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "FullName");

            LB_DateBuy_Data.DataBindings.Clear();
            LB_DateBuy_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "OnDate");

            LB_Price_Data.DataBindings.Clear();
            LB_Price_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "TotalPrice");
        }
        // -------------------------------------------------------------------------
        private void Get_Cart_Detail_Database()
        {
            string query_SQL_command = "select Cart_ID, Flower_ID, Flower.FullName, Quantity, CartDetail.Price, Flower.Picture from CartDetail, Flower, Cart where CartDetail.Cart_ID = Cart.ID and CartDetail.Flower_ID = Flower.ID order by Cart_ID asc";
            DGV_CartDetail.DataSource = Cart.Get_Database(query_SQL_command);
        }
        public void Bing_Cart_Detail_Data()
        {
            //LB_CardID_Data.DataBindings.Clear();
            //LB_CardID_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "ID");

            //LB_CustomerID_Data.DataBindings.Clear();
            //LB_CustomerID_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "Customer_ID");

            //LB_CustomerName_Data.DataBindings.Clear();
            //LB_CustomerName_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "FullName");

            //LB_DateBuy_Data.DataBindings.Clear();
            //LB_DateBuy_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "OnDate");

            //LB_Price_Data.DataBindings.Clear();
            //LB_Price_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "TotalPrice");
        }
        private void DGV_CartDetail_Click(object sender, EventArgs e)
        {
            byte[] imageData = (byte[])DGV_CartDetail.CurrentRow.Cells[5].Value;
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

        //      +-----------+
        //      | OPEN FORM |
        //      +-----------+

        // -------------------------------------------------------------------------
        private void Open_Add_Cart_Form()
        {
            Add_New_Cart_Form add_cart_form = new Add_New_Cart_Form();
            add_cart_form.Show();
        }
        private void Open_Update_Cart_Form()
        {
            Update_Flower_Form Update_Employee_Form = new Update_Flower_Form();
            Update_Employee_Form.Show();
            Update_Employee_Form.ID = LB_CardID_Data.Text;
            Update_Employee_Form.FullName = LB_CustomerName_Data.Text;
            Update_Employee_Form.Price = LB_Price_Data.Text;
            Update_Employee_Form.Flower_Image = PB_Picture.Image;
        }

        private void LB_CardID_Data_TextChanged(object sender, EventArgs e)
        {
            string query_SQL_command = "select Cart_ID, Flower_ID, Flower.FullName, Quantity, CartDetail.Price, Flower.Picture from CartDetail, Flower, Cart where CartDetail.Cart_ID = Cart.ID and Cart.ID = '" + LB_CardID_Data.Text + "' and CartDetail.Flower_ID = Flower.ID order by Cart_ID asc";
            DGV_CartDetail.DataSource = Cart.Get_Database(query_SQL_command);
        }
    }
}
