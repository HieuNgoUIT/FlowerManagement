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
using Flower_Management_System.Account_Management;

namespace Flower_Management_System.Employee_Management
{
    public partial class Add_Employee_Form : Form
    {
        public Add_Employee_Form()
        {
            InitializeComponent();
        }

        private void Add_Employee_Form_Load(object sender, EventArgs e)
        {
            Add_Employee_Form_Setting();
            Label_Setting();
            Button_Setting();
        }

        private void Add_Employee_Form_Setting()
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
            Button_Add_Account_Setting();
            Button_Close_Form_Setting();
        }
        // -------------------------------------------------------------------------
        private void Button_Save_Employee_Setting()
        {
            BT_Save.FlatStyle = FlatStyle.Flat;
            BT_Save.FlatAppearance.BorderSize = 0;
            BT_Save.Visible = false;
        }
        private void Button_Add_Account_Setting()
        {
            BT_Add.FlatStyle = FlatStyle.Flat;
            BT_Add.FlatAppearance.BorderSize = 0;
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
                TB_ID.Text = "";
            }

        }
        private bool Save_Process()
        {
            System_Database_SQL A = new System_Database_SQL();
            string check_id = "select ID from Employee where ID = '" + TB_ID.Text + "'";
            if (A.Check_Exist_Value(check_id) == false)
            {
                string add_query = "insert into Employee (ID, FullName, Birthday, Gender, PhoneNumber, Nationality, Position, Salary) values"
                                                              + " ('" + TB_ID.Text + "'"
                                                              + ", N'" + TB_Name.Text + "'" // N : recieve vietnamse language
                                                              + ", '" + MTB_Birthday.Text + "'"
                                                              + ", N'" + TB_Gender.Text + "'"
                                                              + ", '" + TB_PhoneNumber.Text + "'"
                                                              + ", N'" + TB_Nationality.Text + "'"
                                                              + ", N'" + TB_Position.Text + "'"
                                                              + ", '" + TB_Salary.Text + "')";
                A.Basic_Query(add_query);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void BT_Add_Click(object sender, EventArgs e)
        {
            if (Save_Process() == true)
            {
                Open_Add_Account_Form();
                this.Hide();
                BT_Save.Visible = true;
            }
            else
            {
                return;
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
        private void BT_Add_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void BT_Add_MouseLeave(object sender, EventArgs e)
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
        private void Open_Add_Account_Form()
        {
            Add_New_Manager_Account Add_Account_form = new Add_New_Manager_Account();
            Add_Account_form.Show();
            Add_Account_form.ID = TB_ID.Text;
        }
        // -------------------------------------------------------------------------

        //      +-----------------+
        //      | TEXTBOX SETTING |
        //      +-----------------+

        // -------------------------------------------------------------------------

        private void TB_Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }

        private void TB_PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }

        private void TB_Position_TextChanged(object sender, EventArgs e)
        {
            if (TB_ID.Text != "" && TB_Position.Text == "Manager")
            {
                BT_Add.Visible = true;
                BT_Save.Visible = false;
            }
            else
            {
                BT_Add.Visible = false;
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
    }
}
