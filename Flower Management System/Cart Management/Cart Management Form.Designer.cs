namespace Flower_Management_System.Cart_Management
{
    partial class Cart_Management_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart_Management_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PB_Picture = new System.Windows.Forms.PictureBox();
            this.LB_Money = new System.Windows.Forms.Label();
            this.LB_TotalPrice = new System.Windows.Forms.Label();
            this.BT_Refresh = new System.Windows.Forms.Button();
            this.LB_Price_Data = new System.Windows.Forms.Label();
            this.LB_CardID_Data = new System.Windows.Forms.Label();
            this.LB_CustomerName_Data = new System.Windows.Forms.Label();
            this.LB_DateBuy = new System.Windows.Forms.Label();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_CLose_Form = new System.Windows.Forms.Button();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.LB_CardID = new System.Windows.Forms.Label();
            this.LB_CustomerID = new System.Windows.Forms.Label();
            this.LB_Title = new System.Windows.Forms.Label();
            this.BT_Add = new System.Windows.Forms.Button();
            this.TB_Search = new System.Windows.Forms.TextBox();
            this.BT_Search = new System.Windows.Forms.Button();
            this.Data_Grid_View = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LB_CustomerName = new System.Windows.Forms.Label();
            this.LB_CustomerID_Data = new System.Windows.Forms.Label();
            this.LB_DateBuy_Data = new System.Windows.Forms.Label();
            this.DGV_CartDetail = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CartDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Picture
            // 
            this.PB_Picture.BackColor = System.Drawing.Color.White;
            this.PB_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Picture.Location = new System.Drawing.Point(1260, 158);
            this.PB_Picture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PB_Picture.Name = "PB_Picture";
            this.PB_Picture.Size = new System.Drawing.Size(460, 465);
            this.PB_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Picture.TabIndex = 106;
            this.PB_Picture.TabStop = false;
            // 
            // LB_Money
            // 
            this.LB_Money.AutoSize = true;
            this.LB_Money.BackColor = System.Drawing.Color.White;
            this.LB_Money.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Money.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LB_Money.Location = new System.Drawing.Point(956, 329);
            this.LB_Money.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Money.Name = "LB_Money";
            this.LB_Money.Size = new System.Drawing.Size(23, 25);
            this.LB_Money.TabIndex = 105;
            this.LB_Money.Text = "$";
            // 
            // LB_TotalPrice
            // 
            this.LB_TotalPrice.AutoSize = true;
            this.LB_TotalPrice.BackColor = System.Drawing.Color.White;
            this.LB_TotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TotalPrice.Location = new System.Drawing.Point(836, 329);
            this.LB_TotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_TotalPrice.Name = "LB_TotalPrice";
            this.LB_TotalPrice.Size = new System.Drawing.Size(110, 25);
            this.LB_TotalPrice.TabIndex = 103;
            this.LB_TotalPrice.Text = "Total price :";
            // 
            // BT_Refresh
            // 
            this.BT_Refresh.BackColor = System.Drawing.Color.White;
            this.BT_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Refresh.BackgroundImage")));
            this.BT_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Refresh.Location = new System.Drawing.Point(567, 121);
            this.BT_Refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BT_Refresh.Name = "BT_Refresh";
            this.BT_Refresh.Size = new System.Drawing.Size(80, 74);
            this.BT_Refresh.TabIndex = 102;
            this.BT_Refresh.UseVisualStyleBackColor = false;
            this.BT_Refresh.Click += new System.EventHandler(this.BT_Refresh_Click);
            this.BT_Refresh.MouseEnter += new System.EventHandler(this.BT_Refresh_MouseEnter);
            this.BT_Refresh.MouseLeave += new System.EventHandler(this.BT_Refresh_MouseLeave);
            // 
            // LB_Price_Data
            // 
            this.LB_Price_Data.AutoSize = true;
            this.LB_Price_Data.BackColor = System.Drawing.Color.White;
            this.LB_Price_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Price_Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LB_Price_Data.Location = new System.Drawing.Point(975, 329);
            this.LB_Price_Data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Price_Data.Name = "LB_Price_Data";
            this.LB_Price_Data.Size = new System.Drawing.Size(45, 25);
            this.LB_Price_Data.TabIndex = 100;
            this.LB_Price_Data.Text = "900";
            // 
            // LB_CardID_Data
            // 
            this.LB_CardID_Data.AutoSize = true;
            this.LB_CardID_Data.BackColor = System.Drawing.Color.White;
            this.LB_CardID_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CardID_Data.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LB_CardID_Data.Location = new System.Drawing.Point(660, 230);
            this.LB_CardID_Data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_CardID_Data.Name = "LB_CardID_Data";
            this.LB_CardID_Data.Size = new System.Drawing.Size(94, 25);
            this.LB_CardID_Data.TabIndex = 99;
            this.LB_CardID_Data.Text = "SC-00001";
            this.LB_CardID_Data.TextChanged += new System.EventHandler(this.LB_CardID_Data_TextChanged);
            this.LB_CardID_Data.Click += new System.EventHandler(this.LB_CardID_Data_Click);
            // 
            // LB_CustomerName_Data
            // 
            this.LB_CustomerName_Data.AutoSize = true;
            this.LB_CustomerName_Data.BackColor = System.Drawing.Color.White;
            this.LB_CustomerName_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CustomerName_Data.ForeColor = System.Drawing.Color.OrangeRed;
            this.LB_CustomerName_Data.Location = new System.Drawing.Point(739, 279);
            this.LB_CustomerName_Data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_CustomerName_Data.Name = "LB_CustomerName_Data";
            this.LB_CustomerName_Data.Size = new System.Drawing.Size(17, 25);
            this.LB_CustomerName_Data.TabIndex = 98;
            this.LB_CustomerName_Data.Text = ".";
            this.LB_CustomerName_Data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_DateBuy
            // 
            this.LB_DateBuy.AutoSize = true;
            this.LB_DateBuy.BackColor = System.Drawing.Color.White;
            this.LB_DateBuy.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DateBuy.Location = new System.Drawing.Point(561, 329);
            this.LB_DateBuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_DateBuy.Name = "LB_DateBuy";
            this.LB_DateBuy.Size = new System.Drawing.Size(100, 25);
            this.LB_DateBuy.TabIndex = 97;
            this.LB_DateBuy.Text = "Date buy :";
            // 
            // BT_Save
            // 
            this.BT_Save.BackColor = System.Drawing.Color.White;
            this.BT_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Save.BackgroundImage")));
            this.BT_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Save.Location = new System.Drawing.Point(1051, 121);
            this.BT_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(88, 74);
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
            this.BT_CLose_Form.Location = new System.Drawing.Point(1168, 22);
            this.BT_CLose_Form.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BT_CLose_Form.Name = "BT_CLose_Form";
            this.BT_CLose_Form.Size = new System.Drawing.Size(43, 39);
            this.BT_CLose_Form.TabIndex = 94;
            this.BT_CLose_Form.UseVisualStyleBackColor = false;
            this.BT_CLose_Form.Click += new System.EventHandler(this.BT_CLose_Form_Click);
            this.BT_CLose_Form.MouseEnter += new System.EventHandler(this.BT_CLose_Form_MouseEnter);
            this.BT_CLose_Form.MouseLeave += new System.EventHandler(this.BT_CLose_Form_MouseLeave);
            // 
            // BT_Delete
            // 
            this.BT_Delete.BackColor = System.Drawing.Color.White;
            this.BT_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Delete.BackgroundImage")));
            this.BT_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Delete.Location = new System.Drawing.Point(887, 121);
            this.BT_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(88, 74);
            this.BT_Delete.TabIndex = 92;
            this.BT_Delete.UseVisualStyleBackColor = false;
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            this.BT_Delete.MouseEnter += new System.EventHandler(this.BT_Delete_MouseEnter);
            this.BT_Delete.MouseLeave += new System.EventHandler(this.BT_Delete_MouseLeave);
            // 
            // LB_CardID
            // 
            this.LB_CardID.AutoSize = true;
            this.LB_CardID.BackColor = System.Drawing.Color.White;
            this.LB_CardID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CardID.Location = new System.Drawing.Point(561, 230);
            this.LB_CardID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_CardID.Name = "LB_CardID";
            this.LB_CardID.Size = new System.Drawing.Size(84, 25);
            this.LB_CardID.TabIndex = 91;
            this.LB_CardID.Text = "Cart ID :";
            // 
            // LB_CustomerID
            // 
            this.LB_CustomerID.AutoSize = true;
            this.LB_CustomerID.BackColor = System.Drawing.Color.White;
            this.LB_CustomerID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CustomerID.Location = new System.Drawing.Point(839, 230);
            this.LB_CustomerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_CustomerID.Name = "LB_CustomerID";
            this.LB_CustomerID.Size = new System.Drawing.Size(130, 25);
            this.LB_CustomerID.TabIndex = 89;
            this.LB_CustomerID.Text = "Customer ID :";
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.BackColor = System.Drawing.Color.White;
            this.LB_Title.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Title.ForeColor = System.Drawing.Color.OrangeRed;
            this.LB_Title.Location = new System.Drawing.Point(128, 39);
            this.LB_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(340, 52);
            this.LB_Title.TabIndex = 88;
            this.LB_Title.Text = "CART MANAGEMENT";
            // 
            // BT_Add
            // 
            this.BT_Add.BackColor = System.Drawing.Color.White;
            this.BT_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Add.BackgroundImage")));
            this.BT_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Add.Location = new System.Drawing.Point(723, 121);
            this.BT_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(88, 74);
            this.BT_Add.TabIndex = 87;
            this.BT_Add.UseVisualStyleBackColor = false;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            this.BT_Add.MouseEnter += new System.EventHandler(this.BT_Add_MouseEnter);
            this.BT_Add.MouseLeave += new System.EventHandler(this.BT_Add_MouseLeave);
            // 
            // TB_Search
            // 
            this.TB_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Search.Location = new System.Drawing.Point(137, 135);
            this.TB_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(177, 35);
            this.TB_Search.TabIndex = 86;
            // 
            // BT_Search
            // 
            this.BT_Search.BackColor = System.Drawing.Color.White;
            this.BT_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Search.BackgroundImage")));
            this.BT_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_Search.Location = new System.Drawing.Point(351, 121);
            this.BT_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BT_Search.Name = "BT_Search";
            this.BT_Search.Size = new System.Drawing.Size(67, 74);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Grid_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Data_Grid_View.ColumnHeadersHeight = 35;
            this.Data_Grid_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Data_Grid_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.Column2,
            this.Gender,
            this.Column1,
            this.Column3});
            this.Data_Grid_View.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Grid_View.DefaultCellStyle = dataGridViewCellStyle9;
            this.Data_Grid_View.Location = new System.Drawing.Point(29, 217);
            this.Data_Grid_View.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Data_Grid_View.MultiSelect = false;
            this.Data_Grid_View.Name = "Data_Grid_View";
            this.Data_Grid_View.RowHeadersVisible = false;
            this.Data_Grid_View.RowTemplate.Height = 50;
            this.Data_Grid_View.RowTemplate.ReadOnly = true;
            this.Data_Grid_View.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Grid_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data_Grid_View.Size = new System.Drawing.Size(467, 459);
            this.Data_Grid_View.TabIndex = 96;
            // 
            // c1
            // 
            this.c1.DataPropertyName = "ID";
            this.c1.HeaderText = "ID";
            this.c1.Name = "c1";
            this.c1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FullName";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column2.HeaderText = "Customer ID";
            this.Column2.Name = "Column2";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Price";
            this.Gender.HeaderText = "On Date";
            this.Gender.Name = "Gender";
            this.Gender.Width = 90;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UseFor";
            this.Column1.HeaderText = "Total Price";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FullName";
            this.Column3.HeaderText = "FullName";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // LB_CustomerName
            // 
            this.LB_CustomerName.AutoSize = true;
            this.LB_CustomerName.BackColor = System.Drawing.Color.White;
            this.LB_CustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CustomerName.Location = new System.Drawing.Point(561, 279);
            this.LB_CustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_CustomerName.Name = "LB_CustomerName";
            this.LB_CustomerName.Size = new System.Drawing.Size(162, 25);
            this.LB_CustomerName.TabIndex = 108;
            this.LB_CustomerName.Text = "Customer Name :";
            // 
            // LB_CustomerID_Data
            // 
            this.LB_CustomerID_Data.AutoSize = true;
            this.LB_CustomerID_Data.BackColor = System.Drawing.Color.White;
            this.LB_CustomerID_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CustomerID_Data.ForeColor = System.Drawing.Color.ForestGreen;
            this.LB_CustomerID_Data.Location = new System.Drawing.Point(992, 230);
            this.LB_CustomerID_Data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_CustomerID_Data.Name = "LB_CustomerID_Data";
            this.LB_CustomerID_Data.Size = new System.Drawing.Size(84, 25);
            this.LB_CustomerID_Data.TabIndex = 109;
            this.LB_CustomerID_Data.Text = "C-00001";
            // 
            // LB_DateBuy_Data
            // 
            this.LB_DateBuy_Data.AutoSize = true;
            this.LB_DateBuy_Data.BackColor = System.Drawing.Color.White;
            this.LB_DateBuy_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DateBuy_Data.Location = new System.Drawing.Point(677, 329);
            this.LB_DateBuy_Data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_DateBuy_Data.Name = "LB_DateBuy_Data";
            this.LB_DateBuy_Data.Size = new System.Drawing.Size(76, 25);
            this.LB_DateBuy_Data.TabIndex = 110;
            this.LB_DateBuy_Data.Text = "11/11/11";
            // 
            // DGV_CartDetail
            // 
            this.DGV_CartDetail.AllowUserToAddRows = false;
            this.DGV_CartDetail.AllowUserToDeleteRows = false;
            this.DGV_CartDetail.AllowUserToResizeColumns = false;
            this.DGV_CartDetail.AllowUserToResizeRows = false;
            this.DGV_CartDetail.BackgroundColor = System.Drawing.Color.White;
            this.DGV_CartDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_CartDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_CartDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGV_CartDetail.ColumnHeadersHeight = 35;
            this.DGV_CartDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_CartDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column4});
            this.DGV_CartDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_CartDetail.DefaultCellStyle = dataGridViewCellStyle12;
            this.DGV_CartDetail.EnableHeadersVisualStyles = false;
            this.DGV_CartDetail.Location = new System.Drawing.Point(567, 425);
            this.DGV_CartDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_CartDetail.MultiSelect = false;
            this.DGV_CartDetail.Name = "DGV_CartDetail";
            this.DGV_CartDetail.RowHeadersVisible = false;
            this.DGV_CartDetail.RowTemplate.Height = 50;
            this.DGV_CartDetail.RowTemplate.ReadOnly = true;
            this.DGV_CartDetail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_CartDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CartDetail.Size = new System.Drawing.Size(629, 324);
            this.DGV_CartDetail.TabIndex = 111;
            this.DGV_CartDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CartDetail_CellContentClick);
            this.DGV_CartDetail.Click += new System.EventHandler(this.DGV_CartDetail_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cart_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cart ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 113;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Flower_ID";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn2.HeaderText = "Flower ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 85;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Flower Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 220;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Picture";
            this.Column4.HeaderText = "Picture";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // Cart_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1749, 795);
            this.Controls.Add(this.DGV_CartDetail);
            this.Controls.Add(this.LB_DateBuy_Data);
            this.Controls.Add(this.LB_CustomerID_Data);
            this.Controls.Add(this.LB_CustomerName);
            this.Controls.Add(this.PB_Picture);
            this.Controls.Add(this.LB_Money);
            this.Controls.Add(this.LB_TotalPrice);
            this.Controls.Add(this.BT_Refresh);
            this.Controls.Add(this.LB_Price_Data);
            this.Controls.Add(this.LB_CardID_Data);
            this.Controls.Add(this.LB_CustomerName_Data);
            this.Controls.Add(this.LB_DateBuy);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.BT_CLose_Form);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.LB_CardID);
            this.Controls.Add(this.LB_CustomerID);
            this.Controls.Add(this.LB_Title);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.TB_Search);
            this.Controls.Add(this.BT_Search);
            this.Controls.Add(this.Data_Grid_View);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cart_Management_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart_Management";
            this.Load += new System.EventHandler(this.Cart_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CartDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Picture;
        private System.Windows.Forms.Label LB_Money;
        private System.Windows.Forms.Label LB_TotalPrice;
        private System.Windows.Forms.Button BT_Refresh;
        private System.Windows.Forms.Label LB_Price_Data;
        private System.Windows.Forms.Label LB_CardID_Data;
        private System.Windows.Forms.Label LB_CustomerName_Data;
        private System.Windows.Forms.Label LB_DateBuy;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_CLose_Form;
        private System.Windows.Forms.Button BT_Delete;
        private System.Windows.Forms.Label LB_CardID;
        private System.Windows.Forms.Label LB_CustomerID;
        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.TextBox TB_Search;
        private System.Windows.Forms.Button BT_Search;
        private System.Windows.Forms.DataGridView Data_Grid_View;
        private System.Windows.Forms.Label LB_CustomerName;
        private System.Windows.Forms.Label LB_CustomerID_Data;
        private System.Windows.Forms.Label LB_DateBuy_Data;
        private System.Windows.Forms.DataGridView DGV_CartDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}