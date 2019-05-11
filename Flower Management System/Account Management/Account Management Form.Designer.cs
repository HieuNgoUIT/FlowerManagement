namespace Flower_Management_System.Account_Management
{
    partial class Account_Management_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_Management_Form));
            this.Data_Grid_View = new System.Windows.Forms.DataGridView();
            this.Employee_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_CLose_Form = new System.Windows.Forms.Button();
            this.BT_Refresh = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_Update = new System.Windows.Forms.Button();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.BT_Search = new System.Windows.Forms.Button();
            this.LB_Title = new System.Windows.Forms.Label();
            this.TB_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid_View)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Grid_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Data_Grid_View.ColumnHeadersHeight = 50;
            this.Data_Grid_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Data_Grid_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee_ID,
            this.Username,
            this.Password});
            this.Data_Grid_View.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Grid_View.DefaultCellStyle = dataGridViewCellStyle4;
            this.Data_Grid_View.EnableHeadersVisualStyles = false;
            this.Data_Grid_View.Location = new System.Drawing.Point(36, 101);
            this.Data_Grid_View.MultiSelect = false;
            this.Data_Grid_View.Name = "Data_Grid_View";
            this.Data_Grid_View.RowHeadersVisible = false;
            this.Data_Grid_View.RowTemplate.Height = 50;
            this.Data_Grid_View.RowTemplate.ReadOnly = true;
            this.Data_Grid_View.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Grid_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data_Grid_View.Size = new System.Drawing.Size(726, 433);
            this.Data_Grid_View.TabIndex = 19;
            this.Data_Grid_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Grid_View_CellClick);
            // 
            // Employee_ID
            // 
            this.Employee_ID.DataPropertyName = "Employee_ID";
            this.Employee_ID.HeaderText = "ID";
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.Width = 125;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.Width = 300;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.Width = 300;
            // 
            // BT_CLose_Form
            // 
            this.BT_CLose_Form.BackColor = System.Drawing.Color.White;
            this.BT_CLose_Form.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_CLose_Form.BackgroundImage")));
            this.BT_CLose_Form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_CLose_Form.Location = new System.Drawing.Point(738, 16);
            this.BT_CLose_Form.Name = "BT_CLose_Form";
            this.BT_CLose_Form.Size = new System.Drawing.Size(32, 32);
            this.BT_CLose_Form.TabIndex = 20;
            this.BT_CLose_Form.UseVisualStyleBackColor = false;
            this.BT_CLose_Form.Click += new System.EventHandler(this.BT_CLose_Form_Click);
            this.BT_CLose_Form.MouseEnter += new System.EventHandler(this.BT_CLose_Form_MouseEnter);
            this.BT_CLose_Form.MouseLeave += new System.EventHandler(this.BT_CLose_Form_MouseLeave);
            // 
            // BT_Refresh
            // 
            this.BT_Refresh.BackColor = System.Drawing.Color.White;
            this.BT_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Refresh.BackgroundImage")));
            this.BT_Refresh.Location = new System.Drawing.Point(53, 560);
            this.BT_Refresh.Name = "BT_Refresh";
            this.BT_Refresh.Size = new System.Drawing.Size(64, 52);
            this.BT_Refresh.TabIndex = 36;
            this.BT_Refresh.UseVisualStyleBackColor = false;
            this.BT_Refresh.Click += new System.EventHandler(this.BT_Refresh_Click);
            this.BT_Refresh.MouseEnter += new System.EventHandler(this.BT_Refresh_MouseEnter);
            this.BT_Refresh.MouseLeave += new System.EventHandler(this.BT_Refresh_MouseLeave);
            // 
            // BT_Save
            // 
            this.BT_Save.BackColor = System.Drawing.Color.White;
            this.BT_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Save.BackgroundImage")));
            this.BT_Save.Location = new System.Drawing.Point(636, 554);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(64, 64);
            this.BT_Save.TabIndex = 35;
            this.BT_Save.UseVisualStyleBackColor = false;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            this.BT_Save.MouseEnter += new System.EventHandler(this.BT_Save_MouseEnter);
            this.BT_Save.MouseLeave += new System.EventHandler(this.BT_Save_MouseLeave);
            // 
            // BT_Update
            // 
            this.BT_Update.BackColor = System.Drawing.Color.White;
            this.BT_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Update.BackgroundImage")));
            this.BT_Update.Location = new System.Drawing.Point(400, 554);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(64, 64);
            this.BT_Update.TabIndex = 34;
            this.BT_Update.UseVisualStyleBackColor = false;
            this.BT_Update.Click += new System.EventHandler(this.BT_Update_Click);
            this.BT_Update.MouseEnter += new System.EventHandler(this.BT_Update_MouseEnter);
            this.BT_Update.MouseLeave += new System.EventHandler(this.BT_Update_MouseLeave);
            // 
            // BT_Delete
            // 
            this.BT_Delete.BackColor = System.Drawing.Color.White;
            this.BT_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Delete.BackgroundImage")));
            this.BT_Delete.Location = new System.Drawing.Point(518, 554);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(64, 64);
            this.BT_Delete.TabIndex = 33;
            this.BT_Delete.UseVisualStyleBackColor = false;
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            this.BT_Delete.MouseEnter += new System.EventHandler(this.BT_Delete_MouseEnter);
            this.BT_Delete.MouseLeave += new System.EventHandler(this.BT_Delete_MouseLeave);
            // 
            // BT_Search
            // 
            this.BT_Search.BackColor = System.Drawing.Color.White;
            this.BT_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Search.BackgroundImage")));
            this.BT_Search.Location = new System.Drawing.Point(282, 554);
            this.BT_Search.Name = "BT_Search";
            this.BT_Search.Size = new System.Drawing.Size(64, 64);
            this.BT_Search.TabIndex = 31;
            this.BT_Search.UseVisualStyleBackColor = false;
            this.BT_Search.Click += new System.EventHandler(this.BT_Search_Click);
            this.BT_Search.MouseEnter += new System.EventHandler(this.BT_Search_MouseEnter);
            this.BT_Search.MouseLeave += new System.EventHandler(this.BT_Search_MouseLeave);
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.BackColor = System.Drawing.Color.White;
            this.LB_Title.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LB_Title.Location = new System.Drawing.Point(94, 32);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(322, 41);
            this.LB_Title.TabIndex = 37;
            this.LB_Title.Text = "ACCOUNT MANAGEMENT";
            // 
            // TB_Search
            // 
            this.TB_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Search.Location = new System.Drawing.Point(156, 567);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(87, 36);
            this.TB_Search.TabIndex = 38;
            this.TB_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Account_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(794, 650);
            this.Controls.Add(this.TB_Search);
            this.Controls.Add(this.LB_Title);
            this.Controls.Add(this.BT_Refresh);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.BT_Update);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.BT_Search);
            this.Controls.Add(this.BT_CLose_Form);
            this.Controls.Add(this.Data_Grid_View);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account_Management_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account_Management_Form";
            this.Load += new System.EventHandler(this.Account_Management_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data_Grid_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Button BT_CLose_Form;
        private System.Windows.Forms.Button BT_Refresh;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Button BT_Delete;
        private System.Windows.Forms.Button BT_Search;
        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.TextBox TB_Search;
    }
}