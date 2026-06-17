namespace Agriflora.Views
{
    partial class FormRincianProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRincianProduk));
            lblNama = new Label();
            lblHarga = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblStok = new Label();
            tbDeskripsi = new RichTextBox();
            btnTambah = new Button();
            btnKurang = new Button();
            lblKuantitas = new Label();
            PanelBibit = new Panel();
            lblJenisTanaman = new Label();
            label4 = new Label();
            pictureBoxGambar = new PictureBox();
            btnMasuk = new Button();
            btnKeranjang = new Button();
            lblSubtotal = new Label();
            label6 = new Label();
            panelBunga = new Panel();
            lblWarna = new Label();
            PanelBibit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).BeginInit();
            panelBunga.SuspendLayout();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.BackColor = Color.LavenderBlush;
            lblNama.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(383, 108);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(199, 38);
            lblNama.TabIndex = 0;
            lblNama.Text = "Bunga Mawar";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.BackColor = Color.LavenderBlush;
            lblHarga.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.ForeColor = Color.PaleVioletRed;
            lblHarga.Location = new Point(385, 149);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(120, 31);
            lblHarga.TabIndex = 1;
            lblHarga.Text = "Rp 16.000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LavenderBlush;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(392, 213);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 2;
            label1.Text = "Opsi Warna";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LavenderBlush;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(393, 271);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 3;
            label2.Text = "Kuantitas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LavenderBlush;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(393, 323);
            label3.Name = "label3";
            label3.Size = new Size(51, 28);
            label3.TabIndex = 4;
            label3.Text = "Stok";
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.BackColor = Color.LavenderBlush;
            lblStok.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStok.ForeColor = SystemColors.ActiveCaptionText;
            lblStok.Location = new Point(534, 324);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(73, 28);
            lblStok.TabIndex = 5;
            lblStok.Text = "50 Pot";
            // 
            // tbDeskripsi
            // 
            tbDeskripsi.Enabled = false;
            tbDeskripsi.Location = new Point(41, 364);
            tbDeskripsi.Name = "tbDeskripsi";
            tbDeskripsi.Size = new Size(913, 202);
            tbDeskripsi.TabIndex = 8;
            tbDeskripsi.Text = resources.GetString("tbDeskripsi.Text");
            // 
            // btnTambah
            // 
            btnTambah.BackColor = SystemColors.ButtonHighlight;
            btnTambah.Location = new Point(585, 270);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(33, 33);
            btnTambah.TabIndex = 12;
            btnTambah.Text = "+";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnKurang
            // 
            btnKurang.BackColor = SystemColors.ButtonHighlight;
            btnKurang.Location = new Point(523, 270);
            btnKurang.Name = "btnKurang";
            btnKurang.Size = new Size(33, 33);
            btnKurang.TabIndex = 11;
            btnKurang.Text = "-";
            btnKurang.UseVisualStyleBackColor = false;
            btnKurang.Click += btnKurang_Click;
            // 
            // lblKuantitas
            // 
            lblKuantitas.AutoSize = true;
            lblKuantitas.BackColor = SystemColors.ButtonHighlight;
            lblKuantitas.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKuantitas.Location = new Point(562, 273);
            lblKuantitas.Name = "lblKuantitas";
            lblKuantitas.Size = new Size(22, 25);
            lblKuantitas.TabIndex = 10;
            lblKuantitas.Text = "1";
            // 
            // PanelBibit
            // 
            PanelBibit.BackColor = Color.LavenderBlush;
            PanelBibit.Controls.Add(lblJenisTanaman);
            PanelBibit.Controls.Add(label4);
            PanelBibit.Location = new Point(393, 205);
            PanelBibit.Name = "PanelBibit";
            PanelBibit.Size = new Size(445, 59);
            PanelBibit.TabIndex = 13;
            PanelBibit.Paint += panel1_Paint;
            // 
            // lblJenisTanaman
            // 
            lblJenisTanaman.AutoSize = true;
            lblJenisTanaman.BackColor = Color.LavenderBlush;
            lblJenisTanaman.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJenisTanaman.ForeColor = SystemColors.ActiveCaptionText;
            lblJenisTanaman.Location = new Point(142, 15);
            lblJenisTanaman.Name = "lblJenisTanaman";
            lblJenisTanaman.Size = new Size(150, 28);
            lblJenisTanaman.TabIndex = 15;
            lblJenisTanaman.Text = "Jenis Tanaman";
            lblJenisTanaman.Click += lblJenisTanaman_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LavenderBlush;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(3, 15);
            label4.Name = "label4";
            label4.Size = new Size(53, 28);
            label4.TabIndex = 14;
            label4.Text = "Jenis";
            // 
            // pictureBoxGambar
            // 
            pictureBoxGambar.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxGambar.Location = new Point(51, 91);
            pictureBoxGambar.Name = "pictureBoxGambar";
            pictureBoxGambar.Size = new Size(275, 261);
            pictureBoxGambar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGambar.TabIndex = 14;
            pictureBoxGambar.TabStop = false;
            // 
            // btnMasuk
            // 
            btnMasuk.BackgroundImage = Properties.Resources.Screenshot_2026_06_07_094701;
            btnMasuk.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMasuk.Location = new Point(669, 96);
            btnMasuk.Name = "btnMasuk";
            btnMasuk.Size = new Size(307, 61);
            btnMasuk.TabIndex = 15;
            btnMasuk.UseVisualStyleBackColor = true;
            btnMasuk.Click += btnMasuk_Click;
            // 
            // btnKeranjang
            // 
            btnKeranjang.BackgroundImage = Properties.Resources.Screenshot_2026_06_06_182345;
            btnKeranjang.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKeranjang.Location = new Point(905, 5);
            btnKeranjang.Name = "btnKeranjang";
            btnKeranjang.Size = new Size(61, 61);
            btnKeranjang.TabIndex = 16;
            btnKeranjang.UseVisualStyleBackColor = true;
            btnKeranjang.Click += btnKeranjang_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.BackColor = Color.LavenderBlush;
            lblSubtotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.ForeColor = SystemColors.ActiveCaptionText;
            lblSubtotal.Location = new Point(764, 271);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(120, 31);
            lblSubtotal.TabIndex = 17;
            lblSubtotal.Text = "Rp 16.000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LavenderBlush;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(665, 272);
            label6.Name = "label6";
            label6.Size = new Size(96, 28);
            label6.TabIndex = 18;
            label6.Text = "Subtotal :";
            // 
            // panelBunga
            // 
            panelBunga.BackColor = Color.LavenderBlush;
            panelBunga.Controls.Add(lblWarna);
            panelBunga.Location = new Point(509, 205);
            panelBunga.Name = "panelBunga";
            panelBunga.Size = new Size(445, 59);
            panelBunga.TabIndex = 19;
            // 
            // lblWarna
            // 
            lblWarna.AutoSize = true;
            lblWarna.BackColor = Color.LavenderBlush;
            lblWarna.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWarna.ForeColor = SystemColors.ActiveCaptionText;
            lblWarna.Location = new Point(142, 15);
            lblWarna.Name = "lblWarna";
            lblWarna.Size = new Size(73, 28);
            lblWarna.TabIndex = 15;
            lblWarna.Text = "Warna";
            lblWarna.Click += label5_Click;
            // 
            // FormRincianProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Rincian_Produk;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 578);
            Controls.Add(panelBunga);
            Controls.Add(label6);
            Controls.Add(lblSubtotal);
            Controls.Add(btnKeranjang);
            Controls.Add(btnMasuk);
            Controls.Add(pictureBoxGambar);
            Controls.Add(PanelBibit);
            Controls.Add(btnTambah);
            Controls.Add(btnKurang);
            Controls.Add(lblKuantitas);
            Controls.Add(tbDeskripsi);
            Controls.Add(lblStok);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblHarga);
            Controls.Add(lblNama);
            Name = "FormRincianProduk";
            Text = "FormRincianProduk";
            PanelBibit.ResumeLayout(false);
            PanelBibit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).EndInit();
            panelBunga.ResumeLayout(false);
            panelBunga.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNama;
        private Label lblHarga;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblStok;
        private RichTextBox tbDeskripsi;
        private Button btnTambah;
        private Button btnKurang;
        private Label lblKuantitas;
        private Panel PanelBibit;
        private Label lblJenisTanaman;
        private Label label4;
        private PictureBox pictureBoxGambar;
        private Button btnMasuk;
        private Button btnKeranjang;
        private Label lblSubtotal;
        private Label label6;
        private Panel panelBunga;
        private Label lblWarna;
    }
}