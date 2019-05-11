namespace Flower_Management_System.Flower_Management
{
    partial class Add_Flower_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Flower_Form));
            this.LB_ID = new System.Windows.Forms.Label();
            this.LB_Name = new System.Windows.Forms.Label();
            this.LB_Price = new System.Windows.Forms.Label();
            this.LB_Money = new System.Windows.Forms.Label();
            this.LB_UseFor = new System.Windows.Forms.Label();
            this.LB_Country = new System.Windows.Forms.Label();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.TB_UseFor = new System.Windows.Forms.TextBox();
            this.TB_Country = new System.Windows.Forms.TextBox();
            this.BT_Browse = new System.Windows.Forms.Button();
            this.PB_Picture = new System.Windows.Forms.PictureBox();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_CLose_Form = new System.Windows.Forms.Button();
            this.LB_Browse = new System.Windows.Forms.Label();
            this.LB_Title = new System.Windows.Forms.Label();
            this.LB_Notice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_UseFor
            // 
            this.LB_UseFor.AutoSize = true;
            this.LB_UseFor.BackColor = System.Drawing.Color.White;
            this.LB_UseFor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_UseFor.Location = new System.Drawing.Point(33, 400);
            this.LB_UseFor.Name = "LB_UseFor";
            this.LB_UseFor.Size = new System.Drawing.Size(86, 25);
            this.LB_UseFor.TabIndex = 86;
            this.LB_UseFor.Text = "Use For :";
            // 
            // LB_Price
            // 
            this.LB_Price.AutoSize = true;
            this.LB_Price.BackColor = System.Drawing.Color.White;
            this.LB_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Price.Location = new System.Drawing.Point(33, 327);
            this.LB_Price.Name = "LB_Price";
            this.LB_Price.Size = new System.Drawing.Size(64, 25);
            this.LB_Price.TabIndex = 85;
            this.LB_Price.Text = "Price :";
            // 
            // LB_ID
            // 
            this.LB_ID.AutoSize = true;
            this.LB_ID.BackColor = System.Drawing.Color.White;
            this.LB_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ID.Location = new System.Drawing.Point(33, 144);
            this.LB_ID.Name = "LB_ID";
            this.LB_ID.Size = new System.Drawing.Size(42, 25);
            this.LB_ID.TabIndex = 84;
            this.LB_ID.Text = "ID :";
            // 
            // LB_Country
            // 
            this.LB_Country.AutoSize = true;
            this.LB_Country.BackColor = System.Drawing.Color.White;
            this.LB_Country.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Country.Location = new System.Drawing.Point(33, 476);
            this.LB_Country.Name = "LB_Country";
            this.LB_Country.Size = new System.Drawing.Size(92, 25);
            this.LB_Country.TabIndex = 83;
            this.LB_Country.Text = "Country :";
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.BackColor = System.Drawing.Color.White;
            this.LB_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name.Location = new System.Drawing.Point(33, 204);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(74, 25);
            this.LB_Name.TabIndex = 82;
            this.LB_Name.Text = "Name :";
            // 
            // TB_ID
            // 
            this.TB_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_ID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ID.Location = new System.Drawing.Point(95, 141);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(104, 27);
            this.TB_ID.TabIndex = 90;
            this.TB_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ID.TextChanged += new System.EventHandler(this.TB_ID_TextChanged);
            // 
            // TB_Country
            // 
            this.TB_Country.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Country.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Country.Location = new System.Drawing.Point(142, 477);
            this.TB_Country.Name = "TB_Country";
            this.TB_Country.Size = new System.Drawing.Size(288, 27);
            this.TB_Country.TabIndex = 89;
            this.TB_Country.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Name
            // 
            this.TB_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Name.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Name.Location = new System.Drawing.Point(83, 256);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(287, 27);
            this.TB_Name.TabIndex = 88;
            this.TB_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Price
            // 
            this.TB_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Price.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Price.Location = new System.Drawing.Point(142, 325);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(86, 27);
            this.TB_Price.TabIndex = 91;
            this.TB_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // LB_Money
            // 
            this.LB_Money.AutoSize = true;
            this.LB_Money.BackColor = System.Drawing.Color.White;
            this.LB_Money.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Money.ForeColor = System.Drawing.Color.Black;
            this.LB_Money.Location = new System.Drawing.Point(103, 327);
            this.LB_Money.Name = "LB_Money";
            this.LB_Money.Size = new System.Drawing.Size(23, 25);
            this.LB_Money.TabIndex = 92;
            this.LB_Money.Text = "$";
            // 
            // TB_UseFor
            // 
            this.TB_UseFor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_UseFor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_UseFor.Location = new System.Drawing.Point(142, 403);
            this.TB_UseFor.Name = "TB_UseFor";
            this.TB_UseFor.Size = new System.Drawing.Size(206, 27);
            this.TB_UseFor.TabIndex = 93;
            this.TB_UseFor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT_Browse
            // 
            this.BT_Browse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Browse.BackgroundImage")));
            this.BT_Browse.Location = new System.Drawing.Point(610, 474);
            this.BT_Browse.Name = "BT_Browse";
            this.BT_Browse.Size = new System.Drawing.Size(121, 49);
            this.BT_Browse.TabIndex = 94;
            this.BT_Browse.UseVisualStyleBackColor = true;
            this.BT_Browse.Click += new System.EventHandler(this.BT_Browse_Click);
            this.BT_Browse.MouseEnter += new System.EventHandler(this.BT_Browse_MouseEnter);
            this.BT_Browse.MouseLeave += new System.EventHandler(this.BT_Browse_MouseLeave);
            // 
            // PB_Picture
            // 
            this.PB_Picture.BackColor = System.Drawing.Color.White;
            this.PB_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Picture.Location = new System.Drawing.Point(499, 82);
            this.PB_Picture.Name = "PB_Picture";
            this.PB_Picture.Size = new System.Drawing.Size(345, 378);
            this.PB_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Picture.TabIndex = 95;
            this.PB_Picture.TabStop = false;
            // 
            // BT_Save
            // 
            this.BT_Save.BackColor = System.Drawing.Color.White;
            this.BT_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Save.BackgroundImage")));
            this.BT_Save.Location = new System.Drawing.Point(200, 526);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(64, 64);
            this.BT_Save.TabIndex = 96;
            this.BT_Save.UseVisualStyleBackColor = false;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            this.BT_Save.MouseEnter += new System.EventHandler(this.BT_Save_MouseEnter);
            this.BT_Save.MouseLeave += new System.EventHandler(this.BT_Save_MouseLeave);
            // 
            // BT_CLose_Form
            // 
            this.BT_CLose_Form.BackColor = System.Drawing.Color.White;
            this.BT_CLose_Form.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_CLose_Form.BackgroundImage")));
            this.BT_CLose_Form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_CLose_Form.Location = new System.Drawing.Point(422, 12);
            this.BT_CLose_Form.Name = "BT_CLose_Form";
            this.BT_CLose_Form.Size = new System.Drawing.Size(32, 32);
            this.BT_CLose_Form.TabIndex = 97;
            this.BT_CLose_Form.UseVisualStyleBackColor = false;
            this.BT_CLose_Form.Click += new System.EventHandler(this.BT_CLose_Form_Click);
            this.BT_CLose_Form.MouseEnter += new System.EventHandler(this.BT_CLose_Form_MouseEnter);
            this.BT_CLose_Form.MouseLeave += new System.EventHandler(this.BT_CLose_Form_MouseLeave);
            // 
            // LB_Browse
            // 
            this.LB_Browse.AutoSize = true;
            this.LB_Browse.BackColor = System.Drawing.Color.White;
            this.LB_Browse.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Browse.Location = new System.Drawing.Point(630, 482);
            this.LB_Browse.Name = "LB_Browse";
            this.LB_Browse.Size = new System.Drawing.Size(83, 30);
            this.LB_Browse.TabIndex = 98;
            this.LB_Browse.Text = "Browse";
            this.LB_Browse.Click += new System.EventHandler(this.LB_Browse_Click);
            this.LB_Browse.MouseEnter += new System.EventHandler(this.LB_Browse_MouseEnter);
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.BackColor = System.Drawing.Color.White;
            this.LB_Title.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Title.ForeColor = System.Drawing.Color.DarkMagenta;
            this.LB_Title.Location = new System.Drawing.Point(101, 34);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(242, 41);
            this.LB_Title.TabIndex = 99;
            this.LB_Title.Text = "ADD NEW FLOWER";
            // 
            // LB_Notice
            // 
            this.LB_Notice.AutoSize = true;
            this.LB_Notice.BackColor = System.Drawing.Color.White;
            this.LB_Notice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Notice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LB_Notice.Location = new System.Drawing.Point(34, 99);
            this.LB_Notice.Name = "LB_Notice";
            this.LB_Notice.Size = new System.Drawing.Size(307, 21);
            this.LB_Notice.TabIndex = 100;
            this.LB_Notice.Text = "Error : Duplicate ID value ! Please try again";
            this.LB_Notice.Visible = false;
            // 
            // Add_Flower_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(873, 608);
            this.Controls.Add(this.LB_Notice);
            this.Controls.Add(this.LB_Title);
            this.Controls.Add(this.LB_Browse);
            this.Controls.Add(this.BT_CLose_Form);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.PB_Picture);
            this.Controls.Add(this.BT_Browse);
            this.Controls.Add(this.TB_UseFor);
            this.Controls.Add(this.LB_Money);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.TB_Price);
            this.Controls.Add(this.LB_UseFor);
            this.Controls.Add(this.TB_Country);
            this.Controls.Add(this.LB_Price);
            this.Controls.Add(this.LB_ID);
            this.Controls.Add(this.LB_Country);
            this.Controls.Add(this.LB_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Flower_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Flower_Form";
            this.Load += new System.EventHandler(this.Add_Flower_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_ID;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.Label LB_Price;
        private System.Windows.Forms.Label LB_Money;
        private System.Windows.Forms.Label LB_UseFor;
        private System.Windows.Forms.Label LB_Country;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Price;
        private System.Windows.Forms.TextBox TB_UseFor;
        private System.Windows.Forms.TextBox TB_Country;
        private System.Windows.Forms.Button BT_Browse;
        private System.Windows.Forms.PictureBox PB_Picture;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_CLose_Form;
        private System.Windows.Forms.Label LB_Browse;
        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.Label LB_Notice;
    }
}