using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flower_Management_System.Cart_Management;
using Flower_Management_System.Employee_Management;
using Flower_Management_System.Flower_Management;
using Flower_Management_System.Customer_Management;

namespace Flower_Management_System
{
    public partial class Main_Form : Form
    {
        public Main_Form(string role)
        {
            InitializeComponent();
            if(role=="employee")
            {
                BT_Employee_Management.Hide();
            }
            
        }


        private void Main_Form_Load(object sender, EventArgs e)
        {
            BT_Customer_Management.FlatStyle = FlatStyle.Flat;
            BT_Customer_Management.FlatAppearance.BorderSize = 0;

            BT_Employee_Management.FlatStyle = FlatStyle.Flat;
            BT_Employee_Management.FlatAppearance.BorderSize = 0;

            BT_Shopping_Cart_Management.FlatStyle = FlatStyle.Flat;
            BT_Shopping_Cart_Management.FlatAppearance.BorderSize = 0;

            BT_Flower_Management.FlatStyle = FlatStyle.Flat;
            BT_Flower_Management.FlatAppearance.BorderSize = 0;

            BT_CLose_Form.FlatStyle = FlatStyle.Flat;
            BT_CLose_Form.FlatAppearance.BorderSize = 0;
        }

        private void BT_Customer_Management_MouseClick(object sender, MouseEventArgs e)
        {
            Customer_Management_Form CMF = new Customer_Management_Form();
            CMF.Show();

        }
        private void BT_Customer_Management_MouseEnter(object sender, EventArgs e)
        {
            BT_Customer_Management.FlatStyle = FlatStyle.Flat;
            BT_Customer_Management.FlatAppearance.BorderSize = 1;
            BT_Customer_Management.FlatAppearance.BorderColor = Color.DodgerBlue;
        }  
        private void BT_Customer_Management_MouseLeave(object sender, EventArgs e)
        {
            BT_Customer_Management.FlatStyle = FlatStyle.Flat;
            BT_Customer_Management.FlatAppearance.BorderSize = 0;
        }

        private void BT_Employee_Management_MouseClick(object sender, MouseEventArgs e)
        {
            Employee_Management_Form EMF = new Employee_Management_Form();
            EMF.Show();
        }
        private void BT_Employee_Management_MouseEnter(object sender, EventArgs e)
        {
            BT_Employee_Management.FlatStyle = FlatStyle.Flat;
            BT_Employee_Management.FlatAppearance.BorderSize = 1;
            BT_Employee_Management.FlatAppearance.BorderColor = Color.DodgerBlue;
        }
        private void BT_Employee_Management_MouseLeave(object sender, EventArgs e)
        {
            BT_Employee_Management.FlatStyle = FlatStyle.Flat;
            BT_Employee_Management.FlatAppearance.BorderSize = 0;
        }

        private void BT_Shopping_Cart_Management_MouseClick(object sender, MouseEventArgs e)
        {
            Cart_Management_Form SCF = new Cart_Management_Form();
            SCF.Show();
        }
        private void BT_Shopping_Cart_Management_MouseEnter(object sender, EventArgs e)
        {
            BT_Shopping_Cart_Management.FlatStyle = FlatStyle.Flat;
            BT_Shopping_Cart_Management.FlatAppearance.BorderSize = 1;
            BT_Shopping_Cart_Management.FlatAppearance.BorderColor = Color.DodgerBlue;
        }
        private void BT_Shopping_Cart_Management_MouseLeave(object sender, EventArgs e)
        {
            BT_Shopping_Cart_Management.FlatStyle = FlatStyle.Flat;
            BT_Shopping_Cart_Management.FlatAppearance.BorderSize = 0;
        }

        private void BT_Flower_Management_MouseClick(object sender, MouseEventArgs e)
        {
            Flower_Management_Form FMF = new Flower_Management_Form();
            FMF.Show();
        }       
        private void BT_Flower_Management_MouseEnter(object sender, EventArgs e)
        {
            BT_Flower_Management.FlatStyle = FlatStyle.Flat;
            BT_Flower_Management.FlatAppearance.BorderSize = 1;
            BT_Flower_Management.FlatAppearance.BorderColor = Color.DodgerBlue;
        }
        private void BT_Flower_Management_MouseLeave(object sender, EventArgs e)
        {
            BT_Flower_Management.FlatStyle = FlatStyle.Flat;
            BT_Flower_Management.FlatAppearance.BorderSize = 0;
        }

        private void BT_FlowerShop_MouseEnter(object sender, EventArgs e)
        {
            BT_FlowerShop.FlatStyle = FlatStyle.Flat;
            BT_FlowerShop.FlatAppearance.BorderSize = 1;
            BT_FlowerShop.FlatAppearance.BorderColor = Color.DodgerBlue;
        }
        private void BT_FlowerShop_MouseLeave(object sender, EventArgs e)
        {
            BT_FlowerShop.FlatStyle = FlatStyle.Flat;
            BT_FlowerShop.FlatAppearance.BorderSize = 0;
        }
        private void BT_FlowerShop_MouseClick(object sender, MouseEventArgs e)
        {
            FlowerShop_Management_Form FMF = new FlowerShop_Management_Form();
            FMF.Show();
        }

        private void BT_CLose_Form_Click(object sender, EventArgs e)
        {
            Close();
            Dispose(true);
        }

        private void BT_CLose_Form_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void BT_CLose_Form_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void BT_Employee_Management_Click(object sender, EventArgs e)
        {

        }

        private void LB_Title_Click(object sender, EventArgs e)
        {
          
        }

        private void BT_Static_Click(object sender, EventArgs e)
        {
            StatiticForm SF = new StatiticForm();
            SF.Show();
        }
    }
}
