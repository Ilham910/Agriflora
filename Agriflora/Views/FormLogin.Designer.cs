namespace Agriflora.Views
{
    partial class FormLogin
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
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            btLogin = new Button();
            lblDaftar = new Label();
            SuspendLayout();
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(323, 244);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(344, 41);
            tbEmail.TabIndex = 3;
            tbEmail.TextChanged += tbEmail_TextChanged;
            tbEmail.KeyDown += tbEmail_KeyDown;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(323, 318);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(344, 41);
            tbPassword.TabIndex = 4;
            tbPassword.KeyDown += tbPassword_KeyDown;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.DarkGreen;
            btLogin.ForeColor = SystemColors.ButtonHighlight;
            btLogin.Location = new Point(315, 430);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(352, 65);
            btLogin.TabIndex = 5;
            btLogin.Text = "LOGIN";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // lblDaftar
            // 
            lblDaftar.AutoSize = true;
            lblDaftar.BackColor = SystemColors.ButtonHighlight;
            lblDaftar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblDaftar.ForeColor = Color.DarkGreen;
            lblDaftar.Location = new Point(541, 498);
            lblDaftar.Name = "lblDaftar";
            lblDaftar.Size = new Size(54, 20);
            lblDaftar.TabIndex = 6;
            lblDaftar.Text = "Daftar";
            lblDaftar.Click += lblDaftar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 578);
            Controls.Add(btLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(lblDaftar);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbEmail;
        private TextBox tbPassword;
        private Button btLogin;
        private Label lblDaftar;
    }
}