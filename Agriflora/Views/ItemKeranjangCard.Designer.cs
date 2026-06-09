namespace Agriflora.Views
{
    partial class ItemKeranjangCard
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
            components = new System.ComponentModel.Container();
            lblSubtotal = new Label();
            lblNama = new Label();
            lblHarga = new Label();
            lblKuantitas = new Label();
            pictureBoxGambar = new PictureBox();
            btnKurang = new Button();
            btnTambah = new Button();
            btnHapus = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).BeginInit();
            SuspendLayout();
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.BackColor = SystemColors.ButtonHighlight;
            lblSubtotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(742, 38);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(85, 20);
            lblSubtotal.TabIndex = 3;
            lblSubtotal.Text = "Rp. 65.000";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.BackColor = SystemColors.ButtonHighlight;
            lblNama.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(151, 14);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(94, 20);
            lblNama.TabIndex = 4;
            lblNama.Text = "Bibit Mawar";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.BackColor = SystemColors.ButtonHighlight;
            lblHarga.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHarga.Location = new Point(153, 39);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(69, 17);
            lblHarga.TabIndex = 5;
            lblHarga.Text = "Rp. 65.000";
            // 
            // lblKuantitas
            // 
            lblKuantitas.AutoSize = true;
            lblKuantitas.BackColor = SystemColors.ButtonHighlight;
            lblKuantitas.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKuantitas.Location = new Point(473, 31);
            lblKuantitas.Name = "lblKuantitas";
            lblKuantitas.Size = new Size(22, 25);
            lblKuantitas.TabIndex = 6;
            lblKuantitas.Text = "1";
            // 
            // pictureBoxGambar
            // 
            pictureBoxGambar.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxGambar.Location = new Point(50, 2);
            pictureBoxGambar.Name = "pictureBoxGambar";
            pictureBoxGambar.Size = new Size(90, 91);
            pictureBoxGambar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGambar.TabIndex = 7;
            pictureBoxGambar.TabStop = false;
            // 
            // btnKurang
            // 
            btnKurang.BackColor = SystemColors.ButtonHighlight;
            btnKurang.Location = new Point(436, 28);
            btnKurang.Name = "btnKurang";
            btnKurang.Size = new Size(33, 33);
            btnKurang.TabIndex = 8;
            btnKurang.Text = "-";
            btnKurang.UseVisualStyleBackColor = false;
            btnKurang.Click += btnKurang_Click;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = SystemColors.ButtonHighlight;
            btnTambah.Location = new Point(498, 28);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(30, 33);
            btnTambah.TabIndex = 9;
            btnTambah.Text = "+";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = SystemColors.ButtonHighlight;
            btnHapus.BackgroundImage = Properties.Resources.Screenshot_2026_06_06_172834;
            btnHapus.Location = new Point(852, 28);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(33, 41);
            btnHapus.TabIndex = 10;
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // ItemKeranjangCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_06_06_171850;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(btnHapus);
            Controls.Add(btnTambah);
            Controls.Add(btnKurang);
            Controls.Add(pictureBoxGambar);
            Controls.Add(lblKuantitas);
            Controls.Add(lblHarga);
            Controls.Add(lblNama);
            Controls.Add(lblSubtotal);
            DoubleBuffered = true;
            Name = "ItemKeranjangCard";
            Size = new Size(904, 94);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubtotal;
        private Label lblNama;
        private Label lblHarga;
        private Label lblKuantitas;
        private PictureBox pictureBoxGambar;
        private Button btnKurang;
        private Button btnTambah;
        private Button btnHapus;
        private ToolTip toolTip1;
    }
}
