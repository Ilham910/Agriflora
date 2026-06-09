namespace Agriflora.Views
{
    partial class FormRegister
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
            tbNama = new TextBox();
            tbEmail = new TextBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            tbAlamat = new TextBox();
            tbNoTelepon = new TextBox();
            cbRole = new ComboBox();
            btRegister = new Button();
            label10 = new Label();
            SuspendLayout();
            // 
            // tbNama
            // 
            tbNama.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNama.Location = new Point(320, 114);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(339, 30);
            tbNama.TabIndex = 8;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 10.2F);
            tbEmail.Location = new Point(320, 165);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(339, 30);
            tbEmail.TabIndex = 9;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 10.2F);
            tbUsername.Location = new Point(320, 216);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(340, 30);
            tbUsername.TabIndex = 10;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 10.2F);
            tbPassword.Location = new Point(320, 266);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(340, 30);
            tbPassword.TabIndex = 11;
            // 
            // tbAlamat
            // 
            tbAlamat.Font = new Font("Segoe UI", 10.2F);
            tbAlamat.Location = new Point(320, 317);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(339, 30);
            tbAlamat.TabIndex = 12;
            // 
            // tbNoTelepon
            // 
            tbNoTelepon.Font = new Font("Segoe UI", 10.2F);
            tbNoTelepon.Location = new Point(320, 368);
            tbNoTelepon.Name = "tbNoTelepon";
            tbNoTelepon.Size = new Size(340, 30);
            tbNoTelepon.TabIndex = 13;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Florist", "Customer" });
            cbRole.Location = new Point(320, 419);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(340, 28);
            cbRole.TabIndex = 14;
            // 
            // btRegister
            // 
            btRegister.BackColor = Color.DarkGreen;
            btRegister.ForeColor = SystemColors.ButtonHighlight;
            btRegister.Location = new Point(311, 454);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(361, 53);
            btRegister.TabIndex = 15;
            btRegister.Text = "Register";
            btRegister.UseVisualStyleBackColor = false;
            btRegister.Click += btRegister_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonHighlight;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(512, 510);
            label10.Name = "label10";
            label10.Size = new Size(101, 20);
            label10.TabIndex = 17;
            label10.Text = "Masuk di Sini";
            label10.Click += label10_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Register;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 578);
            Controls.Add(label10);
            Controls.Add(btRegister);
            Controls.Add(cbRole);
            Controls.Add(tbNoTelepon);
            Controls.Add(tbAlamat);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(tbEmail);
            Controls.Add(tbNama);
            Name = "FormRegister";
            Text = "FormRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbNama;
        private TextBox tbEmail;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private TextBox tbAlamat;
        private TextBox tbNoTelepon;
        private ComboBox cbRole;
        private Button btRegister;
        private Label label10;
    }
}