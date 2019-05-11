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
    public partial class Update_Account_Form : Form
    {
        public Update_Account_Form()
        {
            InitializeComponent();
        }

        private void Update_Account_Form_Load(object sender, EventArgs e)
        {
            Update_Account_Form_Setting();
            Button_Setting();
            TextBox_Setting();
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
        private void Update_Account_Form_Setting()
        {
            this.BackColor = Color.FromArgb(237, 28, 36);
            this.TransparencyKey = Color.FromArgb(237, 28, 36);
            this.FormBorderStyle = FormBorderStyle.None;
        }
        // -------------------------------------------------------------------------
        // -------------------------------------------------------------------------

        //      +----------------+
        //      | BUTTON SETTING |
        //      +----------------+

        // -------------------------------------------------------------------------
        private void Button_Setting()
        {
            Button_Set_Account_Setting();
            Button_Close_Form_Setting();
        }
        // -------------------------------------------------------------------------
        private void Button_Set_Account_Setting()
        {
            BT_Set.FlatStyle = FlatStyle.Flat;
            BT_Set.FlatAppearance.BorderSize = 0;
        }
        private void Button_Close_Form_Setting()
        {
            BT_CLose_Form.FlatStyle = FlatStyle.Flat;
            BT_CLose_Form.FlatAppearance.BorderSize = 0;
        }
        // -------------------------------------------------------------------------
        private void BT_Set_Click(object sender, EventArgs e)
        {
            LB_Notice.Visible = false;
            if (TB_Username.Text == "" || TB_Password.Text == "")
            {
                return;
            }
            else
            {
                System_Database_SQL A = new System_Database_SQL();
                string check_username = "select * from Account where Username collate Latin1_General_CS_AS = '" + TB_Username.Text + "'";
                if (A.Check_Exist_Value(check_username) == false && LB_ID.Text != "...")
                {
                    string update_query = "update Account set "
                                          + "Username = '" + TB_Username.Text + "'"
                                          + ", Password = '" + TB_Password.Text + "'"
                                          + " where Employee_ID = '" + LB_ID.Text + "'";
                    A.Basic_Query(update_query);
                    BT_CLose_Form_Click(sender, e);
                }
                else
                {
                    LB_Notice.Visible = true;
                    TB_Username.Text = "";
                }
            }
        }
        private void BT_CLose_Form_Click(object sender, EventArgs e)
        {
            Close();
        }
        // -------------------------------------------------------------------------
        private void BT_Set_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void BT_Set_MouseLeave(object sender, EventArgs e)
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

        //      +---------------+
        //      | LABEL SETTING |
        //      +---------------+

        // -------------------------------------------------------------------------
        private void LB_Set_Click(object sender, EventArgs e)
        {
            BT_Set_Click(sender, e);
        }
        // -------------------------------------------------------------------------
        private void LB_Set_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        // -------------------------------------------------------------------------

        //      +-----------------+
        //      | TEXTBOX SETTING |
        //      +-----------------+

        // -------------------------------------------------------------------------
        private void TextBox_Setting()
        {
            TextBox_Username_Setting();
            TextBox_Password_Setting();
        }
        // -------------------------------------------------------------------------
        private void TextBox_Username_Setting()
        {
            TB_Username.BorderStyle = BorderStyle.None;
            TB_Username.Font = new Font("Segoe UI Semibold", 18, FontStyle.Bold);
            TB_Username.Multiline = false;
            TB_Username.TextAlign = HorizontalAlignment.Center;
        }
        private void TextBox_Password_Setting()
        {
            TB_Password.BorderStyle = BorderStyle.None;
            TB_Password.Font = new Font("Segoe UI Semibold", 18, FontStyle.Bold);
            TB_Password.Multiline = false;
            TB_Password.TextAlign = HorizontalAlignment.Center;
        }

        public string ID
        {
            set
            {
                LB_ID.Text = value;
            }
        }
        public string Username
        {
            set
            {
                TB_Username.Text = value;
            }
        }
        public string Password
        {
            set
            {
                TB_Password.Text = value;
            }
        }
    }
}

