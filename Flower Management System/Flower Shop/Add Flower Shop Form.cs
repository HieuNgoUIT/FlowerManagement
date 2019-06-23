using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flower_Management_System.Database;

namespace Flower_Management_System.Flower_Management
{
    public partial class Add_FlowerShop_Form : Form
    {
        string image_location;
        System_Database_SQL Flower = new System_Database_SQL();
        public Add_FlowerShop_Form()
        {
            InitializeComponent();
        }

        private void Add_Flower_Form_Load(object sender, EventArgs e)
        {
            Add_Flower_Form_Setting();
            DataGridView_Setting();
            Database_setting();
            //Label_Setting();
            //Button_Setting();
            // PictureBox_Setting();
        }

        private void Add_Flower_Form_Setting()
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
            Label_Attribute_Setting();
        }
        private void Label_Attribute_Setting()
        {
            System_Database_SQL A = new System_Database_SQL();
            string check_id = "select top 1 ID from Flower order by ID desc";
            string result = A.GetColumnValue(check_id).ToString();
            result = (int.Parse(result.Remove(0, 2)) + 1).ToString();
            while (result.Length < 5)
            {
                result = "0" + result;
            }

            //LB_Name.Text = "Name :";
            //LB_Name.Font = new Font("Segoe UI Semibold", 14, FontStyle.Regular);
            //LB_Name.BackColor = Color.Transparent;

            //TB_ID.Text = "F-" + result;

            //LB_ID.Text = "ID :";
            //LB_ID.Font = new Font("Segoe UI Semibold", 14, FontStyle.Regular);
            //LB_ID.BackColor = Color.Transparent;

            //LB_Price.Text = "Price :";
            //LB_Price.Font = new Font("Segoe UI Semibold", 14, FontStyle.Regular);
            //LB_Price.BackColor = Color.Transparent;

            //LB_UseFor.Text = "Use For :";
            //LB_UseFor.Font = new Font("Segoe UI Semibold", 14, FontStyle.Regular);
            //LB_UseFor.BackColor = Color.Transparent;

            //LB_Country.Text = "Country :";
            //LB_Country.Font = new Font("Segoe UI Semibold", 14, FontStyle.Regular);
            //LB_Country.BackColor = Color.Transparent;
        }
        // -------------------------------------------------------------------------
        private void LB_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse_2 = new OpenFileDialog();
            browse_2.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|All Files (*.*)|*.*";
            browse_2.Title = "Select Flower Image";
            if (browse_2.ShowDialog(this) == DialogResult.OK)
            {
                image_location = browse_2.FileName.ToString();
                PB_Picture.ImageLocation = image_location;
            }
            else
            {
                image_location = "";
            }
        }
        // -------------------------------------------------------------------------
        private void LB_Browse_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        // -------------------------------------------------------------------------

        //      +----------------+
        //      | BUTTON SETTING |
        //      +----------------+

        // -------------------------------------------------------------------------
        private void Button_Setting()
        {
            Button_Save_Employee_Setting();
            Button_Close_Form_Setting();
            Button_Browse_Form_Setting();
        }
        // -------------------------------------------------------------------------
        private void Button_Save_Employee_Setting()
        {
            BT_Save.FlatStyle = FlatStyle.Flat;
            BT_Save.FlatAppearance.BorderSize = 0;
            BT_Save.Visible = false;
        }
        private void Button_Close_Form_Setting()
        {
            BT_CLose_Form.FlatStyle = FlatStyle.Flat;
            BT_CLose_Form.FlatAppearance.BorderSize = 0;
        }
        private void Button_Browse_Form_Setting()
        {
            //BT_Browse.FlatStyle = FlatStyle.Flat;
            //BT_Browse.FlatAppearance.BorderSize = 0;
        }
        // -------------------------------------------------------------------------
        private void BT_Save_Click(object sender, EventArgs e)
        {
            if (image_location != "")
            {
                Save_Process();
                BT_CLose_Form_Click(sender, e);
            }
        }
        private void Save_Process()
        {
            System_Database_SQL A = new System_Database_SQL();
            string query = @"INSERT INTO FlowerShop VALUES( ";
            byte[] a = null;
            string iDFlower = null;
            var currentIndex = Data_Grid_View.CurrentRow.Index;
            query += "'" + Data_Grid_View.Rows[currentIndex].Cells[0].Value + "',";
            query += "'" + Data_Grid_View.Rows[currentIndex].Cells[1].Value + "',";
            query += "'" + TB_Price.Text + "',";
            query += "'" + TB_UseFor.Text + "',";
            query += "'" + TB_Country.Text + "',";
            query += "'" + TB_Quantity.Text + "',";
            query += "'" + Data_Grid_View.Rows[currentIndex].Cells[3].Value + "',";
            a = (byte[])A.GetColumnValue("select Picture from Flower where ID='" + Data_Grid_View.Rows[currentIndex].Cells[0].Value + "';");
            query += "@img";       
            query += ");";
            A.Advance_Query(a, query);

            string updateFlowerQuantity = "UPDATE Flower set Quantity=Quantity-" + TB_Quantity.Text + " where ID='" + Data_Grid_View.Rows[currentIndex].Cells[0].Value + "';";
            Flower.Basic_Query(updateFlowerQuantity);
        }
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
        private byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);

            return ms.ToArray();
        }
        private void BT_Browse_Click(object sender, EventArgs e)
        {
            LB_Browse_Click(sender, e);
        }
        private void BT_CLose_Form_Click(object sender, EventArgs e)
        {
            Close();
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
        private void BT_Browse_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void BT_Browse_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
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

        //      +-----------------+
        //      | TEXTBOX SETTING |
        //      +-----------------+

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
            //this.Data_Grid_View.Columns[2].DataPropertyName = "Price";
            //this.Data_Grid_View.Columns[2].Visible = false;
            //this.Data_Grid_View.Columns[3].DataPropertyName = "UseFor";
            // this.Data_Grid_View.Columns[3].Visible = false;
           // this.Data_Grid_View.Columns[4].DataPropertyName = "Country";
            //this.Data_Grid_View.Columns[4].Visible = false;
            this.Data_Grid_View.Columns[2].DataPropertyName = "Picture";
            //  this.Data_Grid_View.Columns[5].Visible = false;
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
            //LB_Name_Data.DataBindings.Clear();
            //LB_Name_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "FullName");

            //LB_ID_Data.DataBindings.Clear();
            //LB_ID_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "ID");

            //LB_Price_Data.DataBindings.Clear();
            //LB_Price_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "Price");

            ////LB_UseFor_Data.DataBindings.Clear();
            ////LB_UseFor_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "UseFor");

            ////LB_Country_Data.DataBindings.Clear();
            ////LB_Country_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "Country");

            //LB_Quantity_Data.DataBindings.Clear();
            //LB_Quantity_Data.DataBindings.Add("Text", this.Data_Grid_View.DataSource, "Quantity");
        }


        private void TB_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }

        private void TB_ID_TextChanged(object sender, EventArgs e)
        {
            //if (TB_ID.Text != "")
            //{
            //    BT_Save.Visible = true;
            //}
            //else
            //{
            //    BT_Save.Visible = false;
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TB_Quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void LB_Money_Click(object sender, EventArgs e)
        {

        }

        private void TB_Country_TextChanged(object sender, EventArgs e)
        {

        }

        private void Data_Grid_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TB_Quantity_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
