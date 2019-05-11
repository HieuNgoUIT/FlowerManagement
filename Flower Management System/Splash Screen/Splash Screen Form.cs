using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flower_Management_System.Splash_Screen
{
    public partial class Splash_Screen_Form : Form
    {
        public Splash_Screen_Form()
        {
            InitializeComponent();
        }

        // +--------------+
        // | MAIN SETTING |
        // +--------------+

        // -------------------------------------------------------------------------
        private void Splash_Screen_Form_Load(object sender, EventArgs e)
        {
            PictureBox_Setting();
            Splash_Screen_Form_Setting();
        }
        // -------------------------------------------------------------------------

        // +------------------+
        // | FUNCTION SETTING |
        // +------------------+
        
        //      +--------------------+
        //      | PICTUREBOX SETTING |
        //      +--------------------+

        // -------------------------------------------------------------------------
        private void PictureBox_Setting()
        {
            PB_Image_Loading.BorderStyle = BorderStyle.None;
            PB_Image_Loading.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        // -------------------------------------------------------------------------

        //      +----------------------+
        //      | SPLASHSCREEN SETTING |
        //      +----------------------+
        // -------------------------------------------------------------------------
        private void Splash_Screen_Form_Setting()
        {
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
        }
        // -------------------------------------------------------------------------
    }
}
