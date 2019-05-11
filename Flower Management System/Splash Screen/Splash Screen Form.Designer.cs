namespace Flower_Management_System.Splash_Screen
{
    partial class Splash_Screen_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash_Screen_Form));
            this.PB_Image_Loading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image_Loading)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Image_Loading
            // 
            this.PB_Image_Loading.BackColor = System.Drawing.Color.Black;
            this.PB_Image_Loading.Image = ((System.Drawing.Image)(resources.GetObject("PB_Image_Loading.Image")));
            this.PB_Image_Loading.Location = new System.Drawing.Point(155, 250);
            this.PB_Image_Loading.Name = "PB_Image_Loading";
            this.PB_Image_Loading.Size = new System.Drawing.Size(200, 200);
            this.PB_Image_Loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Image_Loading.TabIndex = 0;
            this.PB_Image_Loading.TabStop = false;
            // 
            // Splash_Screen_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(511, 511);
            this.Controls.Add(this.PB_Image_Loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash_Screen_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Splash_Screen_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image_Loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Image_Loading;
    }
}