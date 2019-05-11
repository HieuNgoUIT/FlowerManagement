namespace Flower_Management_System.Account_Management
{
    partial class Update_Account_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Account_Form));
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.LB_Notice = new System.Windows.Forms.Label();
            this.LB_Set = new System.Windows.Forms.Label();
            this.BT_Set = new System.Windows.Forms.Button();
            this.BT_CLose_Form = new System.Windows.Forms.Button();
            this.LB_ID = new System.Windows.Forms.Label();
            this.LB_Password = new System.Windows.Forms.Label();
            this.LB_Username = new System.Windows.Forms.Label();
            this.LB_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Username
            // 
            this.TB_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Username.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Username.Location = new System.Drawing.Point(82, 200);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(293, 36);
            this.TB_Username.TabIndex = 63;
            // 
            // TB_Password
            // 
            this.TB_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(82, 335);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(293, 36);
            this.TB_Password.TabIndex = 62;
            // 
            // LB_Notice
            // 
            this.LB_Notice.AutoSize = true;
            this.LB_Notice.BackColor = System.Drawing.Color.White;
            this.LB_Notice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Notice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LB_Notice.Location = new System.Drawing.Point(148, 152);
            this.LB_Notice.Name = "LB_Notice";
            this.LB_Notice.Size = new System.Drawing.Size(227, 21);
            this.LB_Notice.TabIndex = 61;
            this.LB_Notice.Text = "Error! Username has been used";
            this.LB_Notice.Visible = false;
            // 
            // LB_Set
            // 
            this.LB_Set.AutoSize = true;
            this.LB_Set.BackColor = System.Drawing.Color.Transparent;
            this.LB_Set.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Set.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LB_Set.Location = new System.Drawing.Point(193, 413);
            this.LB_Set.Name = "LB_Set";
            this.LB_Set.Size = new System.Drawing.Size(51, 30);
            this.LB_Set.TabIndex = 60;
            this.LB_Set.Text = "Set!";
            this.LB_Set.Click += new System.EventHandler(this.LB_Set_Click);
            this.LB_Set.MouseEnter += new System.EventHandler(this.LB_Set_MouseEnter);
            // 
            // BT_Set
            // 
            this.BT_Set.BackColor = System.Drawing.Color.White;
            this.BT_Set.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Set.BackgroundImage")));
            this.BT_Set.Location = new System.Drawing.Point(171, 405);
            this.BT_Set.Name = "BT_Set";
            this.BT_Set.Size = new System.Drawing.Size(93, 49);
            this.BT_Set.TabIndex = 59;
            this.BT_Set.UseVisualStyleBackColor = false;
            this.BT_Set.MouseEnter += new System.EventHandler(this.BT_Set_MouseEnter);
            this.BT_Set.MouseLeave += new System.EventHandler(this.BT_Set_MouseLeave);
            // 
            // BT_CLose_Form
            // 
            this.BT_CLose_Form.BackColor = System.Drawing.Color.White;
            this.BT_CLose_Form.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_CLose_Form.BackgroundImage")));
            this.BT_CLose_Form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_CLose_Form.Location = new System.Drawing.Point(391, 20);
            this.BT_CLose_Form.Name = "BT_CLose_Form";
            this.BT_CLose_Form.Size = new System.Drawing.Size(32, 32);
            this.BT_CLose_Form.TabIndex = 58;
            this.BT_CLose_Form.UseVisualStyleBackColor = false;
            this.BT_CLose_Form.Click += new System.EventHandler(this.BT_CLose_Form_Click);
            this.BT_CLose_Form.MouseEnter += new System.EventHandler(this.BT_CLose_Form_MouseEnter);
            this.BT_CLose_Form.MouseLeave += new System.EventHandler(this.BT_CLose_Form_MouseLeave);
            // 
            // LB_ID
            // 
            this.LB_ID.AutoSize = true;
            this.LB_ID.BackColor = System.Drawing.Color.White;
            this.LB_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ID.Location = new System.Drawing.Point(24, 100);
            this.LB_ID.Name = "LB_ID";
            this.LB_ID.Size = new System.Drawing.Size(28, 30);
            this.LB_ID.TabIndex = 57;
            this.LB_ID.Text = "...";
            this.LB_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.BackColor = System.Drawing.Color.White;
            this.LB_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LB_Password.Location = new System.Drawing.Point(39, 274);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(103, 30);
            this.LB_Password.TabIndex = 56;
            this.LB_Password.Text = "Password";
            // 
            // LB_Username
            // 
            this.LB_Username.AutoSize = true;
            this.LB_Username.BackColor = System.Drawing.Color.White;
            this.LB_Username.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LB_Username.Location = new System.Drawing.Point(33, 145);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(109, 30);
            this.LB_Username.TabIndex = 55;
            this.LB_Username.Text = "Username";
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.BackColor = System.Drawing.Color.White;
            this.LB_Title.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LB_Title.Location = new System.Drawing.Point(88, 34);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(201, 34);
            this.LB_Title.TabIndex = 54;
            this.LB_Title.Text = "UPDATE ACCOUNT";
            // 
            // Update_Account_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(446, 474);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.LB_Notice);
            this.Controls.Add(this.LB_Set);
            this.Controls.Add(this.BT_Set);
            this.Controls.Add(this.BT_CLose_Form);
            this.Controls.Add(this.LB_ID);
            this.Controls.Add(this.LB_Password);
            this.Controls.Add(this.LB_Username);
            this.Controls.Add(this.LB_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update_Account_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Account_Form";
            this.Load += new System.EventHandler(this.Update_Account_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label LB_Notice;
        private System.Windows.Forms.Label LB_Set;
        private System.Windows.Forms.Button BT_Set;
        private System.Windows.Forms.Button BT_CLose_Form;
        private System.Windows.Forms.Label LB_ID;
        private System.Windows.Forms.Label LB_Password;
        private System.Windows.Forms.Label LB_Username;
        private System.Windows.Forms.Label LB_Title;
    }
}