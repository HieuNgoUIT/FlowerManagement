using Flower_Management_System.Customer_Management;
using Flower_Management_System.Database;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Flower_Management_System.Cart_Management
{
    public partial class Add_BunchFlowers_Form : Form
    {
        string image_location;
        public Add_BunchFlowers_Form()
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

            TB_BunchFlowersID.Text = "SC-" + result;

            LB_BunchFlowersID.BackColor = Color.Transparent;
            LB_Fullname.BackColor = Color.Transparent;
            LB_Price.BackColor = Color.Transparent;
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


        }
        // -------------------------------------------------------------------------
        private void BT_Save_Click(object sender, EventArgs e)
        {
            if (TB_BunchFlowersID.Text != "" && TB_Fullname.Text != "")
            {
                if (Save_Process() == true)
                {
                    Add_BunchFlowers_Detail_Form CD = new Add_BunchFlowers_Detail_Form();
                    CD.Show();
                    CD.ID = TB_BunchFlowersID.Text;
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
            string check_id_cart = "select ID from BunchFlowersShop where ID = '" + TB_BunchFlowersID.Text + "'";
            if (A.Check_Exist_Value(check_id_cart) == false)
            {
                string add_query = "insert into BunchFlowersShop (ID, Fullname, Price,Quantity,DueDate,Picture) values"
                                         + " ('" + TB_BunchFlowersID.Text + "'"
                                         + ", '" + TB_Fullname.Text + "'"
                                         + ", '" + TB_Price.Text + "'"
                                         + ", '" + TB_Quantity.Text + "'"
                                         + ", '" + TB_DueDate.Text + "'"
                                         + ", @img)";
                A.Advance_Query(image_location, add_query);
                return true;

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
       
    }
}
