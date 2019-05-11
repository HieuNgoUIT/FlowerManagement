using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Flower_Management_System.Splash_Screen;
using Flower_Management_System.Database;

namespace Flower_Management_System.Login
{
    /// <summary>
    /// Splash Screen Setting
    /// Button Setting
    /// Mouse Setting (cursor) : how to change cursor skin inwindow form without changing window default cursor
    /// </summary>
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        // +--------------+
        // | MAIN SETTING |
        // +--------------+

        // -------------------------------------------------------------------------
        private void Login_Form_Load(object sender, EventArgs e)
        {
            Load_Splash_Screen();
            this.Show();
            Login_Form_Setting();
            TextBox_Setting();
            Button_Setting(sender, e);
        }
        // -------------------------------------------------------------------------

        // +------------------+
        // | FUNCTION SETTING |
        // +------------------+

        // -------------------------------------------------------------------------
        private void Load_Splash_Screen()
        {
            Thread splash = new Thread(new ThreadStart(Open_Splash_Screen_Form));
            splash.Start();
            Thread.Sleep(3350);
            splash.Abort();
        }
        private void Open_Splash_Screen_Form()
        {
            Application.Run(new Splash_Screen_Form());
        }
        private void Login_Form_Setting()
        {
            this.TransparencyKey = Color.FromArgb(237, 28, 36);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        // -------------------------------------------------------------------------

        //      +---------------+
        //      | LABEL SETTING |
        //      +---------------+

        // -------------------------------------------------------------------------
        private void LB_BT_Login_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void LB_BT_Login_Click(object sender, EventArgs e)
        {
            BT_Login_Click(sender, e);
        }
        // -------------------------------------------------------------------------
        private void LB_BT_Quit_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void LB_BT_Quit_Click(object sender, EventArgs e)
        {
            BT_Quit_Click(sender, e);
        }
        // -------------------------------------------------------------------------

        //      +-----------------+
        //      | TEXTBOX SETTING |
        //      +-----------------+

        // -------------------------------------------------------------------------
        private void TextBox_Setting()
        {
            TB_Username.BorderStyle = BorderStyle.None;
            TB_Username.Multiline = false;
            TB_Username.TextAlign = HorizontalAlignment.Center;

            TB_Password.BorderStyle = BorderStyle.None;
            TB_Password.Multiline = false;
            TB_Password.PasswordChar = '●';
        }
        // -------------------------------------------------------------------------

        //      +----------------+
        //      | BUTTON SETTING |
        //      +----------------+

        // -------------------------------------------------------------------------
        private void Button_Setting(object sender, EventArgs e)
        {
            BT_Login.FlatStyle = FlatStyle.Flat;
            BT_Login.FlatAppearance.BorderSize = 0;

            BT_Quit.FlatStyle = FlatStyle.Flat;
            BT_Quit.FlatAppearance.BorderSize = 0;
        }
        // -------------------------------------------------------------------------
        private void BT_Login_Click(object sender, EventArgs e)
        {
            System_Database_SQL A = new System_Database_SQL();
            string check_login_information = "select Username, Password from Account where Username collate Latin1_General_CS_AS = '" + TB_Username.Text + "'";
            string role_query = "select CurrentRole from Account where Username collate Latin1_General_CS_AS = '" + TB_Username.Text + "'";
            object role = A.GetColumnValue(role_query);
            if (A.Check_Exist_Value(check_login_information) == true)
            {
                Load_Main_Form(role.ToString());
                this.Hide();
            }
            else
            {
                LB_Notice.Visible = true;
            }
        }
        private void BT_Quit_Click(object sender, EventArgs e)
        {
            Close();
            Dispose(true);
        }
        // -------------------------------------------------------------------------
        private void BT_Login_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void BT_Login_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        // -------------------------------------------------------------------------
        private void BT_Quit_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void BT_Quit_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        // -------------------------------------------------------------------------

        //      +-----------+
        //      | LOAD FORM |
        //      +-----------+
        // -------------------------------------------------------------------------
        private void Load_Main_Form(string role)
        {
            Main_Form Main = new Main_Form(role);
            Main.Show();
        }
    }
}
