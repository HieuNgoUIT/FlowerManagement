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

namespace Flower_Management_System.Employee_Management
{
    public partial class Update_Employee_Form : Form
    {
        public Update_Employee_Form()
        {
            InitializeComponent();
        }

        private void Update_Employee_Form_Load(object sender, EventArgs e)
        {
            Update_Employee_Form_Setting();
            Button_Setting();
            TextBox_Setting();
        }

        private void Update_Employee_Form_Setting()
        {
            this.BackColor = Color.FromArgb(237, 28, 36);
            this.TransparencyKey = Color.FromArgb(237, 28, 36);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
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
        }
        private void Button_Close_Form_Setting()
        {
            BT_CLose_Form.FlatStyle = FlatStyle.Flat;
            BT_CLose_Form.FlatAppearance.BorderSize = 0;
        }
        // -------------------------------------------------------------------------
        private void BT_Save_Click(object sender, EventArgs e)
        {
            System_Database_SQL A = new System_Database_SQL();
            string update_query = "update Employee set "
                                  + "FullName = N'" + TB_Name.Text + "'"
                                  + ", Birthday = '" + MTB_Birthday.Text + "'"
                                  + ", Gender = N'" + TB_Gender.Text + "'"
                                  + ", PhoneNumber = '" + TB_PhoneNumber.Text + "'"
                                  + ", Nationality = N'" + TB_Nationality.Text + "'"
                                  + ", Position = N'" + TB_Position.Text + "'"
                                  + ", Salary = '" + TB_Salary.Text + "'"
                                  + " where ID = '" + TB_ID.Text + "'";

            A.Basic_Query(update_query);
            BT_CLose_Form_Click(sender, e);
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
        private void TextBox_Setting()
        {
            TB_ID.ReadOnly = true;
            TB_ID.Enabled = true;
        }
        // -------------------------------------------------------------------------

        //      +-----------------+
        //      | DATABASE SETTING |
        //      +-----------------+

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
        public string Birthday
        {
            set
            {
                MTB_Birthday.Text = value;
            }
        }
        public string Gender
        {
            set
            {
                TB_Gender.Text = value;
            }
        }
        public string PhoneNumber
        {
            set
            {
                TB_PhoneNumber.Text = value;
            }
        }
        public string Nationality
        {
            set
            {
                TB_Nationality.Text = value;
            }
        }
        public string Position
        {
            set
            {
                TB_Position.Text = value;
            }
        }
        public string Salary
        {
            set
            {
                TB_Salary.Text = value;
            }
        }
    }
}
