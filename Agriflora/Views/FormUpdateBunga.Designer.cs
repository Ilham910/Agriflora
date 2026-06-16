namespace Agriflora.Views
{
    partial class FormUpdateBunga
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
            tbJenis = new TextBox();
            tbStok = new TextBox();
            tbHarga = new TextBox();
            tbDeskripsi = new RichTextBox();
            tbNama = new TextBox();
            btnSimpan = new Button();
            btnUpload = new Button();
            pictureBoxGambar = new PictureBox();
            tbWarna = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            btnBatal = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).BeginInit();
            SuspendLayout();
            // 
            // tbJenis
            // 
            tbJenis.BackColor = Color.LavenderBlush;
            tbJenis.Font = new Font("Segoe UI", 15F);
            tbJenis.Location = new Point(263, 62);
            tbJenis.Name = "tbJenis";
            tbJenis.Size = new Size(190, 41);
            tbJenis.TabIndex = 28;
            // 
            // tbStok
            // 
            tbStok.BackColor = Color.LavenderBlush;
            tbStok.Font = new Font("Segoe UI", 15F);
            tbStok.Location = new Point(263, 138);
            tbStok.Name = "tbStok";
            tbStok.Size = new Size(190, 41);
            tbStok.TabIndex = 27;
            // 
            // tbHarga
            // 
            tbHarga.BackColor = Color.LavenderBlush;
            tbHarga.Font = new Font("Segoe UI", 15F);
            tbHarga.Location = new Point(33, 135);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(190, 41);
            tbHarga.TabIndex = 26;
            // 
            // tbDeskripsi
            // 
            tbDeskripsi.BackColor = Color.LavenderBlush;
            tbDeskripsi.Location = new Point(32, 283);
            tbDeskripsi.Name = "tbDeskripsi";
            tbDeskripsi.Size = new Size(223, 114);
            tbDeskripsi.TabIndex = 25;
            tbDeskripsi.Text = "";
            // 
            // tbNama
            // 
            tbNama.BackColor = Color.LavenderBlush;
            tbNama.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNama.Location = new Point(33, 62);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(190, 41);
            tbNama.TabIndex = 24;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Green;
            btnSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = SystemColors.ButtonHighlight;
            btnSimpan.Location = new Point(248, 402);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(186, 42);
            btnSimpan.TabIndex = 18;
            btnSimpan.Text = "Simpan Perubahan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(285, 295);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(142, 29);
            btnUpload.TabIndex = 17;
            btnUpload.Text = "Upload Gambar";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // pictureBoxGambar
            // 
            pictureBoxGambar.BackColor = SystemColors.ControlLight;
            pictureBoxGambar.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxGambar.Location = new Point(261, 215);
            pictureBoxGambar.Name = "pictureBoxGambar";
            pictureBoxGambar.Size = new Size(188, 181);
            pictureBoxGambar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGambar.TabIndex = 16;
            pictureBoxGambar.TabStop = false;
            // 
            // tbWarna
            // 
            tbWarna.BackColor = Color.LavenderBlush;
            tbWarna.Font = new Font("Segoe UI", 15F);
            tbWarna.Location = new Point(34, 207);
            tbWarna.Name = "tbWarna";
            tbWarna.Size = new Size(190, 41);
            tbWarna.TabIndex = 30;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Crimson;
            btnBatal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = SystemColors.ButtonHighlight;
            btnBatal.Location = new Point(33, 403);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(190, 41);
            btnBatal.TabIndex = 31;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // FormUpdateBunga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_06_16_135030;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(461, 450);
            Controls.Add(btnBatal);
            Controls.Add(tbWarna);
            Controls.Add(tbJenis);
            Controls.Add(tbStok);
            Controls.Add(tbHarga);
            Controls.Add(tbDeskripsi);
            Controls.Add(tbNama);
            Controls.Add(btnSimpan);
            Controls.Add(btnUpload);
            Controls.Add(pictureBoxGambar);
            DoubleBuffered = true;
            Name = "FormUpdateBunga";
            Text = "FormUpdateBunga";
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbJenis;
        private TextBox tbStok;
        private TextBox tbHarga;
        private RichTextBox tbDeskripsi;
        private TextBox tbNama;
        private Button btnSimpan;
        private Button btnUpload;
        private PictureBox pictureBoxGambar;
        private TextBox tbWarna;
        private OpenFileDialog openFileDialog1;
        private Button btnBatal;
    }
}