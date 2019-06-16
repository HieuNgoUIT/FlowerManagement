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
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LB_Quantity = new System.Windows.Forms.Label();
            this.TB_Quantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid_View)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Price
            // 
            this.TB_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Price.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Price.Location = new System.Drawing.Point(157, 335);
            this.TB_Price.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(87, 34);
            this.TB_Price.TabIndex = 91;
            this.TB_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BT_Save.Location = new System.Drawing.Point(710, 281);
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
            this.Price,
            this.Column1,
            this.Nationality,
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
            this.Data_Grid_View.Location = new System.Drawing.Point(13, 124);
            this.Data_Grid_View.Margin = new System.Windows.Forms.Padding(4);
            this.Data_Grid_View.MultiSelect = false;
            this.Data_Grid_View.Name = "Data_Grid_View";
            this.Data_Grid_View.RowHeadersVisible = false;
            this.Data_Grid_View.RowTemplate.Height = 50;
            this.Data_Grid_View.RowTemplate.ReadOnly = true;
            this.Data_Grid_View.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Grid_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data_Grid_View.Size = new System.Drawing.Size(607, 518);
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
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UseFor";
            this.Column1.HeaderText = "UseFor";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Nationality
            // 
            this.Nationality.DataPropertyName = "Country";
            this.Nationality.HeaderText = "Country";
            this.Nationality.Name = "Nationality";
            this.Nationality.Visible = false;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Picture";
            this.Picture.HeaderText = "Picture";
            this.Picture.Name = "Picture";
            this.Picture.Visible = false;
            // 
            // LB_Quantity
            // 
            this.LB_Quantity.AutoSize = true;
            this.LB_Quantity.BackColor = System.Drawing.Color.White;
            this.LB_Quantity.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Quantity.Location = new System.Drawing.Point(27, 673);
            this.LB_Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Quantity.Name = "LB_Quantity";
            this.LB_Quantity.Size = new System.Drawing.Size(123, 32);
            this.LB_Quantity.TabIndex = 107;
            this.LB_Quantity.Text = "Quantity :";
            // 
            // TB_Quantity
            // 
            this.TB_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Quantity.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Quantity.Location = new System.Drawing.Point(182, 671);
            this.TB_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Quantity.Name = "TB_Quantity";
            this.TB_Quantity.Size = new System.Drawing.Size(125, 34);
            this.TB_Quantity.TabIndex = 108;
            this.TB_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Quantity.TextChanged += new System.EventHandler(this.TB_Quantity_TextChanged_1);
            // 
            // Add_FlowerShop_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1164, 705);
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
    }
}