namespace Agriflora.Views
{
    partial class ItemCheckoutCard
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
            pictureBoxGambar = new PictureBox();
            lblHarga = new Label();
            lblNama = new Label();
            btnTambah = new Button();
            btnKurang = new Button();
            lblKuantitas = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxGambar
            // 
            pictureBoxGambar.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxGambar.Location = new Point(11, 12);
            pictureBoxGambar.Name = "pictureBoxGambar";
            pictureBoxGambar.Size = new Size(64, 64);
            pictureBoxGambar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGambar.TabIndex = 10;
            pictureBoxGambar.TabStop = false;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.BackColor = SystemColors.ButtonHighlight;
            lblHarga.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHarga.Location = new Point(81, 49);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(69, 17);
            lblHarga.TabIndex = 9;
            lblHarga.Text = "Rp. 80.000";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.BackColor = SystemColors.ButtonHighlight;
            lblNama.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(80, 23);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(113, 20);
            lblNama.TabIndex = 8;
            lblNama.Text = "Anggrek Bulan";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = SystemColors.ButtonHighlight;
            btnTambah.Location = new Point(744, 34);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(30, 30);
            btnTambah.TabIndex = 13;
            btnTambah.Text = "+";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnKurang
            // 
            btnKurang.BackColor = SystemColors.ButtonHighlight;
            btnKurang.Location = new Point(687, 34);
            btnKurang.Name = "btnKurang";
            btnKurang.Size = new Size(30, 30);
            btnKurang.TabIndex = 12;
            btnKurang.Text = "-";
            btnKurang.UseVisualStyleBackColor = false;
            btnKurang.Click += btnKurang_Click;
            // 
            // lblKuantitas
            // 
            lblKuantitas.AutoSize = true;
            lblKuantitas.BackColor = SystemColors.ButtonHighlight;
            lblKuantitas.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKuantitas.Location = new Point(720, 36);
            lblKuantitas.Name = "lblKuantitas";
            lblKuantitas.Size = new Size(22, 25);
            lblKuantitas.TabIndex = 11;
            lblKuantitas.Text = "1";
            // 
            // ItemCheckoutCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_06_07_123758;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(btnTambah);
            Controls.Add(btnKurang);
            Controls.Add(lblKuantitas);
            Controls.Add(pictureBoxGambar);
            Controls.Add(lblHarga);
            Controls.Add(lblNama);
            DoubleBuffered = true;
            Name = "ItemCheckoutCard";
            Size = new Size(833, 81);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxGambar;
        private Label lblHarga;
        private Label lblNama;
        private Button btnTambah;
        private Button btnKurang;
        private Label lblKuantitas;
    }
}
