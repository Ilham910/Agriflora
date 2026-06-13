namespace Agriflora.Views
{
    partial class FormLaporanFlorist
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
            lblInfoBulanIni = new Label();
            lblInfoMingguIni = new Label();
            lblBulanIni = new Label();
            lblMingguIni = new Label();
            lblInfoHariIni = new Label();
            lblHariIni = new Label();
            lblBulan = new Label();
            lblLaporan = new Label();
            lblPesanan = new Label();
            lblDashboard = new Label();
            SuspendLayout();
            // 
            // lblInfoBulanIni
            // 
            lblInfoBulanIni.AutoSize = true;
            lblInfoBulanIni.BackColor = SystemColors.ButtonHighlight;
            lblInfoBulanIni.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoBulanIni.Location = new Point(741, 224);
            lblInfoBulanIni.Name = "lblInfoBulanIni";
            lblInfoBulanIni.Size = new Size(192, 23);
            lblInfoBulanIni.TabIndex = 14;
            lblInfoBulanIni.Text = "naik 10% dari bulan lalu";
            // 
            // lblInfoMingguIni
            // 
            lblInfoMingguIni.BackColor = SystemColors.ButtonHighlight;
            lblInfoMingguIni.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoMingguIni.Location = new Point(484, 223);
            lblInfoMingguIni.Name = "lblInfoMingguIni";
            lblInfoMingguIni.Size = new Size(135, 23);
            lblInfoMingguIni.TabIndex = 13;
            lblInfoMingguIni.Text = "24 Transaksi";
            // 
            // lblBulanIni
            // 
            lblBulanIni.BackColor = SystemColors.ButtonHighlight;
            lblBulanIni.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBulanIni.Location = new Point(730, 173);
            lblBulanIni.Name = "lblBulanIni";
            lblBulanIni.Size = new Size(214, 43);
            lblBulanIni.TabIndex = 12;
            lblBulanIni.Text = "Rp 9.202.000";
            lblBulanIni.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMingguIni
            // 
            lblMingguIni.BackColor = SystemColors.ButtonHighlight;
            lblMingguIni.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMingguIni.Location = new Point(472, 173);
            lblMingguIni.Name = "lblMingguIni";
            lblMingguIni.Size = new Size(213, 43);
            lblMingguIni.TabIndex = 10;
            lblMingguIni.Text = "Rp 2.250.000";
            lblMingguIni.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblInfoHariIni
            // 
            lblInfoHariIni.AutoSize = true;
            lblInfoHariIni.BackColor = SystemColors.ButtonHighlight;
            lblInfoHariIni.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoHariIni.Location = new Point(228, 224);
            lblInfoHariIni.Name = "lblInfoHariIni";
            lblInfoHariIni.Size = new Size(92, 23);
            lblInfoHariIni.TabIndex = 9;
            lblInfoHariIni.Text = "5 Transaksi";
            // 
            // lblHariIni
            // 
            lblHariIni.BackColor = SystemColors.ButtonHighlight;
            lblHariIni.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHariIni.Location = new Point(222, 175);
            lblHariIni.Name = "lblHariIni";
            lblHariIni.Size = new Size(203, 41);
            lblHariIni.TabIndex = 8;
            lblHariIni.Text = "Rp 593.000";
            lblHariIni.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBulan
            // 
            lblBulan.AutoSize = true;
            lblBulan.BackColor = SystemColors.ButtonHighlight;
            lblBulan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBulan.Location = new Point(846, 96);
            lblBulan.Name = "lblBulan";
            lblBulan.Size = new Size(88, 23);
            lblBulan.TabIndex = 15;
            lblBulan.Text = "Juni 2026";
            // 
            // lblLaporan
            // 
            lblLaporan.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLaporan.Image = Properties.Resources.Screenshot_2026_06_12_1422502;
            lblLaporan.Location = new Point(5, 158);
            lblLaporan.Name = "lblLaporan";
            lblLaporan.Size = new Size(177, 40);
            lblLaporan.TabIndex = 19;
            lblLaporan.Click += lblLaporan_Click;
            // 
            // lblPesanan
            // 
            lblPesanan.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPesanan.Image = Properties.Resources.Screenshot_2026_06_12_142231;
            lblPesanan.Location = new Point(3, 246);
            lblPesanan.Name = "lblPesanan";
            lblPesanan.Size = new Size(163, 40);
            lblPesanan.TabIndex = 18;
            lblPesanan.Click += lblPesanan_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboard.Image = Properties.Resources.Screenshot_2026_06_12_1422231;
            lblDashboard.Location = new Point(4, 205);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(134, 41);
            lblDashboard.TabIndex = 17;
            lblDashboard.Click += lblDashboard_Click;
            // 
            // FormLaporanFlorist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Laporan__Florist_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 578);
            Controls.Add(lblLaporan);
            Controls.Add(lblPesanan);
            Controls.Add(lblDashboard);
            Controls.Add(lblBulan);
            Controls.Add(lblInfoBulanIni);
            Controls.Add(lblInfoMingguIni);
            Controls.Add(lblBulanIni);
            Controls.Add(lblMingguIni);
            Controls.Add(lblInfoHariIni);
            Controls.Add(lblHariIni);
            Name = "FormLaporanFlorist";
            Text = "FormLaporanFlorist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfoBulanIni;
        private Label lblInfoMingguIni;
        private Label lblBulanIni;
        private Label lblMingguIni;
        private Label lblInfoHariIni;
        private Label lblHariIni;
        private Label lblBulan;
        private Label lblLaporan;
        private Label lblPesanan;
        private Label lblDashboard;
    }
}