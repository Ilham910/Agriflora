namespace Agriflora.Views
{
    partial class FormPesananFlorist
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
            flowLayoutPanel = new FlowLayoutPanel();
            btnSemua = new Button();
            btnMenunggu = new Button();
            btnDiproses = new Button();
            btnSiap = new Button();
            btnSelesai = new Button();
            lblLaporan = new Label();
            lblPesanan = new Label();
            lblDashboard = new Label();
            btnLogout = new Button();
            lblNoTelp = new Label();
            lblEmailUser = new Label();
            lblNamaUser = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.BackColor = SystemColors.ButtonHighlight;
            flowLayoutPanel.Location = new Point(206, 245);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(751, 321);
            flowLayoutPanel.TabIndex = 0;
            // 
            // btnSemua
            // 
            btnSemua.BackColor = SystemColors.Control;
            btnSemua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSemua.Location = new Point(205, 151);
            btnSemua.Name = "btnSemua";
            btnSemua.Size = new Size(111, 32);
            btnSemua.TabIndex = 10;
            btnSemua.Text = "Semua";
            btnSemua.UseVisualStyleBackColor = false;
            btnSemua.Click += btnSemua_Click;
            // 
            // btnMenunggu
            // 
            btnMenunggu.BackColor = SystemColors.Control;
            btnMenunggu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenunggu.Location = new Point(342, 151);
            btnMenunggu.Name = "btnMenunggu";
            btnMenunggu.Size = new Size(111, 32);
            btnMenunggu.TabIndex = 11;
            btnMenunggu.Text = "Menunggu";
            btnMenunggu.UseVisualStyleBackColor = false;
            btnMenunggu.Click += btnMenunggu_Click;
            // 
            // btnDiproses
            // 
            btnDiproses.BackColor = SystemColors.Control;
            btnDiproses.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiproses.Location = new Point(480, 151);
            btnDiproses.Name = "btnDiproses";
            btnDiproses.Size = new Size(111, 32);
            btnDiproses.TabIndex = 12;
            btnDiproses.Text = "Diproses";
            btnDiproses.UseVisualStyleBackColor = false;
            btnDiproses.Click += btnDiproses_Click;
            // 
            // btnSiap
            // 
            btnSiap.BackColor = SystemColors.Control;
            btnSiap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiap.Location = new Point(618, 151);
            btnSiap.Name = "btnSiap";
            btnSiap.Size = new Size(111, 32);
            btnSiap.TabIndex = 13;
            btnSiap.Text = "Siap Diambil";
            btnSiap.UseVisualStyleBackColor = false;
            btnSiap.Click += btnSiap_Click;
            // 
            // btnSelesai
            // 
            btnSelesai.BackColor = SystemColors.Control;
            btnSelesai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelesai.Location = new Point(751, 151);
            btnSelesai.Name = "btnSelesai";
            btnSelesai.Size = new Size(118, 32);
            btnSelesai.TabIndex = 14;
            btnSelesai.Text = "Selesai";
            btnSelesai.UseVisualStyleBackColor = false;
            btnSelesai.Click += btnSelesai_Click;
            // 
            // lblLaporan
            // 
            lblLaporan.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLaporan.Image = Properties.Resources.Screenshot_2026_06_12_142239;
            lblLaporan.Location = new Point(2, 284);
            lblLaporan.Name = "lblLaporan";
            lblLaporan.Size = new Size(158, 40);
            lblLaporan.TabIndex = 19;
            lblLaporan.Click += lblLaporan_Click;
            // 
            // lblPesanan
            // 
            lblPesanan.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPesanan.Image = Properties.Resources.Screenshot_2026_06_12_1422501;
            lblPesanan.Location = new Point(4, 156);
            lblPesanan.Name = "lblPesanan";
            lblPesanan.Size = new Size(175, 40);
            lblPesanan.TabIndex = 18;
            lblPesanan.Click += lblPesanan_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboard.Image = Properties.Resources.Screenshot_2026_06_12_1422231;
            lblDashboard.Location = new Point(3, 201);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(134, 41);
            lblDashboard.TabIndex = 17;
            lblDashboard.Click += lblDashboard_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LemonChiffon;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(33, 545);
            btnLogout.Name = "btnLogout";
            btnLogout.RightToLeft = RightToLeft.No;
            btnLogout.Size = new Size(78, 29);
            btnLogout.TabIndex = 20;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblNoTelp
            // 
            lblNoTelp.BackColor = Color.PaleVioletRed;
            lblNoTelp.Font = new Font("Segoe UI", 6F);
            lblNoTelp.ForeColor = SystemColors.ButtonHighlight;
            lblNoTelp.Location = new Point(71, 123);
            lblNoTelp.Name = "lblNoTelp";
            lblNoTelp.Size = new Size(110, 12);
            lblNoTelp.TabIndex = 25;
            lblNoTelp.Text = "628123456789";
            // 
            // lblEmailUser
            // 
            lblEmailUser.BackColor = Color.PaleVioletRed;
            lblEmailUser.Font = new Font("Segoe UI", 6F);
            lblEmailUser.ForeColor = SystemColors.ButtonHighlight;
            lblEmailUser.Location = new Point(71, 111);
            lblEmailUser.Name = "lblEmailUser";
            lblEmailUser.Size = new Size(110, 12);
            lblEmailUser.TabIndex = 24;
            lblEmailUser.Text = "rabvinna@gmail.com";
            // 
            // lblNamaUser
            // 
            lblNamaUser.BackColor = Color.PaleVioletRed;
            lblNamaUser.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaUser.ForeColor = SystemColors.ButtonHighlight;
            lblNamaUser.Location = new Point(71, 94);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(110, 17);
            lblNamaUser.TabIndex = 23;
            lblNamaUser.Text = "Rabvinna Salsabila";
            // 
            // FormPesananFlorist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Pesanan__Florist_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 578);
            Controls.Add(lblNoTelp);
            Controls.Add(lblEmailUser);
            Controls.Add(lblNamaUser);
            Controls.Add(btnLogout);
            Controls.Add(lblLaporan);
            Controls.Add(lblPesanan);
            Controls.Add(lblDashboard);
            Controls.Add(btnSelesai);
            Controls.Add(btnSiap);
            Controls.Add(btnDiproses);
            Controls.Add(btnMenunggu);
            Controls.Add(btnSemua);
            Controls.Add(flowLayoutPanel);
            Name = "FormPesananFlorist";
            Text = "FormPesananFlorist";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private Button btnSemua;
        private Button btnMenunggu;
        private Button btnDiproses;
        private Button btnSiap;
        private Button btnSelesai;
        private Label lblLaporan;
        private Label lblPesanan;
        private Label lblDashboard;
        private Button btnLogout;
        private Label lblNoTelp;
        private Label lblEmailUser;
        private Label lblNamaUser;
    }
}