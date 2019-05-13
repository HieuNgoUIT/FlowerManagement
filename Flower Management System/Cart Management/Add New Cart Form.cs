using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flower_Management_System.Customer_Management;
using Flower_Management_System.Database;

namespace Flower_Management_System.Cart_Management
{
    public partial class Add_New_Cart_Form : Form
    {
        public Add_New_Cart_Form()
        {
            InitializeComponent();
        }

        private void Add_New_Cart_Form_Load(object sender, EventArgs e)
        {
            Add_Cart_Form_Setting();
            Label_Setting();
            Button_Setting();
        }

        private void Add_Cart_Form_Setting()
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
            LB_Notice_1.Visible = false;
        }
        private void Label_Attribute_Setting()
        {
            System_Database_SQL A = new System_Database_SQL();
            string check_id = "select top 1 ID from Cart order by ID desc";
            string result = A.GetColumnValue(check_id).ToString();
            result = (int.Parse(result.Remove(0, 3)) + 1).ToString();
            while (result.Length < 5)
            {
                result = "0" + result;
            }

            TB_CartID.Text = "SC-" + result;

            LB_CardID.BackColor = Color.Transparent;
            LB_CustomerID.BackColor = Color.Transparent;
            LB_DateBuy.BackColor = Color.Transparent;
        }
        // -------------------------------------------------------------------------

        //      +----------------+
        //      | BUTTON SETTING |
        //      +----------------+

        // -------------------------------------------------------------------------
        private void Button_Setting()
        {
            BT_Save.FlatStyle = FlatStyle.Flat;
            BT_Save.FlatAppearance.BorderSize = 0;

            BT_CLose_Form.FlatStyle = FlatStyle.Flat;
            BT_CLose_Form.FlatAppearance.BorderSize = 0;

            BT_OpenCustomerForm.FlatStyle = FlatStyle.Flat;
            BT_OpenCustomerForm.FlatAppearance.BorderSize = 0;
        }
        // -------------------------------------------------------------------------
        private void BT_Save_Click(object sender, EventArgs e)
        {
            if (TB_CartID.Text != "" && TB_CustomerID.Text != "" && MTB_DateBuy.Text != "")
            {
                if (Save_Process() == true)
                {
                    Add_Cart_Detail_Form CD = new Add_Cart_Detail_Form();
                    CD.Show();
                    CD.ID = TB_CartID.Text;
                    this.Hide();
                }
            }
            else
            {
                return;
            }
        }
        private bool Save_Process()
        {
            System_Database_SQL A = new System_Database_SQL();
            string check_id_cart = "select ID from Cart where ID = '" + TB_CartID.Text + "'";
            if (A.Check_Exist_Value(check_id_cart) == false)
            {
                string check_id_customer = "select ID from Customer where ID = '" + TB_CustomerID.Text + "'";
                if (A.Check_Exist_Value(check_id_customer) == true)
                {
                    string add_query = "insert into Cart (ID, Customer_ID, OnDate) values"
                                             + " ('" + TB_CartID.Text + "'"
                                             + ", '" + TB_CustomerID.Text + "'"
                                             + ", '" + MTB_DateBuy.Text + "')";
                    A.Basic_Query(add_query);
                    return true;
                }
                else
                {
                    LB_Notice_2.Visible = true;
                    return false;
                }
            }
            else
            {
                LB_Notice_1.Visible = true;
                return false;
            }
        }
        private void BT_CLose_Form_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BT_OpenCustomerForm_Click(object sender, EventArgs e)
        {
            Customer_Management_Form C = new Customer_Management_Form();
            C.Show();
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
        private void BT_OpenCustomerForm_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void BT_OpenCustomerForm_MouseLeave(object sender, EventArgs e)
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
    }
}
