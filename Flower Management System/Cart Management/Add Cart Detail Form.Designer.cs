﻿namespace Flower_Management_System.Cart_Management
{
    partial class Add_Cart_Detail_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Cart_Detail_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PB_Picture = new System.Windows.Forms.PictureBox();
            this.Picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LB_Money = new System.Windows.Forms.Label();
            this.LB_UseFor_Data = new System.Windows.Forms.Label();
            this.LB_UseFor = new System.Windows.Forms.Label();
            this.LB_Country_Data = new System.Windows.Forms.Label();
            this.LB_Price_Data = new System.Windows.Forms.Label();
            this.LB_ID_Data = new System.Windows.Forms.Label();
            this.LB_Name_Data = new System.Windows.Forms.Label();
            this.LB_Price = new System.Windows.Forms.Label();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_CLose_Form = new System.Windows.Forms.Button();
            this.LB_ID = new System.Windows.Forms.Label();
            this.LB_Country = new System.Windows.Forms.Label();
            this.LB_Name = new System.Windows.Forms.Label();
            this.LB_Title = new System.Windows.Forms.Label();
            this.TB_Search = new System.Windows.Forms.TextBox();
            this.BT_Search = new System.Windows.Forms.Button();
            this.Data_Grid_View = new System.Windows.Forms.DataGridView();
            this.LB_Quantity = new System.Windows.Forms.Label();
            this.TB_Quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_CartID = new System.Windows.Forms.Label();
            this.LB_Saved = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid_View)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Picture
            // 
            this.PB_Picture.BackColor = System.Drawing.Color.White;
            this.PB_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Picture.Location = new System.Drawing.Point(954, 146);
            this.PB_Picture.Name = "PB_Picture";
            this.PB_Picture.Size = new System.Drawing.Size(345, 378);
            this.PB_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Picture.TabIndex = 106;
            this.PB_Picture.TabStop = false;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Picture";
            this.Picture.HeaderText = "Picture";
            this.Picture.Name = "Picture";
            this.Picture.Visible = false;
            // 
            // Nationality
            // 
            this.Nationality.DataPropertyName = "Country";
            this.Nationality.HeaderText = "Country";
            this.Nationality.Name = "Nationality";
            this.Nationality.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UseFor";
            this.Column1.HeaderText = "UseFor";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Price";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FullName";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Full Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // c1
            // 
            this.c1.DataPropertyName = "ID";
            this.c1.HeaderText = "ID";
            this.c1.Name = "c1";
            this.c1.Width = 110;
            // 
            // LB_Money
            // 
            this.LB_Money.AutoSize = true;
            this.LB_Money.BackColor = System.Drawing.Color.White;
            this.LB_Money.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Money.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LB_Money.Location = new System.Drawing.Point(697, 399);
            this.LB_Money.Name = "LB_Money";
            this.LB_Money.Size = new System.Drawing.Size(23, 25);
            this.LB_Money.TabIndex = 105;
            this.LB_Money.Text = "$";
            // 
            // LB_UseFor_Data
            // 
            this.LB_UseFor_Data.AutoSize = true;
            this.LB_UseFor_Data.BackColor = System.Drawing.Color.White;
            this.LB_UseFor_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_UseFor_Data.ForeColor = System.Drawing.Color.Firebrick;
            this.LB_UseFor_Data.Location = new System.Drawing.Point(719, 475);
            this.LB_UseFor_Data.Name = "LB_UseFor_Data";
            this.LB_UseFor_Data.Size = new System.Drawing.Size(27, 25);
            this.LB_UseFor_Data.TabIndex = 104;
            this.LB_UseFor_Data.Text = "...";
            // 
            // LB_UseFor
            // 
            this.LB_UseFor.AutoSize = true;
            this.LB_UseFor.BackColor = System.Drawing.Color.White;
            this.LB_UseFor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_UseFor.Location = new System.Drawing.Point(627, 475);
            this.LB_UseFor.Name = "LB_UseFor";
            this.LB_UseFor.Size = new System.Drawing.Size(86, 25);
            this.LB_UseFor.TabIndex = 103;
            this.LB_UseFor.Text = "Use For :";
            // 
            // LB_Country_Data
            // 
            this.LB_Country_Data.AutoSize = true;
            this.LB_Country_Data.BackColor = System.Drawing.Color.White;
            this.LB_Country_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Country_Data.Location = new System.Drawing.Point(725, 551);
            this.LB_Country_Data.Name = "LB_Country_Data";
            this.LB_Country_Data.Size = new System.Drawing.Size(27, 25);
            this.LB_Country_Data.TabIndex = 101;
            this.LB_Country_Data.Text = "...";
            // 
            // LB_Price_Data
            // 
            this.LB_Price_Data.AutoSize = true;
            this.LB_Price_Data.BackColor = System.Drawing.Color.White;
            this.LB_Price_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Price_Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LB_Price_Data.Location = new System.Drawing.Point(717, 399);
            this.LB_Price_Data.Name = "LB_Price_Data";
            this.LB_Price_Data.Size = new System.Drawing.Size(27, 25);
            this.LB_Price_Data.TabIndex = 100;
            this.LB_Price_Data.Text = "...";
            // 
            // LB_ID_Data
            // 
            this.LB_ID_Data.AutoSize = true;
            this.LB_ID_Data.BackColor = System.Drawing.Color.White;
            this.LB_ID_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ID_Data.Location = new System.Drawing.Point(675, 207);
            this.LB_ID_Data.Name = "LB_ID_Data";
            this.LB_ID_Data.Size = new System.Drawing.Size(27, 25);
            this.LB_ID_Data.TabIndex = 99;
            this.LB_ID_Data.Text = "...";
            // 
            // LB_Name_Data
            // 
            this.LB_Name_Data.AutoSize = true;
            this.LB_Name_Data.BackColor = System.Drawing.Color.White;
            this.LB_Name_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name_Data.ForeColor = System.Drawing.Color.DarkOrchid;
            this.LB_Name_Data.Location = new System.Drawing.Point(642, 337);
            this.LB_Name_Data.Name = "LB_Name_Data";
            this.LB_Name_Data.Size = new System.Drawing.Size(27, 25);
            this.LB_Name_Data.TabIndex = 98;
            this.LB_Name_Data.Text = "...";
            this.LB_Name_Data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Price
            // 
            this.LB_Price.AutoSize = true;
            this.LB_Price.BackColor = System.Drawing.Color.White;
            this.LB_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Price.Location = new System.Drawing.Point(627, 399);
            this.LB_Price.Name = "LB_Price";
            this.LB_Price.Size = new System.Drawing.Size(64, 25);
            this.LB_Price.TabIndex = 97;
            this.LB_Price.Text = "Price :";
            // 
            // BT_Save
            // 
            this.BT_Save.BackColor = System.Drawing.Color.White;
            this.BT_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Save.BackgroundImage")));
            this.BT_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Save.Location = new System.Drawing.Point(488, 298);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(64, 59);
            this.BT_Save.TabIndex = 95;
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
            this.BT_CLose_Form.Location = new System.Drawing.Point(876, 15);
            this.BT_CLose_Form.Name = "BT_CLose_Form";
            this.BT_CLose_Form.Size = new System.Drawing.Size(32, 32);
            this.BT_CLose_Form.TabIndex = 94;
            this.BT_CLose_Form.UseVisualStyleBackColor = false;
            this.BT_CLose_Form.Click += new System.EventHandler(this.BT_CLose_Form_Click);
            this.BT_CLose_Form.MouseEnter += new System.EventHandler(this.BT_CLose_Form_MouseEnter);
            this.BT_CLose_Form.MouseLeave += new System.EventHandler(this.BT_CLose_Form_MouseLeave);
            // 
            // LB_ID
            // 
            this.LB_ID.AutoSize = true;
            this.LB_ID.BackColor = System.Drawing.Color.White;
            this.LB_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ID.Location = new System.Drawing.Point(627, 207);
            this.LB_ID.Name = "LB_ID";
            this.LB_ID.Size = new System.Drawing.Size(42, 25);
            this.LB_ID.TabIndex = 91;
            this.LB_ID.Text = "ID :";
            // 
            // LB_Country
            // 
            this.LB_Country.AutoSize = true;
            this.LB_Country.BackColor = System.Drawing.Color.White;
            this.LB_Country.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Country.Location = new System.Drawing.Point(627, 551);
            this.LB_Country.Name = "LB_Country";
            this.LB_Country.Size = new System.Drawing.Size(92, 25);
            this.LB_Country.TabIndex = 90;
            this.LB_Country.Text = "Country :";
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.BackColor = System.Drawing.Color.White;
            this.LB_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name.Location = new System.Drawing.Point(627, 283);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(74, 25);
            this.LB_Name.TabIndex = 89;
            this.LB_Name.Text = "Name :";
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.BackColor = System.Drawing.Color.White;
            this.LB_Title.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Title.ForeColor = System.Drawing.Color.DarkMagenta;
            this.LB_Title.Location = new System.Drawing.Point(100, 33);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(229, 41);
            this.LB_Title.TabIndex = 88;
            this.LB_Title.Text = "CHOOSE FLOWER";
            // 
            // TB_Search
            // 
            this.TB_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Search.Location = new System.Drawing.Point(50, 114);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(292, 28);
            this.TB_Search.TabIndex = 86;
            // 
            // BT_Search
            // 
            this.BT_Search.BackColor = System.Drawing.Color.White;
            this.BT_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Search.BackgroundImage")));
            this.BT_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Search.Location = new System.Drawing.Point(376, 102);
            this.BT_Search.Name = "BT_Search";
            this.BT_Search.Size = new System.Drawing.Size(56, 56);
            this.BT_Search.TabIndex = 85;
            this.BT_Search.UseVisualStyleBackColor = false;
            this.BT_Search.Click += new System.EventHandler(this.BT_Search_Click);
            this.BT_Search.MouseEnter += new System.EventHandler(this.BT_Search_MouseEnter);
            this.BT_Search.MouseLeave += new System.EventHandler(this.BT_Search_MouseLeave);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Grid_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Data_Grid_View.ColumnHeadersHeight = 50;
            this.Data_Grid_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Data_Grid_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.Column2,
            this.Gender,
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
            this.Data_Grid_View.Location = new System.Drawing.Point(32, 195);
            this.Data_Grid_View.MultiSelect = false;
            this.Data_Grid_View.Name = "Data_Grid_View";
            this.Data_Grid_View.RowHeadersVisible = false;
            this.Data_Grid_View.RowTemplate.Height = 50;
            this.Data_Grid_View.RowTemplate.ReadOnly = true;
            this.Data_Grid_View.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Grid_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data_Grid_View.Size = new System.Drawing.Size(412, 407);
            this.Data_Grid_View.TabIndex = 96;
            this.Data_Grid_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Grid_View_CellClick);
            // 
            // LB_Quantity
            // 
            this.LB_Quantity.AutoSize = true;
            this.LB_Quantity.BackColor = System.Drawing.Color.White;
            this.LB_Quantity.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Quantity.Location = new System.Drawing.Point(475, 369);
            this.LB_Quantity.Name = "LB_Quantity";
            this.LB_Quantity.Size = new System.Drawing.Size(87, 25);
            this.LB_Quantity.TabIndex = 107;
            this.LB_Quantity.Text = "Quantity";
            // 
            // TB_Quantity
            // 
            this.TB_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Quantity.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Quantity.Location = new System.Drawing.Point(480, 415);
            this.TB_Quantity.Name = "TB_Quantity";
            this.TB_Quantity.Size = new System.Drawing.Size(72, 28);
            this.TB_Quantity.TabIndex = 108;
            this.TB_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Quantity_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(617, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 109;
            this.label1.Text = "CART ID :";
            // 
            // LB_CartID
            // 
            this.LB_CartID.AutoSize = true;
            this.LB_CartID.BackColor = System.Drawing.Color.White;
            this.LB_CartID.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CartID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LB_CartID.Location = new System.Drawing.Point(717, 115);
            this.LB_CartID.Name = "LB_CartID";
            this.LB_CartID.Size = new System.Drawing.Size(25, 23);
            this.LB_CartID.TabIndex = 110;
            this.LB_CartID.Text = "id";
            // 
            // LB_Saved
            // 
            this.LB_Saved.AutoSize = true;
            this.LB_Saved.BackColor = System.Drawing.Color.White;
            this.LB_Saved.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Saved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LB_Saved.Location = new System.Drawing.Point(484, 261);
            this.LB_Saved.Name = "LB_Saved";
            this.LB_Saved.Size = new System.Drawing.Size(68, 25);
            this.LB_Saved.TabIndex = 111;
            this.LB_Saved.Text = "Added";
            this.LB_Saved.Visible = false;
            // 
            // Add_Cart_Detail_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1326, 650);
            this.Controls.Add(this.LB_Saved);
            this.Controls.Add(this.LB_CartID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Quantity);
            this.Controls.Add(this.LB_Quantity);
            this.Controls.Add(this.PB_Picture);
            this.Controls.Add(this.LB_Money);
            this.Controls.Add(this.LB_UseFor_Data);
            this.Controls.Add(this.LB_UseFor);
            this.Controls.Add(this.LB_Country_Data);
            this.Controls.Add(this.LB_Price_Data);
            this.Controls.Add(this.LB_ID_Data);
            this.Controls.Add(this.LB_Name_Data);
            this.Controls.Add(this.LB_Price);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.BT_CLose_Form);
            this.Controls.Add(this.LB_ID);
            this.Controls.Add(this.LB_Country);
            this.Controls.Add(this.LB_Name);
            this.Controls.Add(this.LB_Title);
            this.Controls.Add(this.TB_Search);
            this.Controls.Add(this.BT_Search);
            this.Controls.Add(this.Data_Grid_View);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Cart_Detail_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Cart_Detail_Form";
            this.Load += new System.EventHandler(this.Add_Cart_Detail_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.Label LB_Money;
        private System.Windows.Forms.Label LB_UseFor_Data;
        private System.Windows.Forms.Label LB_UseFor;
        private System.Windows.Forms.Label LB_Country_Data;
        private System.Windows.Forms.Label LB_Price_Data;
        private System.Windows.Forms.Label LB_ID_Data;
        private System.Windows.Forms.Label LB_Name_Data;
        private System.Windows.Forms.Label LB_Price;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_CLose_Form;
        private System.Windows.Forms.Label LB_ID;
        private System.Windows.Forms.Label LB_Country;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.TextBox TB_Search;
        private System.Windows.Forms.Button BT_Search;
        private System.Windows.Forms.DataGridView Data_Grid_View;
        private System.Windows.Forms.Label LB_Quantity;
        private System.Windows.Forms.TextBox TB_Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_CartID;
        private System.Windows.Forms.Label LB_Saved;
    }
}