namespace Agriflora.Views
{
    partial class FormTambahProduk
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
            pictureBoxTambahGambar = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btUploadTambahGambar = new Button();
            radioBunga = new RadioButton();
            radioBibit = new RadioButton();
            label1 = new Label();
            panelBunga = new Panel();
            tbDeskripsiBunga = new RichTextBox();
            tbWarna = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tbJenisBunga = new TextBox();
            label2 = new Label();
            panelBibit = new Panel();
            tbDeskripsiBibit = new RichTextBox();
            label5 = new Label();
            tbJenisTanaman = new TextBox();
            label7 = new Label();
            btSimpan = new Button();
            label6 = new Label();
            tbNama = new TextBox();
            label8 = new Label();
            label9 = new Label();
            tbHarga = new TextBox();
            tbStok = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTambahGambar).BeginInit();
            panelBunga.SuspendLayout();
            panelBibit.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxTambahGambar
            // 
            pictureBoxTambahGambar.BackColor = SystemColors.ControlLight;
            pictureBoxTambahGambar.Location = new Point(484, 49);
            pictureBoxTambahGambar.Name = "pictureBoxTambahGambar";
            pictureBoxTambahGambar.Size = new Size(239, 162);
            pictureBoxTambahGambar.TabIndex = 0;
            pictureBoxTambahGambar.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            // 
            // btUploadTambahGambar
            // 
            btUploadTambahGambar.Location = new Point(532, 118);
            btUploadTambahGambar.Name = "btUploadTambahGambar";
            btUploadTambahGambar.Size = new Size(145, 29);
            btUploadTambahGambar.TabIndex = 1;
            btUploadTambahGambar.Text = "Upload Gambar";
            btUploadTambahGambar.UseVisualStyleBackColor = true;
            btUploadTambahGambar.Click += btUploadTambahGambar_Click;
            // 
            // radioBunga
            // 
            radioBunga.AutoSize = true;
            radioBunga.Location = new Point(58, 229);
            radioBunga.Name = "radioBunga";
            radioBunga.Size = new Size(72, 24);
            radioBunga.TabIndex = 2;
            radioBunga.TabStop = true;
            radioBunga.Text = "Bunga";
            radioBunga.UseVisualStyleBackColor = true;
            // 
            // radioBibit
            // 
            radioBibit.AutoSize = true;
            radioBibit.Location = new Point(136, 229);
            radioBibit.Name = "radioBibit";
            radioBibit.Size = new Size(61, 24);
            radioBibit.TabIndex = 3;
            radioBibit.TabStop = true;
            radioBibit.Text = "Bibit";
            radioBibit.UseVisualStyleBackColor = true;
            radioBibit.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 229);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 4;
            label1.Text = "Tipe :";
            // 
            // panelBunga
            // 
            panelBunga.Controls.Add(tbDeskripsiBunga);
            panelBunga.Controls.Add(tbWarna);
            panelBunga.Controls.Add(label4);
            panelBunga.Controls.Add(label3);
            panelBunga.Controls.Add(tbJenisBunga);
            panelBunga.Controls.Add(label2);
            panelBunga.Location = new Point(7, 259);
            panelBunga.Name = "panelBunga";
            panelBunga.Size = new Size(446, 179);
            panelBunga.TabIndex = 5;
            // 
            // tbDeskripsiBunga
            // 
            tbDeskripsiBunga.Location = new Point(97, 89);
            tbDeskripsiBunga.Name = "tbDeskripsiBunga";
            tbDeskripsiBunga.Size = new Size(346, 82);
            tbDeskripsiBunga.TabIndex = 11;
            tbDeskripsiBunga.Text = "";
            tbDeskripsiBunga.TextChanged += richTextBox1_TextChanged;
            // 
            // tbWarna
            // 
            tbWarna.Location = new Point(97, 53);
            tbWarna.Name = "tbWarna";
            tbWarna.Size = new Size(197, 27);
            tbWarna.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 92);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 8;
            label4.Text = "Deskripsi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 56);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 7;
            label3.Text = "Warna";
            // 
            // tbJenisBunga
            // 
            tbJenisBunga.Location = new Point(97, 14);
            tbJenisBunga.Name = "tbJenisBunga";
            tbJenisBunga.Size = new Size(197, 27);
            tbJenisBunga.TabIndex = 6;
            tbJenisBunga.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 17);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 0;
            label2.Text = "Jenis Bunga";
            // 
            // panelBibit
            // 
            panelBibit.Controls.Add(tbDeskripsiBibit);
            panelBibit.Controls.Add(label5);
            panelBibit.Controls.Add(tbJenisTanaman);
            panelBibit.Controls.Add(label7);
            panelBibit.Location = new Point(7, 259);
            panelBibit.Name = "panelBibit";
            panelBibit.Size = new Size(446, 179);
            panelBibit.TabIndex = 6;
            // 
            // tbDeskripsiBibit
            // 
            tbDeskripsiBibit.Location = new Point(114, 61);
            tbDeskripsiBibit.Name = "tbDeskripsiBibit";
            tbDeskripsiBibit.Size = new Size(329, 115);
            tbDeskripsiBibit.TabIndex = 11;
            tbDeskripsiBibit.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 61);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 8;
            label5.Text = "Deskripsi";
            // 
            // tbJenisTanaman
            // 
            tbJenisTanaman.Location = new Point(114, 14);
            tbJenisTanaman.Name = "tbJenisTanaman";
            tbJenisTanaman.Size = new Size(197, 27);
            tbJenisTanaman.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 17);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 0;
            label7.Text = "Jenis Tanaman";
            // 
            // btSimpan
            // 
            btSimpan.Location = new Point(662, 403);
            btSimpan.Name = "btSimpan";
            btSimpan.Size = new Size(126, 35);
            btSimpan.TabIndex = 7;
            btSimpan.Text = "Simpan";
            btSimpan.UseVisualStyleBackColor = true;
            btSimpan.Click += btSimpan_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 102);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 8;
            label6.Text = "Nama Produk";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(121, 99);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(197, 27);
            tbNama.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 147);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 10;
            label8.Text = "Harga";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 191);
            label9.Name = "label9";
            label9.Size = new Size(38, 20);
            label9.TabIndex = 11;
            label9.Text = "Stok";
            // 
            // tbHarga
            // 
            tbHarga.Location = new Point(121, 144);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(197, 27);
            tbHarga.TabIndex = 12;
            // 
            // tbStok
            // 
            tbStok.Location = new Point(121, 188);
            tbStok.Name = "tbStok";
            tbStok.Size = new Size(197, 27);
            tbStok.TabIndex = 13;
            // 
            // FormTambahProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbStok);
            Controls.Add(tbHarga);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(tbNama);
            Controls.Add(label6);
            Controls.Add(btSimpan);
            Controls.Add(panelBunga);
            Controls.Add(label1);
            Controls.Add(radioBibit);
            Controls.Add(radioBunga);
            Controls.Add(btUploadTambahGambar);
            Controls.Add(pictureBoxTambahGambar);
            Controls.Add(panelBibit);
            Name = "FormTambahProduk";
            Text = "FormTambahProduk";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTambahGambar).EndInit();
            panelBunga.ResumeLayout(false);
            panelBunga.PerformLayout();
            panelBibit.ResumeLayout(false);
            panelBibit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxTambahGambar;
        private OpenFileDialog openFileDialog1;
        private Button btUploadTambahGambar;
        private RadioButton radioBunga;
        private RadioButton radioBibit;
        private Label label1;
        private Panel panelBunga;
        private TextBox tbWarna;
        private Label label4;
        private Label label3;
        private TextBox tbJenisBunga;
        private Label label2;
        private RichTextBox tbDeskripsiBunga;
        private Panel panelBibit;
        private RichTextBox tbDeskripsiBibit;
        private Label label5;
        private TextBox tbJenisTanaman;
        private Label label7;
        private Button btSimpan;
        private Label label6;
        private TextBox tbNama;
        private Label label8;
        private Label label9;
        private TextBox tbHarga;
        private TextBox tbStok;
    }
}