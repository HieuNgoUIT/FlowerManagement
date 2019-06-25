namespace Flower_Management_System.Flower_Management
{
    partial class Add_FlowerShop_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_FlowerShop_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.PB_Picture = new System.Windows.Forms.PictureBox();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_CLose_Form = new System.Windows.Forms.Button();
            this.LB_Title = new System.Windows.Forms.Label();
            this.Data_Grid_View = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LB_Quantity = new System.Windows.Forms.Label();
            this.TB_Quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_UseFor = new System.Windows.Forms.TextBox();
            this.TB_Country = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid_View)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Price
            // 
            this.TB_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Price.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Price.Location = new System.Drawing.Point(175, 608);
            this.TB_Price.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(87, 34);
            this.TB_Price.TabIndex = 91;
            this.TB_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Price.TextChanged += new System.EventHandler(this.TB_Price_TextChanged);
            this.TB_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
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
            this.BT_Save.Location = new System.Drawing.Point(860, 563);
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
            // Data_Grid_View
            // 
            this.Data_Grid_View.AllowUserToAddRows = false;
            this.Data_Grid_View.AllowUserToDeleteRows = false;
            this.Data_Grid_View.AllowUserToResizeColumns = false;
            this.Data_Grid_View.AllowUserToResizeRows = false;
            this.Data_Grid_View.BackgroundColor = System.Drawing.Color.White;
            this.Data_Grid_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Data_Grid_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Grid_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Data_Grid_View.ColumnHeadersHeight = 50;
            this.Data_Grid_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Data_Grid_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.Column2,
            this.Picture});
            this.Data_Grid_View.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Grid_View.DefaultCellStyle = dataGridViewCellStyle3;
            this.Data_Grid_View.Location = new System.Drawing.Point(13, 119);
            this.Data_Grid_View.Margin = new System.Windows.Forms.Padding(4);
            this.Data_Grid_View.MultiSelect = false;
            this.Data_Grid_View.Name = "Data_Grid_View";
            this.Data_Grid_View.RowHeadersVisible = false;
            this.Data_Grid_View.RowTemplate.Height = 50;
            this.Data_Grid_View.RowTemplate.ReadOnly = true;
            this.Data_Grid_View.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Grid_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data_Grid_View.Size = new System.Drawing.Size(607, 256);
            this.Data_Grid_View.TabIndex = 105;
            this.Data_Grid_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Grid_View_CellContentClick);
            // 
            // c1
            // 
            this.c1.DataPropertyName = "ID";
            this.c1.HeaderText = "ID";
            this.c1.Name = "c1";
            this.c1.Visible = false;
            this.c1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FullName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Full Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Picture";
            this.Picture.HeaderText = "Picture";
            this.Picture.Name = "Picture";
            this.Picture.Visible = false;
            // 
            // Price
            // 
            this.Price.Name = "Price";
            // 
            // Column1
            // 
            this.Column1.Name = "Column1";
            // 
            // Nationality
            // 
            this.Nationality.Name = "Nationality";
            // 
            // LB_Quantity
            // 
            this.LB_Quantity.AutoSize = true;
            this.LB_Quantity.BackColor = System.Drawing.Color.White;
            this.LB_Quantity.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Quantity.Location = new System.Drawing.Point(32, 427);
            this.LB_Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Quantity.Name = "LB_Quantity";
            this.LB_Quantity.Size = new System.Drawing.Size(117, 32);
            this.LB_Quantity.TabIndex = 107;
            this.LB_Quantity.Text = "Quantity ";
            // 
            // TB_Quantity
            // 
            this.TB_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Quantity.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Quantity.Location = new System.Drawing.Point(157, 427);
            this.TB_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Quantity.Name = "TB_Quantity";
            this.TB_Quantity.Size = new System.Drawing.Size(125, 34);
            this.TB_Quantity.TabIndex = 108;
            this.TB_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Quantity.TextChanged += new System.EventHandler(this.TB_Quantity_TextChanged_1);
            this.TB_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Quantity_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 490);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 109;
            this.label1.Text = "UseFor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 534);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 110;
            this.label2.Text = "Country";
            // 
            // TB_UseFor
            // 
            this.TB_UseFor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_UseFor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_UseFor.Location = new System.Drawing.Point(157, 490);
            this.TB_UseFor.Margin = new System.Windows.Forms.Padding(4);
            this.TB_UseFor.Name = "TB_UseFor";
            this.TB_UseFor.Size = new System.Drawing.Size(125, 34);
            this.TB_UseFor.TabIndex = 111;
            this.TB_UseFor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Country
            // 
            this.TB_Country.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Country.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Country.Location = new System.Drawing.Point(157, 549);
            this.TB_Country.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Country.Name = "TB_Country";
            this.TB_Country.Size = new System.Drawing.Size(125, 34);
            this.TB_Country.TabIndex = 112;
            this.TB_Country.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 596);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 32);
            this.label3.TabIndex = 113;
            this.label3.Text = "Price";
            // 
            // Add_FlowerShop_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1164, 705);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Country);
            this.Controls.Add(this.TB_UseFor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Quantity);
            this.Controls.Add(this.LB_Quantity);
            this.Controls.Add(this.Data_Grid_View);
            this.Controls.Add(this.LB_Title);
            this.Controls.Add(this.BT_CLose_Form);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.PB_Picture);
            this.Controls.Add(this.TB_Price);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_FlowerShop_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Flower_Form";
            this.Load += new System.EventHandler(this.Add_Flower_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_Price;
        private System.Windows.Forms.PictureBox PB_Picture;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_CLose_Form;
        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.DataGridView Data_Grid_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label LB_Quantity;
        private System.Windows.Forms.TextBox TB_Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_UseFor;
        private System.Windows.Forms.TextBox TB_Country;
        private System.Windows.Forms.Label label3;
    }
}