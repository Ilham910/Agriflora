namespace Agriflora.Views
{
    partial class FormUpdateBibit
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
            components = new System.ComponentModel.Container();
            openFileDialog1 = new OpenFileDialog();
            pictureBoxGambar = new PictureBox();
            btnUpload = new Button();
            btnSimpan = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tbNama = new TextBox();
            tbDeskripsi = new RichTextBox();
            tbHarga = new TextBox();
            tbStok = new TextBox();
            tbJenis = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxGambar
            // 
            pictureBoxGambar.BackColor = SystemColors.ControlLight;
            pictureBoxGambar.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxGambar.Location = new Point(494, 59);
            pictureBoxGambar.Name = "pictureBoxGambar";
            pictureBoxGambar.Size = new Size(261, 178);
            pictureBoxGambar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGambar.TabIndex = 1;
            pictureBoxGambar.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(554, 133);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(142, 29);
            btnUpload.TabIndex = 2;
            btnUpload.Text = "Upload Gambar";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(668, 407);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(120, 31);
            btnSimpan.TabIndex = 3;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 4;
            label1.Text = "Nama Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 133);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 183);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 6;
            label3.Text = "Stok";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 235);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 7;
            label4.Text = "Jenis Tanaman";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 285);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 9;
            label6.Text = "Deskripsi";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tbNama
            // 
            tbNama.Location = new Point(132, 82);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(190, 27);
            tbNama.TabIndex = 11;
            // 
            // tbDeskripsi
            // 
            tbDeskripsi.Location = new Point(132, 284);
            tbDeskripsi.Name = "tbDeskripsi";
            tbDeskripsi.Size = new Size(324, 114);
            tbDeskripsi.TabIndex = 12;
            tbDeskripsi.Text = "";
            // 
            // tbHarga
            // 
            tbHarga.Location = new Point(132, 130);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(190, 27);
            tbHarga.TabIndex = 13;
            // 
            // tbStok
            // 
            tbStok.Location = new Point(132, 180);
            tbStok.Name = "tbStok";
            tbStok.Size = new Size(190, 27);
            tbStok.TabIndex = 14;
            // 
            // tbJenis
            // 
            tbJenis.Location = new Point(132, 232);
            tbJenis.Name = "tbJenis";
            tbJenis.Size = new Size(190, 27);
            tbJenis.TabIndex = 15;
            // 
            // FormUpdateBibit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbJenis);
            Controls.Add(tbStok);
            Controls.Add(tbHarga);
            Controls.Add(tbDeskripsi);
            Controls.Add(tbNama);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSimpan);
            Controls.Add(btnUpload);
            Controls.Add(pictureBoxGambar);
            Name = "FormUpdateBibit";
            Text = "FormUpdateBibit";
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBoxGambar;
        private Button btnUpload;
        private Button btnSimpan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox tbNama;
        private RichTextBox tbDeskripsi;
        private TextBox tbHarga;
        private TextBox tbStok;
        private TextBox tbJenis;
    }
}