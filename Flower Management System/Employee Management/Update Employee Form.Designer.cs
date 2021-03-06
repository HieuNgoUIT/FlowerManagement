﻿namespace Flower_Management_System.Employee_Management
{
    partial class Update_Employee_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Employee_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Salary = new System.Windows.Forms.TextBox();
            this.TB_PhoneNumber = new System.Windows.Forms.TextBox();
            this.LB_PhoneNumber = new System.Windows.Forms.Label();
            this.MTB_Birthday = new System.Windows.Forms.MaskedTextBox();
            this.TB_Gender = new System.Windows.Forms.TextBox();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.TB_Nationality = new System.Windows.Forms.TextBox();
            this.TB_Position = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_CLose_Form = new System.Windows.Forms.Button();
            this.LB_Money_Symbol = new System.Windows.Forms.Label();
            this.LB_Gender = new System.Windows.Forms.Label();
            this.LB_ID = new System.Windows.Forms.Label();
            this.LB_Birthday = new System.Windows.Forms.Label();
            this.LB_Nationality = new System.Windows.Forms.Label();
            this.LB_Position = new System.Windows.Forms.Label();
            this.LB_Salary = new System.Windows.Forms.Label();
            this.LB_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(106, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 29);
            this.label1.TabIndex = 66;
            this.label1.Text = "UPDATE EMPLOYEE INFORMATION";
            // 
            // TB_Salary
            // 
            this.TB_Salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Salary.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Salary.Location = new System.Drawing.Point(414, 454);
            this.TB_Salary.Name = "TB_Salary";
            this.TB_Salary.Size = new System.Drawing.Size(74, 27);
            this.TB_Salary.TabIndex = 86;
            this.TB_Salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_PhoneNumber
            // 
            this.TB_PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_PhoneNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_PhoneNumber.Location = new System.Drawing.Point(207, 325);
            this.TB_PhoneNumber.Name = "TB_PhoneNumber";
            this.TB_PhoneNumber.Size = new System.Drawing.Size(142, 27);
            this.TB_PhoneNumber.TabIndex = 85;
            this.TB_PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LB_PhoneNumber
            // 
            this.LB_PhoneNumber.AutoSize = true;
            this.LB_PhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.LB_PhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PhoneNumber.Location = new System.Drawing.Point(23, 327);
            this.LB_PhoneNumber.Name = "LB_PhoneNumber";
            this.LB_PhoneNumber.Size = new System.Drawing.Size(169, 30);
            this.LB_PhoneNumber.TabIndex = 84;
            this.LB_PhoneNumber.Text = "Phone Number :";
            // 
            // MTB_Birthday
            // 
            this.MTB_Birthday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MTB_Birthday.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTB_Birthday.Location = new System.Drawing.Point(147, 261);
            this.MTB_Birthday.Mask = "00/00/0000";
            this.MTB_Birthday.Name = "MTB_Birthday";
            this.MTB_Birthday.Size = new System.Drawing.Size(133, 27);
            this.MTB_Birthday.TabIndex = 82;
            this.MTB_Birthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MTB_Birthday.ValidatingType = typeof(System.DateTime);
            // 
            // TB_Gender
            // 
            this.TB_Gender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Gender.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Gender.Location = new System.Drawing.Point(399, 260);
            this.TB_Gender.Name = "TB_Gender";
            this.TB_Gender.Size = new System.Drawing.Size(93, 27);
            this.TB_Gender.TabIndex = 81;
            this.TB_Gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_ID
            // 
            this.TB_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_ID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ID.Location = new System.Drawing.Point(88, 197);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(106, 27);
            this.TB_ID.TabIndex = 80;
            this.TB_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Nationality
            // 
            this.TB_Nationality.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Nationality.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nationality.Location = new System.Drawing.Point(173, 389);
            this.TB_Nationality.Name = "TB_Nationality";
            this.TB_Nationality.Size = new System.Drawing.Size(318, 27);
            this.TB_Nationality.TabIndex = 79;
            this.TB_Nationality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Position
            // 
            this.TB_Position.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Position.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Position.Location = new System.Drawing.Point(142, 454);
            this.TB_Position.Name = "TB_Position";
            this.TB_Position.Size = new System.Drawing.Size(136, 27);
            this.TB_Position.TabIndex = 78;
            this.TB_Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Name
            // 
            this.TB_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Name.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Name.Location = new System.Drawing.Point(129, 130);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(332, 27);
            this.TB_Name.TabIndex = 77;
            this.TB_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT_Save
            // 
            this.BT_Save.BackColor = System.Drawing.Color.White;
            this.BT_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Save.BackgroundImage")));
            this.BT_Save.Location = new System.Drawing.Point(240, 514);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(64, 64);
            this.BT_Save.TabIndex = 76;
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
            this.BT_CLose_Form.Location = new System.Drawing.Point(478, 22);
            this.BT_CLose_Form.Name = "BT_CLose_Form";
            this.BT_CLose_Form.Size = new System.Drawing.Size(32, 32);
            this.BT_CLose_Form.TabIndex = 75;
            this.BT_CLose_Form.UseVisualStyleBackColor = false;
            this.BT_CLose_Form.Click += new System.EventHandler(this.BT_CLose_Form_Click);
            this.BT_CLose_Form.MouseEnter += new System.EventHandler(this.BT_CLose_Form_MouseEnter);
            this.BT_CLose_Form.MouseLeave += new System.EventHandler(this.BT_CLose_Form_MouseLeave);
            // 
            // LB_Money_Symbol
            // 
            this.LB_Money_Symbol.AutoSize = true;
            this.LB_Money_Symbol.BackColor = System.Drawing.Color.Transparent;
            this.LB_Money_Symbol.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Money_Symbol.Location = new System.Drawing.Point(373, 457);
            this.LB_Money_Symbol.Name = "LB_Money_Symbol";
            this.LB_Money_Symbol.Size = new System.Drawing.Size(25, 30);
            this.LB_Money_Symbol.TabIndex = 74;
            this.LB_Money_Symbol.Text = "$";
            // 
            // LB_Gender
            // 
            this.LB_Gender.AutoSize = true;
            this.LB_Gender.BackColor = System.Drawing.Color.Transparent;
            this.LB_Gender.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Gender.Location = new System.Drawing.Point(292, 261);
            this.LB_Gender.Name = "LB_Gender";
            this.LB_Gender.Size = new System.Drawing.Size(94, 30);
            this.LB_Gender.TabIndex = 73;
            this.LB_Gender.Text = "Gender :";
            // 
            // LB_ID
            // 
            this.LB_ID.AutoSize = true;
            this.LB_ID.BackColor = System.Drawing.Color.Transparent;
            this.LB_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ID.Location = new System.Drawing.Point(24, 197);
            this.LB_ID.Name = "LB_ID";
            this.LB_ID.Size = new System.Drawing.Size(45, 30);
            this.LB_ID.TabIndex = 72;
            this.LB_ID.Text = "ID :";
            // 
            // LB_Birthday
            // 
            this.LB_Birthday.AutoSize = true;
            this.LB_Birthday.BackColor = System.Drawing.Color.Transparent;
            this.LB_Birthday.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Birthday.Location = new System.Drawing.Point(24, 261);
            this.LB_Birthday.Name = "LB_Birthday";
            this.LB_Birthday.Size = new System.Drawing.Size(106, 30);
            this.LB_Birthday.TabIndex = 71;
            this.LB_Birthday.Text = "Birthday :";
            // 
            // LB_Nationality
            // 
            this.LB_Nationality.AutoSize = true;
            this.LB_Nationality.BackColor = System.Drawing.Color.Transparent;
            this.LB_Nationality.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Nationality.Location = new System.Drawing.Point(23, 392);
            this.LB_Nationality.Name = "LB_Nationality";
            this.LB_Nationality.Size = new System.Drawing.Size(129, 30);
            this.LB_Nationality.TabIndex = 70;
            this.LB_Nationality.Text = "Nationality :";
            // 
            // LB_Position
            // 
            this.LB_Position.AutoSize = true;
            this.LB_Position.BackColor = System.Drawing.Color.Transparent;
            this.LB_Position.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Position.Location = new System.Drawing.Point(23, 457);
            this.LB_Position.Name = "LB_Position";
            this.LB_Position.Size = new System.Drawing.Size(100, 30);
            this.LB_Position.TabIndex = 69;
            this.LB_Position.Text = "Position :";
            // 
            // LB_Salary
            // 
            this.LB_Salary.AutoSize = true;
            this.LB_Salary.BackColor = System.Drawing.Color.Transparent;
            this.LB_Salary.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Salary.Location = new System.Drawing.Point(291, 457);
            this.LB_Salary.Name = "LB_Salary";
            this.LB_Salary.Size = new System.Drawing.Size(82, 30);
            this.LB_Salary.TabIndex = 68;
            this.LB_Salary.Text = "Salary :";
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.BackColor = System.Drawing.Color.Transparent;
            this.LB_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name.Location = new System.Drawing.Point(24, 132);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(81, 30);
            this.LB_Name.TabIndex = 67;
            this.LB_Name.Text = "Name :";
            // 
            // Update_Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(548, 601);
            this.Controls.Add(this.TB_Salary);
            this.Controls.Add(this.TB_PhoneNumber);
            this.Controls.Add(this.LB_PhoneNumber);
            this.Controls.Add(this.MTB_Birthday);
            this.Controls.Add(this.TB_Gender);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.TB_Nationality);
            this.Controls.Add(this.TB_Position);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.BT_CLose_Form);
            this.Controls.Add(this.LB_Money_Symbol);
            this.Controls.Add(this.LB_Gender);
            this.Controls.Add(this.LB_ID);
            this.Controls.Add(this.LB_Birthday);
            this.Controls.Add(this.LB_Nationality);
            this.Controls.Add(this.LB_Position);
            this.Controls.Add(this.LB_Salary);
            this.Controls.Add(this.LB_Name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update_Employee_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Employee_Form";
            this.Load += new System.EventHandler(this.Update_Employee_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Salary;
        private System.Windows.Forms.TextBox TB_PhoneNumber;
        private System.Windows.Forms.Label LB_PhoneNumber;
        private System.Windows.Forms.MaskedTextBox MTB_Birthday;
        private System.Windows.Forms.TextBox TB_Gender;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.TextBox TB_Nationality;
        private System.Windows.Forms.TextBox TB_Position;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_CLose_Form;
        private System.Windows.Forms.Label LB_Money_Symbol;
        private System.Windows.Forms.Label LB_Gender;
        private System.Windows.Forms.Label LB_ID;
        private System.Windows.Forms.Label LB_Birthday;
        private System.Windows.Forms.Label LB_Nationality;
        private System.Windows.Forms.Label LB_Position;
        private System.Windows.Forms.Label LB_Salary;
        private System.Windows.Forms.Label LB_Name;
    }
}