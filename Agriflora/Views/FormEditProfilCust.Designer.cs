namespace Agriflora.Views
{
    partial class FormEditProfilCust
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
            tbNoTelp = new TextBox();
            tbAlamat = new TextBox();
            tbPassLama = new TextBox();
            tbPassBaru = new TextBox();
            tbKonfirmPass = new TextBox();
            btnSave = new Button();
            btnGantiPass = new Button();
            btKembali = new Button();
            pictureBoxProfil = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            GantiProfil = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfil).BeginInit();
            SuspendLayout();
            // 
            // tbNama
            // 
            tbNama.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNama.Location = new Point(79, 295);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(355, 43);
            tbNama.TabIndex = 0;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(79, 372);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(355, 43);
            tbEmail.TabIndex = 1;
            // 
            // tbNoTelp
            // 
            tbNoTelp.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNoTelp.Location = new Point(513, 295);
            tbNoTelp.Name = "tbNoTelp";
            tbNoTelp.Size = new Size(355, 43);
            tbNoTelp.TabIndex = 2;
            // 
            // tbAlamat
            // 
            tbAlamat.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAlamat.Location = new Point(513, 372);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(355, 43);
            tbAlamat.TabIndex = 3;
            // 
            // tbPassLama
            // 
            tbPassLama.Enabled = false;
            tbPassLama.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassLama.Location = new Point(99, 495);
            tbPassLama.Name = "tbPassLama";
            tbPassLama.Size = new Size(355, 30);
            tbPassLama.TabIndex = 4;
            // 
            // tbPassBaru
            // 
            tbPassBaru.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassBaru.Location = new Point(99, 547);
            tbPassBaru.Name = "tbPassBaru";
            tbPassBaru.Size = new Size(355, 30);
            tbPassBaru.TabIndex = 5;
            // 
            // tbKonfirmPass
            // 
            tbKonfirmPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbKonfirmPass.Location = new Point(488, 547);
            tbKonfirmPass.Name = "tbKonfirmPass";
            tbKonfirmPass.Size = new Size(355, 30);
            tbKonfirmPass.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(810, 235);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 43);
            btnSave.TabIndex = 7;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnGantiPass
            // 
            btnGantiPass.BackColor = Color.Green;
            btnGantiPass.ForeColor = SystemColors.ButtonHighlight;
            btnGantiPass.Location = new Point(761, 448);
            btnGantiPass.Name = "btnGantiPass";
            btnGantiPass.Size = new Size(147, 43);
            btnGantiPass.TabIndex = 8;
            btnGantiPass.Text = "GANTI PASSWORD";
            btnGantiPass.UseVisualStyleBackColor = false;
            btnGantiPass.Click += btnGantiPass_Click;
            // 
            // btKembali
            // 
            btKembali.BackgroundImage = Properties.Resources.Screenshot_2026_06_07_222104;
            btKembali.BackgroundImageLayout = ImageLayout.Zoom;
            btKembali.Location = new Point(12, 7);
            btKembali.Name = "btKembali";
            btKembali.Size = new Size(128, 47);
            btKembali.TabIndex = 9;
            btKembali.UseVisualStyleBackColor = true;
            btKembali.Click += btKembali_Click;
            // 
            // pictureBoxProfil
            // 
            pictureBoxProfil.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxProfil.Location = new Point(446, 72);
            pictureBoxProfil.Name = "pictureBoxProfil";
            pictureBoxProfil.Size = new Size(125, 119);
            pictureBoxProfil.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfil.TabIndex = 10;
            pictureBoxProfil.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // GantiProfil
            // 
            GantiProfil.BackColor = Color.LavenderBlush;
            GantiProfil.Image = Properties.Resources.Screenshot_2026_06_07_222344;
            GantiProfil.Location = new Point(449, 195);
            GantiProfil.Name = "GantiProfil";
            GantiProfil.Size = new Size(120, 16);
            GantiProfil.TabIndex = 12;
            GantiProfil.Click += GantiProfil_Click;
            // 
            // FormEditProfilCust
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Edit_Profil_Cust;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(982, 613);
            Controls.Add(GantiProfil);
            Controls.Add(pictureBoxProfil);
            Controls.Add(btKembali);
            Controls.Add(btnGantiPass);
            Controls.Add(btnSave);
            Controls.Add(tbKonfirmPass);
            Controls.Add(tbPassBaru);
            Controls.Add(tbPassLama);
            Controls.Add(tbAlamat);
            Controls.Add(tbNoTelp);
            Controls.Add(tbEmail);
            Controls.Add(tbNama);
            Name = "FormEditProfilCust";
            Text = "FormEditProfilCust";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNama;
        private TextBox tbEmail;
        private TextBox tbNoTelp;
        private TextBox tbAlamat;
        private TextBox tbPassLama;
        private TextBox tbPassBaru;
        private TextBox tbKonfirmPass;
        private Button btnSave;
        private Button btnGantiPass;
        private Button btKembali;
        private PictureBox pictureBoxProfil;
        private OpenFileDialog openFileDialog1;
        private Label GantiProfil;
    }
}