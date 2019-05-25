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

namespace Flower_Management_System.Flower_Management
{
    public partial class Add_Flower_Form : Form
    {
        string image_location;
        public Add_Flower_Form()
        {
            InitializeComponent();
        }

        private void Add_Flower_Form_Load(object sender, EventArgs e)
        {
            Add_Flower_Form_Setting();
            Label_Setting();
            Button_Setting();
            PictureBox_Setting();
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

            LB_Name.Text = "Name :";
            LB_Name.Font = new Font("Segoe UI Semibold", 14, FontStyle.Regular);
            LB_Name.BackColor = Color.Transparent;

            TB_ID.Text = "F-" + result;

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
            BT_Browse.FlatStyle = FlatStyle.Flat;
            BT_Browse.FlatAppearance.BorderSize = 0;
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
            string check_id = "select ID from Flower where ID = '" + TB_ID.Text + "'";
            if (A.Check_Exist_Value(check_id) == false)
            {
                string add_query = "insert into Flower (ID, FullName, Price, UseFor, Country, Quantity ,Picture) values"
                                                       + " ('" + TB_ID.Text + "'"
                                                       + ", '" + TB_Name.Text + "'"
                                                       + ", '" + TB_Price.Text + "'"
                                                       + ", '" + TB_UseFor.Text + "'"
                                                       + ", '" + TB_Country.Text + "'"
                                                       + ", '" + TB_Quantity.Text + "'"
                                                       + ", @img)";
                A.Advance_Query(image_location, add_query);
            }
            else
            {
                LB_Notice.Visible = true;
            }
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
            if (TB_ID.Text != "")
            {
                BT_Save.Visible = true;
            }
            else
            {
                BT_Save.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
