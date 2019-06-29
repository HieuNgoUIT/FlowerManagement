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
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.BT_Browse = new System.Windows.Forms.Button();
            this.PB_Picture = new System.Windows.Forms.PictureBox();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_CLose_Form = new System.Windows.Forms.Button();
            this.LB_Browse = new System.Windows.Forms.Label();
            this.LB_Title = new System.Windows.Forms.Label();
            this.LB_Notice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Quantity = new System.Windows.Forms.TextBox();
            this.LB_ImportDate = new System.Windows.Forms.Label();
            this.TB_ImportDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_ID
            // 
            this.LB_ID.AutoSize = true;
            this.LB_ID.BackColor = System.Drawing.Color.White;
            this.LB_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ID.Location = new System.Drawing.Point(13, 175);
            this.LB_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_ID.Name = "LB_ID";
            this.LB_ID.Size = new System.Drawing.Size(46, 32);
            this.LB_ID.TabIndex = 84;
            this.LB_ID.Text = "ID ";
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.BackColor = System.Drawing.Color.White;
            this.LB_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name.Location = new System.Drawing.Point(13, 255);
            this.LB_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(87, 32);
            this.LB_Name.TabIndex = 82;
            this.LB_Name.Text = "Name ";
            // 
            // TB_ID
            // 
            this.TB_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_ID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ID.Location = new System.Drawing.Point(127, 173);
            this.TB_ID.Margin = new System.Windows.Forms.Padding(4);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(139, 34);
            this.TB_ID.TabIndex = 90;
            this.TB_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ID.TextChanged += new System.EventHandler(this.TB_ID_TextChanged);
            // 
            // TB_Name
            // 
            this.TB_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Name.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Name.Location = new System.Drawing.Point(127, 255);
            this.TB_Name.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(383, 34);
            this.TB_Name.TabIndex = 88;
            this.TB_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT_Browse
            // 
            this.BT_Browse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Browse.BackgroundImage")));
            this.BT_Browse.Location = new System.Drawing.Point(813, 584);
            this.BT_Browse.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Browse.Name = "BT_Browse";
            this.BT_Browse.Size = new System.Drawing.Size(161, 60);
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
            this.PB_Picture.Location = new System.Drawing.Point(665, 101);
            this.PB_Picture.Margin = new System.Windows.Forms.Padding(4);
            this.PB_Picture.Name = "PB_Picture";
            this.PB_Picture.Size = new System.Drawing.Size(459, 465);
            this.PB_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Picture.TabIndex = 95;
            this.PB_Picture.TabStop = false;
            // 
            // BT_Save
            // 
            this.BT_Save.BackColor = System.Drawing.Color.White;
            this.BT_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Save.BackgroundImage")));
            this.BT_Save.Location = new System.Drawing.Point(199, 504);
            this.BT_Save.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(85, 79);
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
            this.BT_CLose_Form.Location = new System.Drawing.Point(563, 15);
            this.BT_CLose_Form.Margin = new System.Windows.Forms.Padding(4);
            this.BT_CLose_Form.Name = "BT_CLose_Form";
            this.BT_CLose_Form.Size = new System.Drawing.Size(43, 40);
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
            this.LB_Browse.Location = new System.Drawing.Point(840, 593);
            this.LB_Browse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Browse.Name = "LB_Browse";
            this.LB_Browse.Size = new System.Drawing.Size(105, 37);
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
            this.LB_Title.Location = new System.Drawing.Point(135, 42);
            this.LB_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(305, 52);
            this.LB_Title.TabIndex = 99;
            this.LB_Title.Text = "ADD NEW FLOWER";
            // 
            // LB_Notice
            // 
            this.LB_Notice.AutoSize = true;
            this.LB_Notice.BackColor = System.Drawing.Color.White;
            this.LB_Notice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Notice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LB_Notice.Location = new System.Drawing.Point(45, 122);
            this.LB_Notice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Notice.Name = "LB_Notice";
            this.LB_Notice.Size = new System.Drawing.Size(387, 28);
            this.LB_Notice.TabIndex = 100;
            this.LB_Notice.Text = "Error : Duplicate ID value ! Please try again";
            this.LB_Notice.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 342);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 101;
            this.label1.Text = "Quantity";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_Quantity
            // 
            this.TB_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Quantity.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Quantity.Location = new System.Drawing.Point(168, 340);
            this.TB_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Quantity.Name = "TB_Quantity";
            this.TB_Quantity.Size = new System.Drawing.Size(98, 34);
            this.TB_Quantity.TabIndex = 102;
            this.TB_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Quantity.TextChanged += new System.EventHandler(this.TB_Quantity_TextChanged);
            this.TB_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Quantity_KeyPress);
            // 
            // LB_ImportDate
            // 
            this.LB_ImportDate.AutoSize = true;
            this.LB_ImportDate.BackColor = System.Drawing.Color.White;
            this.LB_ImportDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ImportDate.Location = new System.Drawing.Point(13, 428);
            this.LB_ImportDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_ImportDate.Name = "LB_ImportDate";
            this.LB_ImportDate.Size = new System.Drawing.Size(149, 32);
            this.LB_ImportDate.TabIndex = 103;
            this.LB_ImportDate.Text = "Import Date";
            // 
            // TB_ImportDate
            // 
            this.TB_ImportDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_ImportDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ImportDate.Location = new System.Drawing.Point(199, 426);
            this.TB_ImportDate.Margin = new System.Windows.Forms.Padding(4);
            this.TB_ImportDate.Name = "TB_ImportDate";
            this.TB_ImportDate.Size = new System.Drawing.Size(253, 34);
            this.TB_ImportDate.TabIndex = 104;
            this.TB_ImportDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ImportDate.TextChanged += new System.EventHandler(this.TB_ImportDate_TextChanged);
            this.TB_ImportDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_ImportDate_KeyPress);
            // 
            // Add_Flower_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1164, 705);
            this.Controls.Add(this.TB_ImportDate);
            this.Controls.Add(this.LB_ImportDate);
            this.Controls.Add(this.TB_Quantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Notice);
            this.Controls.Add(this.LB_Title);
            this.Controls.Add(this.LB_Browse);
            this.Controls.Add(this.BT_CLose_Form);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.PB_Picture);
            this.Controls.Add(this.BT_Browse);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.LB_ID);
            this.Controls.Add(this.LB_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Button BT_Browse;
        private System.Windows.Forms.PictureBox PB_Picture;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_CLose_Form;
        private System.Windows.Forms.Label LB_Browse;
        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.Label LB_Notice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Quantity;
        private System.Windows.Forms.Label LB_ImportDate;
        private System.Windows.Forms.TextBox TB_ImportDate;
    }
}