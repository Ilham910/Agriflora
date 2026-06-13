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
            contextMenuStrip1 = new ContextMenuStrip(components);
            tbNama = new TextBox();
            tbDeskripsi = new RichTextBox();
            tbHarga = new TextBox();
            tbStok = new TextBox();
            tbJenis = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pictureBoxGambar.Location = new Point(264, 214);
            pictureBoxGambar.Name = "pictureBoxGambar";
            pictureBoxGambar.Size = new Size(173, 175);
            pictureBoxGambar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGambar.TabIndex = 1;
            pictureBoxGambar.TabStop = false;
            pictureBoxGambar.Click += pictureBoxGambar_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(282, 287);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(142, 29);
            btnUpload.TabIndex = 2;
            btnUpload.Text = "Upload Gambar";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Green;
            btnSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = SystemColors.ButtonHighlight;
            btnSimpan.Location = new Point(248, 400);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(181, 41);
            btnSimpan.TabIndex = 3;
            btnSimpan.Text = "Simpan Perubahan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tbNama
            // 
            tbNama.BackColor = Color.LavenderBlush;
            tbNama.Font = new Font("Microsoft Sans Serif", 16.8000011F);
            tbNama.Location = new Point(35, 62);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(190, 39);
            tbNama.TabIndex = 11;
            // 
            // tbDeskripsi
            // 
            tbDeskripsi.BackColor = Color.LavenderBlush;
            tbDeskripsi.Location = new Point(31, 285);
            tbDeskripsi.Name = "tbDeskripsi";
            tbDeskripsi.Size = new Size(220, 110);
            tbDeskripsi.TabIndex = 12;
            tbDeskripsi.Text = "";
            tbDeskripsi.TextChanged += tbDeskripsi_TextChanged;
            // 
            // tbHarga
            // 
            tbHarga.BackColor = Color.LavenderBlush;
            tbHarga.Font = new Font("Microsoft Sans Serif", 16.8000011F);
            tbHarga.Location = new Point(35, 135);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(190, 39);
            tbHarga.TabIndex = 13;
            // 
            // tbStok
            // 
            tbStok.BackColor = Color.LavenderBlush;
            tbStok.Font = new Font("Microsoft Sans Serif", 16.8000011F);
            tbStok.Location = new Point(264, 138);
            tbStok.Name = "tbStok";
            tbStok.Size = new Size(190, 39);
            tbStok.TabIndex = 14;
            // 
            // tbJenis
            // 
            tbJenis.BackColor = Color.LavenderBlush;
            tbJenis.Font = new Font("Microsoft Sans Serif", 16.8000011F);
            tbJenis.Location = new Point(264, 62);
            tbJenis.Name = "tbJenis";
            tbJenis.Size = new Size(190, 39);
            tbJenis.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Screenshot_2026_06_10_134722;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.Screenshot_2026_06_10_134722;
            pictureBox1.Location = new Point(35, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 80);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // FormUpdateBibit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_06_08_0137551;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(461, 450);
            Controls.Add(pictureBox1);
            Controls.Add(tbJenis);
            Controls.Add(tbStok);
            Controls.Add(tbHarga);
            Controls.Add(tbDeskripsi);
            Controls.Add(tbNama);
            Controls.Add(btnSimpan);
            Controls.Add(btnUpload);
            Controls.Add(pictureBoxGambar);
            DoubleBuffered = true;
            Name = "FormUpdateBibit";
            Text = "FormUpdateBibit";
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBoxGambar;
        private Button btnUpload;
        private Button btnSimpan;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox tbNama;
        private RichTextBox tbDeskripsi;
        private TextBox tbHarga;
        private TextBox tbStok;
        private TextBox tbJenis;
        private PictureBox pictureBox1;
    }
}