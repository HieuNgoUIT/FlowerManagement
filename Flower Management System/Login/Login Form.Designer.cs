namespace Flower_Management_System.Login
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.BT_Login = new System.Windows.Forms.Button();
            this.BT_Quit = new System.Windows.Forms.Button();
            this.LB_Title = new System.Windows.Forms.Label();
            this.LB_Username = new System.Windows.Forms.Label();
            this.LB_Password = new System.Windows.Forms.Label();
            this.LB_BT_Login = new System.Windows.Forms.Label();
            this.LB_BT_Quit = new System.Windows.Forms.Label();
            this.LB_Notice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Username
            // 
            this.TB_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Username.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Username.Location = new System.Drawing.Point(75, 173);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(357, 36);
            this.TB_Username.TabIndex = 0;
            // 
            // TB_Password
            // 
            this.TB_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(84, 309);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(339, 36);
            this.TB_Password.TabIndex = 1;
            // 
            // BT_Login
            // 
            this.BT_Login.AutoEllipsis = true;
            this.BT_Login.BackColor = System.Drawing.Color.White;
            this.BT_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Login.BackgroundImage")));
            this.BT_Login.Location = new System.Drawing.Point(107, 403);
            this.BT_Login.Name = "BT_Login";
            this.BT_Login.Size = new System.Drawing.Size(121, 49);
            this.BT_Login.TabIndex = 2;
            this.BT_Login.UseVisualStyleBackColor = false;
            this.BT_Login.Click += new System.EventHandler(this.BT_Login_Click);
            this.BT_Login.MouseEnter += new System.EventHandler(this.BT_Login_MouseEnter);
            this.BT_Login.MouseLeave += new System.EventHandler(this.BT_Login_MouseLeave);
            // 
            // BT_Quit
            // 
            this.BT_Quit.AutoEllipsis = true;
            this.BT_Quit.BackColor = System.Drawing.Color.White;
            this.BT_Quit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_Quit.BackgroundImage")));
            this.BT_Quit.Location = new System.Drawing.Point(275, 403);
            this.BT_Quit.Name = "BT_Quit";
            this.BT_Quit.Size = new System.Drawing.Size(121, 49);
            this.BT_Quit.TabIndex = 3;
            this.BT_Quit.UseVisualStyleBackColor = false;
            this.BT_Quit.Click += new System.EventHandler(this.BT_Quit_Click);
            this.BT_Quit.MouseEnter += new System.EventHandler(this.BT_Quit_MouseEnter);
            this.BT_Quit.MouseLeave += new System.EventHandler(this.BT_Quit_MouseLeave);
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.BackColor = System.Drawing.Color.White;
            this.LB_Title.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Title.Location = new System.Drawing.Point(111, 36);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(94, 41);
            this.LB_Title.TabIndex = 4;
            this.LB_Title.Text = "LOGIN";
            // 
            // LB_Username
            // 
            this.LB_Username.AutoSize = true;
            this.LB_Username.BackColor = System.Drawing.Color.White;
            this.LB_Username.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Username.Location = new System.Drawing.Point(34, 106);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(122, 32);
            this.LB_Username.TabIndex = 5;
            this.LB_Username.Text = "Username";
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.BackColor = System.Drawing.Color.White;
            this.LB_Password.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Password.Location = new System.Drawing.Point(34, 245);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(112, 32);
            this.LB_Password.TabIndex = 6;
            this.LB_Password.Text = "Password";
            // 
            // LB_BT_Login
            // 
            this.LB_BT_Login.AutoSize = true;
            this.LB_BT_Login.BackColor = System.Drawing.Color.White;
            this.LB_BT_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_BT_Login.Location = new System.Drawing.Point(130, 410);
            this.LB_BT_Login.Name = "LB_BT_Login";
            this.LB_BT_Login.Size = new System.Drawing.Size(75, 32);
            this.LB_BT_Login.TabIndex = 7;
            this.LB_BT_Login.Text = "Login";
            this.LB_BT_Login.Click += new System.EventHandler(this.LB_BT_Login_Click);
            this.LB_BT_Login.MouseEnter += new System.EventHandler(this.LB_BT_Login_MouseEnter);
            // 
            // LB_BT_Quit
            // 
            this.LB_BT_Quit.AutoSize = true;
            this.LB_BT_Quit.BackColor = System.Drawing.Color.White;
            this.LB_BT_Quit.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_BT_Quit.Location = new System.Drawing.Point(304, 410);
            this.LB_BT_Quit.Name = "LB_BT_Quit";
            this.LB_BT_Quit.Size = new System.Drawing.Size(62, 32);
            this.LB_BT_Quit.TabIndex = 8;
            this.LB_BT_Quit.Text = "Quit";
            this.LB_BT_Quit.Click += new System.EventHandler(this.LB_BT_Quit_Click);
            this.LB_BT_Quit.MouseEnter += new System.EventHandler(this.LB_BT_Quit_MouseEnter);
            // 
            // LB_Notice
            // 
            this.LB_Notice.AutoSize = true;
            this.LB_Notice.BackColor = System.Drawing.Color.White;
            this.LB_Notice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Notice.ForeColor = System.Drawing.Color.Maroon;
            this.LB_Notice.Location = new System.Drawing.Point(36, 85);
            this.LB_Notice.Name = "LB_Notice";
            this.LB_Notice.Size = new System.Drawing.Size(266, 21);
            this.LB_Notice.TabIndex = 50;
            this.LB_Notice.Text = "Error : Wrong username or password";
            this.LB_Notice.Visible = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(504, 500);
            this.Controls.Add(this.LB_Notice);
            this.Controls.Add(this.LB_BT_Quit);
            this.Controls.Add(this.LB_BT_Login);
            this.Controls.Add(this.LB_Password);
            this.Controls.Add(this.LB_Username);
            this.Controls.Add(this.LB_Title);
            this.Controls.Add(this.BT_Quit);
            this.Controls.Add(this.BT_Login);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Button BT_Login;
        private System.Windows.Forms.Button BT_Quit;
        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.Label LB_Username;
        private System.Windows.Forms.Label LB_Password;
        private System.Windows.Forms.Label LB_BT_Login;
        private System.Windows.Forms.Label LB_BT_Quit;
        private System.Windows.Forms.Label LB_Notice;
    }
}