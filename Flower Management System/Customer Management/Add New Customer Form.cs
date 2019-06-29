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

namespace Flower_Management_System.Customer_Management
{
    public partial class Add_New_Customer_Form : Form
    {
        public Add_New_Customer_Form()
        {
            InitializeComponent();
        }
        private void Add_Customer_Form_Load(object sender, EventArgs e)
        {
            Add_Customer_Form_Setting();
            Label_Setting();
            Button_Setting();
        }

        private void Add_Customer_Form_Setting()
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
            string check_id = "select top 1 ID from Customer order by ID desc";
            string result = A.GetColumnValue(check_id).ToString();
            result = (int.Parse(result.Remove(0, 2)) + 1).ToString();
            while (result.Length < 5)
            {
                result = "0" + result;
            }

            LB_Name.Text = "Name :";
            LB_Name.Font = new Font("Segoe UI Semibold", 16, FontStyle.Regular);
            LB_Name.BackColor = Color.Transparent;

            TB_ID.Text = "C-" + result;

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

            LB_Notice.Visible = false;
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
        }
        // -------------------------------------------------------------------------
        private void Button_Save_Employee_Setting()
        {
            BT_Save.FlatStyle = FlatStyle.Flat;
            BT_Save.FlatAppearance.BorderSize = 0;
           // BT_Save.Visible = false;
        }
        private void Button_Close_Form_Setting()
        {
            BT_CLose_Form.FlatStyle = FlatStyle.Flat;
            BT_CLose_Form.FlatAppearance.BorderSize = 0;
        }
        // -------------------------------------------------------------------------
        private void BT_Save_Click(object sender, EventArgs e)
        {
            LB_Notice.Visible = false;
            if (Save_Process() == true)
            {
                BT_CLose_Form_Click(sender, e);
            }
            else
            {
                LB_Notice.Visible = true;
                //TB_ID.Text = "";
            }

        }
        private bool Save_Process()
        {
            System_Database_SQL A = new System_Database_SQL();
            string check_id = "select ID from Customer where ID = '" + TB_ID.Text + "'";
            if(TB_Name.Text =="" || TB_PhoneNumber.Text == "" || TB_ID.Text == "" )
            {
                // MessageBox.Show("Please fill in enough information");
                LB_Notice.Text = "Please fill in enough information";
                return false;
            }
            else
            {
                if (A.Check_Exist_Value(check_id) == false)
                {
                    string add_query = "insert into Customer (ID, FullName, Birthday, Gender, PhoneNumber, Nationality) values"
                                                                  + " ('" + TB_ID.Text + "'"
                                                                  + ", N'" + TB_Name.Text + "'" // N : recieve vietnamse language
                                                                  + ", '" + MTB_Birthday.Text + "'"
                                                                  + ", N'" + TB_Gender.Text + "'"
                                                                  + ", '" + TB_PhoneNumber.Text + "'"
                                                                  + ", '" + TB_Nationality.Text + "')";
                    A.Basic_Query(add_query);
                    return true;
                }
                else
                {
                    return false;
                }
                
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

        //      +-----------------+
        //      | TEXTBOX SETTING |
        //      +-----------------+

        // -------------------------------------------------------------------------

        private void TB_PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void LB_Notice_Click(object sender, EventArgs e)
        {

        }

        private void MTB_Birthday_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
