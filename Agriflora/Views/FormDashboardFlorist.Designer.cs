using Agriflora.Helpers;

namespace Agriflora.Views
{
    partial class FormDashboardFlorist
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
            flowHampirHabis = new FlowLayoutPanel();
            lblProdukAktif = new Label();
            lblInfoProduk = new Label();
            lblMasuk = new Label();
            lblTotalStok = new Label();
            lblPemasukan = new Label();
            lblInfoMasuk = new Label();
            lblInfoPemasukan = new Label();
            lblKelProduk = new Label();
            lblLaporan = new Label();
            lblPesanan = new Label();
            lblDashboard = new Label();
            flowPesananTerbaru = new SmoothFlowPanel();
            lblLihatPesanan = new Label();
            btnLogout = new Button();
            lblNoTelp = new Label();
            lblEmailUser = new Label();
            lblNamaUser = new Label();
            SuspendLayout();
            // 
            // flowHampirHabis
            // 
            flowHampirHabis.BackColor = SystemColors.ButtonHighlight;
            flowHampirHabis.Location = new Point(223, 483);
            flowHampirHabis.Name = "flowHampirHabis";
            flowHampirHabis.Size = new Size(727, 80);
            flowHampirHabis.TabIndex = 0;
            // 
            // lblProdukAktif
            // 
            lblProdukAktif.BackColor = SystemColors.ButtonHighlight;
            lblProdukAktif.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProdukAktif.Location = new Point(208, 162);
            lblProdukAktif.Name = "lblProdukAktif";
            lblProdukAktif.Size = new Size(62, 41);
            lblProdukAktif.TabIndex = 1;
            lblProdukAktif.Text = "40";
            lblProdukAktif.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfoProduk
            // 
            lblInfoProduk.AutoSize = true;
            lblInfoProduk.BackColor = SystemColors.ButtonHighlight;
            lblInfoProduk.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoProduk.Location = new Point(218, 206);
            lblInfoProduk.Name = "lblInfoProduk";
            lblInfoProduk.Size = new Size(123, 17);
            lblInfoProduk.TabIndex = 2;
            lblInfoProduk.Text = "3 hampir habis stok";
            // 
            // lblMasuk
            // 
            lblMasuk.BackColor = SystemColors.ButtonHighlight;
            lblMasuk.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMasuk.Location = new Point(415, 163);
            lblMasuk.Name = "lblMasuk";
            lblMasuk.Size = new Size(62, 43);
            lblMasuk.TabIndex = 3;
            lblMasuk.Text = "40";
            // 
            // lblTotalStok
            // 
            lblTotalStok.BackColor = SystemColors.ButtonHighlight;
            lblTotalStok.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStok.Location = new Point(604, 162);
            lblTotalStok.Name = "lblTotalStok";
            lblTotalStok.Size = new Size(62, 43);
            lblTotalStok.TabIndex = 4;
            lblTotalStok.Text = "40";
            // 
            // lblPemasukan
            // 
            lblPemasukan.BackColor = SystemColors.ButtonHighlight;
            lblPemasukan.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPemasukan.Location = new Point(796, 164);
            lblPemasukan.Name = "lblPemasukan";
            lblPemasukan.Size = new Size(171, 43);
            lblPemasukan.TabIndex = 5;
            lblPemasukan.Text = "Rp. 6,42 Jt";
            lblPemasukan.TextAlign = ContentAlignment.MiddleLeft;
            lblPemasukan.Click += lblPemasukan_Click;
            // 
            // lblInfoMasuk
            // 
            lblInfoMasuk.AutoSize = true;
            lblInfoMasuk.BackColor = SystemColors.ButtonHighlight;
            lblInfoMasuk.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoMasuk.Location = new Point(414, 205);
            lblInfoMasuk.Name = "lblInfoMasuk";
            lblInfoMasuk.Size = new Size(152, 17);
            lblInfoMasuk.TabIndex = 6;
            lblInfoMasuk.Text = "3 pesanan masuk hari ini";
            // 
            // lblInfoPemasukan
            // 
            lblInfoPemasukan.AutoSize = true;
            lblInfoPemasukan.BackColor = SystemColors.ButtonHighlight;
            lblInfoPemasukan.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoPemasukan.Location = new Point(803, 210);
            lblInfoPemasukan.Name = "lblInfoPemasukan";
            lblInfoPemasukan.Size = new Size(147, 17);
            lblInfoPemasukan.TabIndex = 7;
            lblInfoPemasukan.Text = "naik 10% dari bulan lalu";
            // 
            // lblKelProduk
            // 
            lblKelProduk.Image = Properties.Resources.Screenshot_2026_06_13_213521;
            lblKelProduk.Location = new Point(821, 411);
            lblKelProduk.Name = "lblKelProduk";
            lblKelProduk.Size = new Size(135, 30);
            lblKelProduk.TabIndex = 8;
            lblKelProduk.Click += lblKelProduk_Click;
            // 
            // lblLaporan
            // 
            lblLaporan.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLaporan.Image = Properties.Resources.Screenshot_2026_06_12_142239;
            lblLaporan.Location = new Point(-2, 286);
            lblLaporan.Name = "lblLaporan";
            lblLaporan.Size = new Size(158, 40);
            lblLaporan.TabIndex = 16;
            lblLaporan.Click += lblLaporan_Click;
            // 
            // lblPesanan
            // 
            lblPesanan.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPesanan.Image = Properties.Resources.Screenshot_2026_06_12_142231;
            lblPesanan.Location = new Point(-1, 246);
            lblPesanan.Name = "lblPesanan";
            lblPesanan.Size = new Size(163, 40);
            lblPesanan.TabIndex = 15;
            lblPesanan.Click += lblPesanan_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboard.Image = Properties.Resources.Screenshot_2026_06_12_1422231;
            lblDashboard.Location = new Point(3, 205);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(134, 41);
            lblDashboard.TabIndex = 14;
            lblDashboard.Click += lblDashboard_Click;
            // 
            // flowPesananTerbaru
            // 
            flowPesananTerbaru.AutoScroll = true;
            flowPesananTerbaru.BackColor = SystemColors.ButtonHighlight;
            flowPesananTerbaru.Location = new Point(650, 279);
            flowPesananTerbaru.Name = "flowPesananTerbaru";
            flowPesananTerbaru.Size = new Size(267, 83);
            flowPesananTerbaru.TabIndex = 17;
            // 
            // lblLihatPesanan
            // 
            lblLihatPesanan.BackColor = SystemColors.ButtonHighlight;
            lblLihatPesanan.Image = Properties.Resources.Screenshot_2026_06_16_135514;
            lblLihatPesanan.Location = new Point(657, 365);
            lblLihatPesanan.Name = "lblLihatPesanan";
            lblLihatPesanan.Size = new Size(250, 28);
            lblLihatPesanan.TabIndex = 18;
            lblLihatPesanan.Click += lblLihatPesanan_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LemonChiffon;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(36, 545);
            btnLogout.Name = "btnLogout";
            btnLogout.RightToLeft = RightToLeft.No;
            btnLogout.Size = new Size(78, 29);
            btnLogout.TabIndex = 19;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblNoTelp
            // 
            lblNoTelp.BackColor = Color.PaleVioletRed;
            lblNoTelp.Font = new Font("Segoe UI", 6F);
            lblNoTelp.ForeColor = SystemColors.ButtonHighlight;
            lblNoTelp.Location = new Point(70, 123);
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
            lblEmailUser.Location = new Point(70, 111);
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
            lblNamaUser.Location = new Point(70, 94);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(110, 17);
            lblNamaUser.TabIndex = 23;
            lblNamaUser.Text = "Rabvinna Salsabila";
            // 
            // FormDashboardFlorist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Homepage_Florist;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 578);
            Controls.Add(lblNoTelp);
            Controls.Add(lblEmailUser);
            Controls.Add(lblNamaUser);
            Controls.Add(btnLogout);
            Controls.Add(lblLihatPesanan);
            Controls.Add(flowPesananTerbaru);
            Controls.Add(lblLaporan);
            Controls.Add(lblPesanan);
            Controls.Add(lblDashboard);
            Controls.Add(lblKelProduk);
            Controls.Add(lblInfoPemasukan);
            Controls.Add(lblInfoMasuk);
            Controls.Add(lblPemasukan);
            Controls.Add(lblTotalStok);
            Controls.Add(lblMasuk);
            Controls.Add(lblInfoProduk);
            Controls.Add(lblProdukAktif);
            Controls.Add(flowHampirHabis);
            Name = "FormDashboardFlorist";
            Text = "FormDashboardFlorist";
            Load += FormDashboardFlorist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowHampirHabis;
        private Label lblProdukAktif;
        private Label lblInfoProduk;
        private Label lblMasuk;
        private Label lblTotalStok;
        private Label lblPemasukan;
        private Label lblInfoMasuk;
        private Label lblInfoPemasukan;
        private Label lblKelProduk;
        private Label lblLaporan;
        private Label lblPesanan;
        private Label lblDashboard;
        private SmoothFlowPanel flowPesananTerbaru;
        private Label lblLihatPesanan;
        private Button btnLogout;
        private Label lblNoTelp;
        private Label lblEmailUser;
        private Label lblNamaUser;
    }
}