namespace Agriflora.Views
{
    partial class RiwayatPesananCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStatus = new Label();
            pictureBoxGambar = new PictureBox();
            lblNama = new Label();
            lblHarga = new Label();
            lblTotal = new Label();
            lblId = new Label();
            lblTanggal = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.BackColor = SystemColors.InactiveCaption;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.MidnightBlue;
            lblStatus.Location = new Point(835, 16);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(119, 31);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Diproses";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxGambar
            // 
            pictureBoxGambar.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxGambar.Location = new Point(4, 53);
            pictureBoxGambar.Name = "pictureBoxGambar";
            pictureBoxGambar.Size = new Size(77, 78);
            pictureBoxGambar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGambar.TabIndex = 2;
            pictureBoxGambar.TabStop = false;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.BackColor = SystemColors.ButtonHighlight;
            lblNama.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(85, 68);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(139, 25);
            lblNama.TabIndex = 3;
            lblNama.Text = "Anggrek Bulan";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.BackColor = SystemColors.ButtonHighlight;
            lblHarga.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHarga.Location = new Point(86, 98);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(100, 20);
            lblHarga.TabIndex = 9;
            lblHarga.Text = "Rp. 80.000 x 1";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = SystemColors.ButtonHighlight;
            lblTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(835, 169);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(110, 25);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Rp. 177.000";
            lblTotal.Click += lblTotal_Click;
            // 
            // lblId
            // 
            lblId.BackColor = SystemColors.ButtonHighlight;
            lblId.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.Green;
            lblId.Location = new Point(11, 2);
            lblId.Name = "lblId";
            lblId.Size = new Size(163, 25);
            lblId.TabIndex = 11;
            lblId.Text = "ID : 15";
            // 
            // lblTanggal
            // 
            lblTanggal.BackColor = SystemColors.ButtonHighlight;
            lblTanggal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTanggal.Location = new Point(9, 26);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(124, 22);
            lblTanggal.TabIndex = 12;
            lblTanggal.Text = "24 Juni 2026";
            // 
            // RiwayatPesananCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_06_11_204724;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(lblTanggal);
            Controls.Add(lblId);
            Controls.Add(lblTotal);
            Controls.Add(lblHarga);
            Controls.Add(lblNama);
            Controls.Add(pictureBoxGambar);
            Controls.Add(lblStatus);
            DoubleBuffered = true;
            Name = "RiwayatPesananCard";
            Size = new Size(957, 198);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private PictureBox pictureBoxGambar;
        private Label lblNama;
        private Label lblHarga;
        private Label lblTotal;
        private Label lblId;
        private Label lblTanggal;
    }
}
