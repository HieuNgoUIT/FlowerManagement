namespace Flower_Management_System.Employee_Management
{
    partial class Employee_Management_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Management_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BT_Search = new System.Windows.Forms.Button();
            this.TB_Search = new System.Windows.Forms.TextBox();
            this.BT_Add = new System.Windows.Forms.Button();
            this.LB_Title = new System.Windows.Forms.Label();
            this.LB_Name = new System.Windows.Forms.Label();
            this.LB_Salary = new System.Windows.Forms.Label();
            this.LB_Position = new System.Windows.Forms.Label();
            this.LB_Nationality = new System.Windows.Forms.Label();
            this.LB_Birthday = new System.Windows.Forms.Label();
            this.LB_ID = new System.Windows.Forms.Label();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.BT_Update = new System.Windows.Forms.Button();
            this.BT_CLose_Form = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.Data_Grid_View = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LB_Gender = new System.Windows.Forms.Label();
            this.LB_Name_Data = new System.Windows.Forms.Label();
            this.LB_ID_Data = new System.Windows.Forms.Label();
            this.LB_Birthday_Data = new System.Windows.Forms.Label();
            this.LB_Gender_Data = new System.Windows.Forms.Label();
            this.LB_Position_Data = new System.Windows.Forms.Label();
            this.LB_Salary_Data = new System.Windows.Forms.Label();
            this.LB_Nationality_Data = new System.Windows.Forms.Label();
            this.LB_Money_Symbol = new System.Windows.Forms.Label();
            this.BT_Refresh = new System.Windows.Forms.Button();
            this.LB_PhoneNumber = new System.Windows.Forms.Label();
            this.LB_PhoneNumer_Data = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid_View)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Search
            // 
            this.BT_Search.BackColor = System.Drawing.Color.White;
            this.BT_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Search.BackgroundImage")));
            this.BT_Search.Location = new System.Drawing.Point(500, 111);
            this.BT_Search.Name = "BT_Search";
            this.BT_Search.Size = new System.Drawing.Size(64, 64);
            this.BT_Search.TabIndex = 0;
            this.BT_Search.UseVisualStyleBackColor = false;
            this.BT_Search.Click += new System.EventHandler(this.BT_Search_Click);
            this.BT_Search.MouseEnter += new System.EventHandler(this.BT_Search_MouseEnter);
            this.BT_Search.MouseLeave += new System.EventHandler(this.BT_Search_MouseLeave);
            // 
            // TB_Search
            // 
            this.TB_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Search.Location = new System.Drawing.Point(83, 126);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(372, 36);
            this.TB_Search.TabIndex = 2;
            // 
            // BT_Add
            // 
            this.BT_Add.BackColor = System.Drawing.Color.White;
            this.BT_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Add.BackgroundImage")));
            this.BT_Add.Location = new System.Drawing.Point(700, 111);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(64, 64);
            this.BT_Add.TabIndex = 3;
            this.BT_Add.UseVisualStyleBackColor = false;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            this.BT_Add.MouseEnter += new System.EventHandler(this.BT_Add_MouseEnter);
            this.BT_Add.MouseLeave += new System.EventHandler(this.BT_Add_MouseLeave);
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.BackColor = System.Drawing.Color.White;
            this.LB_Title.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Title.Location = new System.Drawing.Point(97, 52);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(331, 41);
            this.LB_Title.TabIndex = 5;
            this.LB_Title.Text = "EMPLOYEE MANAGEMENT";
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.BackColor = System.Drawing.Color.White;
            this.LB_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name.Location = new System.Drawing.Point(644, 215);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(81, 30);
            this.LB_Name.TabIndex = 6;
            this.LB_Name.Text = "Name :";
            // 
            // LB_Salary
            // 
            this.LB_Salary.AutoSize = true;
            this.LB_Salary.BackColor = System.Drawing.Color.White;
            this.LB_Salary.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Salary.Location = new System.Drawing.Point(894, 545);
            this.LB_Salary.Name = "LB_Salary";
            this.LB_Salary.Size = new System.Drawing.Size(82, 30);
            this.LB_Salary.TabIndex = 9;
            this.LB_Salary.Text = "Salary :";
            // 
            // LB_Position
            // 
            this.LB_Position.AutoSize = true;
            this.LB_Position.BackColor = System.Drawing.Color.White;
            this.LB_Position.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Position.Location = new System.Drawing.Point(644, 545);
            this.LB_Position.Name = "LB_Position";
            this.LB_Position.Size = new System.Drawing.Size(100, 30);
            this.LB_Position.TabIndex = 10;
            this.LB_Position.Text = "Position :";
            // 
            // LB_Nationality
            // 
            this.LB_Nationality.AutoSize = true;
            this.LB_Nationality.BackColor = System.Drawing.Color.White;
            this.LB_Nationality.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Nationality.Location = new System.Drawing.Point(644, 479);
            this.LB_Nationality.Name = "LB_Nationality";
            this.LB_Nationality.Size = new System.Drawing.Size(129, 30);
            this.LB_Nationality.TabIndex = 11;
            this.LB_Nationality.Text = "Nationality :";
            // 
            // LB_Birthday
            // 
            this.LB_Birthday.AutoSize = true;
            this.LB_Birthday.BackColor = System.Drawing.Color.White;
            this.LB_Birthday.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Birthday.Location = new System.Drawing.Point(644, 347);
            this.LB_Birthday.Name = "LB_Birthday";
            this.LB_Birthday.Size = new System.Drawing.Size(106, 30);
            this.LB_Birthday.TabIndex = 12;
            this.LB_Birthday.Text = "Birthday :";
            // 
            // LB_ID
            // 
            this.LB_ID.AutoSize = true;
            this.LB_ID.BackColor = System.Drawing.Color.White;
            this.LB_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ID.Location = new System.Drawing.Point(644, 281);
            this.LB_ID.Name = "LB_ID";
            this.LB_ID.Size = new System.Drawing.Size(45, 30);
            this.LB_ID.TabIndex = 13;
            this.LB_ID.Text = "ID :";
            // 
            // BT_Delete
            // 
            this.BT_Delete.BackColor = System.Drawing.Color.White;
            this.BT_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Delete.BackgroundImage")));
            this.BT_Delete.Location = new System.Drawing.Point(908, 111);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(64, 64);
            this.BT_Delete.TabIndex = 14;
            this.BT_Delete.UseVisualStyleBackColor = false;
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            this.BT_Delete.MouseEnter += new System.EventHandler(this.BT_Delete_MouseEnter);
            this.BT_Delete.MouseLeave += new System.EventHandler(this.BT_Delete_MouseLeave);
            // 
            // BT_Update
            // 
            this.BT_Update.BackColor = System.Drawing.Color.White;
            this.BT_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Update.BackgroundImage")));
            this.BT_Update.Location = new System.Drawing.Point(804, 111);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(64, 64);
            this.BT_Update.TabIndex = 15;
            this.BT_Update.UseVisualStyleBackColor = false;
            this.BT_Update.Click += new System.EventHandler(this.BT_Update_Click);
            this.BT_Update.MouseEnter += new System.EventHandler(this.BT_Update_MouseEnter);
            this.BT_Update.MouseLeave += new System.EventHandler(this.BT_Update_MouseLeave);
            // 
            // BT_CLose_Form
            // 
            this.BT_CLose_Form.BackColor = System.Drawing.Color.White;
            this.BT_CLose_Form.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_CLose_Form.BackgroundImage")));
            this.BT_CLose_Form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_CLose_Form.Location = new System.Drawing.Point(1065, 12);
            this.BT_CLose_Form.Name = "BT_CLose_Form";
            this.BT_CLose_Form.Size = new System.Drawing.Size(32, 32);
            this.BT_CLose_Form.TabIndex = 16;
            this.BT_CLose_Form.UseVisualStyleBackColor = false;
            this.BT_CLose_Form.Click += new System.EventHandler(this.BT_CLose_Form_Click);
            this.BT_CLose_Form.MouseEnter += new System.EventHandler(this.BT_CLose_Form_MouseEnter);
            this.BT_CLose_Form.MouseLeave += new System.EventHandler(this.BT_CLose_Form_MouseLeave);
            // 
            // BT_Save
            // 
            this.BT_Save.BackColor = System.Drawing.Color.White;
            this.BT_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Save.BackgroundImage")));
            this.BT_Save.Location = new System.Drawing.Point(1012, 111);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(64, 64);
            this.BT_Save.TabIndex = 17;
            this.BT_Save.UseVisualStyleBackColor = false;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            this.BT_Save.MouseEnter += new System.EventHandler(this.BT_Save_MouseEnter);
            this.BT_Save.MouseLeave += new System.EventHandler(this.BT_Save_MouseLeave);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Username,
            this.Password,
            this.Birthday,
            this.Gender,
            this.Column1,
            this.Nationality,
            this.Position,
            this.Salary});
            this.Data_Grid_View.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Grid_View.DefaultCellStyle = dataGridViewCellStyle3;
            this.Data_Grid_View.EnableHeadersVisualStyles = false;
            this.Data_Grid_View.Location = new System.Drawing.Point(23, 204);
            this.Data_Grid_View.MultiSelect = false;
            this.Data_Grid_View.Name = "Data_Grid_View";
            this.Data_Grid_View.RowHeadersVisible = false;
            this.Data_Grid_View.RowTemplate.Height = 50;
            this.Data_Grid_View.RowTemplate.ReadOnly = true;
            this.Data_Grid_View.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Grid_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data_Grid_View.Size = new System.Drawing.Size(562, 385);
            this.Data_Grid_View.TabIndex = 18;
            // 
            // c1
            // 
            this.c1.DataPropertyName = "ID";
            this.c1.HeaderText = "ID";
            this.c1.Name = "c1";
            this.c1.Width = 124;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FullName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Full Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 435;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.Visible = false;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.Visible = false;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.Name = "Birthday";
            this.Birthday.Visible = false;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PhoneNumber";
            this.Column1.HeaderText = "PhoneNumber";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Nationality
            // 
            this.Nationality.DataPropertyName = "Nationality";
            this.Nationality.HeaderText = "Nationality";
            this.Nationality.Name = "Nationality";
            this.Nationality.Visible = false;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.Visible = false;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.Visible = false;
            // 
            // LB_Gender
            // 
            this.LB_Gender.AutoSize = true;
            this.LB_Gender.BackColor = System.Drawing.Color.White;
            this.LB_Gender.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Gender.Location = new System.Drawing.Point(894, 347);
            this.LB_Gender.Name = "LB_Gender";
            this.LB_Gender.Size = new System.Drawing.Size(94, 30);
            this.LB_Gender.TabIndex = 20;
            this.LB_Gender.Text = "Gender :";
            // 
            // LB_Name_Data
            // 
            this.LB_Name_Data.AutoSize = true;
            this.LB_Name_Data.BackColor = System.Drawing.Color.White;
            this.LB_Name_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name_Data.Location = new System.Drawing.Point(731, 215);
            this.LB_Name_Data.Name = "LB_Name_Data";
            this.LB_Name_Data.Size = new System.Drawing.Size(28, 30);
            this.LB_Name_Data.TabIndex = 21;
            this.LB_Name_Data.Text = "...";
            this.LB_Name_Data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_ID_Data
            // 
            this.LB_ID_Data.AutoSize = true;
            this.LB_ID_Data.BackColor = System.Drawing.Color.White;
            this.LB_ID_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ID_Data.Location = new System.Drawing.Point(695, 281);
            this.LB_ID_Data.Name = "LB_ID_Data";
            this.LB_ID_Data.Size = new System.Drawing.Size(28, 30);
            this.LB_ID_Data.TabIndex = 22;
            this.LB_ID_Data.Text = "...";
            // 
            // LB_Birthday_Data
            // 
            this.LB_Birthday_Data.AutoSize = true;
            this.LB_Birthday_Data.BackColor = System.Drawing.Color.White;
            this.LB_Birthday_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Birthday_Data.Location = new System.Drawing.Point(756, 347);
            this.LB_Birthday_Data.Name = "LB_Birthday_Data";
            this.LB_Birthday_Data.Size = new System.Drawing.Size(28, 30);
            this.LB_Birthday_Data.TabIndex = 23;
            this.LB_Birthday_Data.Text = "...";
            // 
            // LB_Gender_Data
            // 
            this.LB_Gender_Data.AutoSize = true;
            this.LB_Gender_Data.BackColor = System.Drawing.Color.White;
            this.LB_Gender_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Gender_Data.Location = new System.Drawing.Point(994, 347);
            this.LB_Gender_Data.Name = "LB_Gender_Data";
            this.LB_Gender_Data.Size = new System.Drawing.Size(28, 30);
            this.LB_Gender_Data.TabIndex = 24;
            this.LB_Gender_Data.Text = "...";
            // 
            // LB_Position_Data
            // 
            this.LB_Position_Data.AutoSize = true;
            this.LB_Position_Data.BackColor = System.Drawing.Color.White;
            this.LB_Position_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Position_Data.Location = new System.Drawing.Point(750, 545);
            this.LB_Position_Data.Name = "LB_Position_Data";
            this.LB_Position_Data.Size = new System.Drawing.Size(28, 30);
            this.LB_Position_Data.TabIndex = 26;
            this.LB_Position_Data.Text = "...";
            // 
            // LB_Salary_Data
            // 
            this.LB_Salary_Data.AutoSize = true;
            this.LB_Salary_Data.BackColor = System.Drawing.Color.White;
            this.LB_Salary_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Salary_Data.Location = new System.Drawing.Point(991, 545);
            this.LB_Salary_Data.Name = "LB_Salary_Data";
            this.LB_Salary_Data.Size = new System.Drawing.Size(28, 30);
            this.LB_Salary_Data.TabIndex = 27;
            this.LB_Salary_Data.Text = "...";
            // 
            // LB_Nationality_Data
            // 
            this.LB_Nationality_Data.AutoSize = true;
            this.LB_Nationality_Data.BackColor = System.Drawing.Color.White;
            this.LB_Nationality_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Nationality_Data.Location = new System.Drawing.Point(779, 479);
            this.LB_Nationality_Data.Name = "LB_Nationality_Data";
            this.LB_Nationality_Data.Size = new System.Drawing.Size(28, 30);
            this.LB_Nationality_Data.TabIndex = 28;
            this.LB_Nationality_Data.Text = "...";
            // 
            // LB_Money_Symbol
            // 
            this.LB_Money_Symbol.AutoSize = true;
            this.LB_Money_Symbol.BackColor = System.Drawing.Color.White;
            this.LB_Money_Symbol.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Money_Symbol.Location = new System.Drawing.Point(972, 545);
            this.LB_Money_Symbol.Name = "LB_Money_Symbol";
            this.LB_Money_Symbol.Size = new System.Drawing.Size(25, 30);
            this.LB_Money_Symbol.TabIndex = 29;
            this.LB_Money_Symbol.Text = "$";
            // 
            // BT_Refresh
            // 
            this.BT_Refresh.BackColor = System.Drawing.Color.White;
            this.BT_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Refresh.BackgroundImage")));
            this.BT_Refresh.Location = new System.Drawing.Point(604, 111);
            this.BT_Refresh.Name = "BT_Refresh";
            this.BT_Refresh.Size = new System.Drawing.Size(56, 64);
            this.BT_Refresh.TabIndex = 30;
            this.BT_Refresh.UseVisualStyleBackColor = false;
            this.BT_Refresh.Click += new System.EventHandler(this.BT_Refresh_Click);
            this.BT_Refresh.MouseEnter += new System.EventHandler(this.BT_Refresh_MouseEnter);
            this.BT_Refresh.MouseLeave += new System.EventHandler(this.BT_Refresh_MouseLeave);
            // 
            // LB_PhoneNumber
            // 
            this.LB_PhoneNumber.AutoSize = true;
            this.LB_PhoneNumber.BackColor = System.Drawing.Color.White;
            this.LB_PhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PhoneNumber.Location = new System.Drawing.Point(644, 413);
            this.LB_PhoneNumber.Name = "LB_PhoneNumber";
            this.LB_PhoneNumber.Size = new System.Drawing.Size(169, 30);
            this.LB_PhoneNumber.TabIndex = 31;
            this.LB_PhoneNumber.Text = "Phone Number :";
            // 
            // LB_PhoneNumer_Data
            // 
            this.LB_PhoneNumer_Data.AutoSize = true;
            this.LB_PhoneNumer_Data.BackColor = System.Drawing.Color.White;
            this.LB_PhoneNumer_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PhoneNumer_Data.Location = new System.Drawing.Point(819, 413);
            this.LB_PhoneNumer_Data.Name = "LB_PhoneNumer_Data";
            this.LB_PhoneNumer_Data.Size = new System.Drawing.Size(28, 30);
            this.LB_PhoneNumer_Data.TabIndex = 32;
            this.LB_PhoneNumer_Data.Text = "...";
            // 
            // Employee_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1104, 611);
            this.Controls.Add(this.LB_PhoneNumer_Data);
            this.Controls.Add(this.LB_PhoneNumber);
            this.Controls.Add(this.BT_Refresh);
            this.Controls.Add(this.LB_Money_Symbol);
            this.Controls.Add(this.LB_Nationality_Data);
            this.Controls.Add(this.LB_Salary_Data);
            this.Controls.Add(this.LB_Position_Data);
            this.Controls.Add(this.LB_Gender_Data);
            this.Controls.Add(this.LB_Birthday_Data);
            this.Controls.Add(this.LB_ID_Data);
            this.Controls.Add(this.LB_Name_Data);
            this.Controls.Add(this.LB_Gender);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.BT_CLose_Form);
            this.Controls.Add(this.BT_Update);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.LB_ID);
            this.Controls.Add(this.LB_Birthday);
            this.Controls.Add(this.LB_Nationality);
            this.Controls.Add(this.LB_Position);
            this.Controls.Add(this.LB_Salary);
            this.Controls.Add(this.LB_Name);
            this.Controls.Add(this.LB_Title);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.TB_Search);
            this.Controls.Add(this.BT_Search);
            this.Controls.Add(this.Data_Grid_View);
            this.Name = "Employee_Management_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Management_Form";
            this.Load += new System.EventHandler(this.Employee_Management_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Search;
        private System.Windows.Forms.TextBox TB_Search;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.Label LB_Salary;
        private System.Windows.Forms.Label LB_Position;
        private System.Windows.Forms.Label LB_Nationality;
        private System.Windows.Forms.Label LB_Birthday;
        private System.Windows.Forms.Label LB_ID;
        private System.Windows.Forms.Button BT_Delete;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Button BT_CLose_Form;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.DataGridView Data_Grid_View;
        private System.Windows.Forms.Label LB_Gender;
        private System.Windows.Forms.Label LB_Name_Data;
        private System.Windows.Forms.Label LB_ID_Data;
        private System.Windows.Forms.Label LB_Birthday_Data;
        private System.Windows.Forms.Label LB_Gender_Data;
        private System.Windows.Forms.Label LB_Position_Data;
        private System.Windows.Forms.Label LB_Salary_Data;
        private System.Windows.Forms.Label LB_Nationality_Data;
        private System.Windows.Forms.Label LB_Money_Symbol;
        private System.Windows.Forms.Button BT_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.Label LB_PhoneNumber;
        private System.Windows.Forms.Label LB_PhoneNumer_Data;
    }
}