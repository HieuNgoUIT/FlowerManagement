using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Flower_Management_System.Database;

namespace Flower_Management_System.Flower_Management
{
    public partial class Update_Flower_Form : Form
    {
        string image_location = "";
        public Update_Flower_Form()
        {
            InitializeComponent();
        }

        private void Update_Flower_Form_Load(object sender, EventArgs e)
        {
            Update_Flower_Form_Setting();
            Label_Setting();
            Button_Setting();
            PictureBox_Setting();
            TextBox_Setting();
        }

        private void Update_Flower_Form_Setting()
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
        // -------------------------------------------------------------------------
        private void LB_Browse_Click(object sender, EventArgs e)
        {
            BT_Browse_Click(sender, e);
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
            Save_Process();
            BT_CLose_Form_Click(sender, e);
        }
        private void Save_Process()
        {
            System_Database_SQL U = new System_Database_SQL();
            if (image_location != "")
            {
                string update_query = "update FLower set "
                                  + "FullName = N'" + TB_Name.Text + "'"
                                  + ", Price = '" + TB_Price.Text + "'"
                                  + ", UseFor = N'" + TB_UseFor.Text + "'"
                                  + ", Country = '" + TB_Country.Text + "'"
                                  + ", Picture = @img"
                                  + " where ID = '" + TB_ID.Text + "'";
                U.Advance_Query(image_location, update_query);
            }
            else
            {
                string update_query = "update FLower set "
                                  + "FullName = N'" + TB_Name.Text + "'"
                                  + ", Price = '" + TB_Price.Text + "'"
                                  + ", UseFor = N'" + TB_UseFor.Text + "'"
                                  + ", Country = '" + TB_Country.Text + "'"
                                  + " where ID = '" + TB_ID.Text + "'";
                U.Basic_Query(update_query);
            }
        }
        private void BT_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|All Files (*.*)|*.*";
            browse.Title = "Select Flower Image";
            if (browse.ShowDialog() == DialogResult.OK)
            {
                image_location = browse.FileName.ToString();
                PB_Picture.ImageLocation = image_location;
            }
            else
            {
                image_location = "";
            }
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
            this.PB_Picture.BackgroundImageLayout = ImageLayout.Stretch;
            // -------------------------------------------------------------------------
            this.PB_Picture.Size = new Size(345, 378);
        }
        // -------------------------------------------------------------------------

        //      +-----------------+
        //      | TEXTBOX SETTING |
        //      +-----------------+

        // -------------------------------------------------------------------------
        private void TextBox_Setting()
        {
            TB_ID.ReadOnly = true;
            TB_ID.Enabled = true;
        }
        // -------------------------------------------------------------------------
        private void TB_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }
        // -------------------------------------------------------------------------

        public string FullName
        {
            set
            {
                TB_Name.Text = value;
            }
        }
        public string ID
        {
            set
            {
                TB_ID.Text = value;
            }
        }
        public string Price
        {
            set
            {
                TB_Price.Text = value;
            }
        }
        public string UseFor
        {
            set
            {
                TB_UseFor.Text = value;
            }
        }
        public string Country
        {
            set
            {
                TB_Country.Text = value;
            }
        }
        public Image Flower_Image
        {
            set
            {
                PB_Picture.Image = value;
            }
        }
    }
}
