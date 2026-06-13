namespace Agriflora.Views
{
    partial class ProdukCard
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
            pictureBoxGambar = new PictureBox();
            lblNama = new Label();
            lblHarga = new Label();
            btnUbah = new Button();
            btnHapus = new Button();
            lblJenis = new Label();
            lblKuantitas = new Label();
            lblTersedia = new Label();
            lblHabis = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxGambar
            // 
            pictureBoxGambar.Location = new Point(0, 0);
            pictureBoxGambar.Name = "pictureBoxGambar";
            pictureBoxGambar.Size = new Size(76, 77);
            pictureBoxGambar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGambar.TabIndex = 0;
            pictureBoxGambar.TabStop = false;
            // 
            // lblNama
            // 
            lblNama.BackColor = SystemColors.ButtonHighlight;
            lblNama.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(78, 13);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(132, 40);
            lblNama.TabIndex = 1;
            lblNama.Text = "Bunga Mawar";
            lblNama.TextAlign = ContentAlignment.MiddleLeft;
            lblNama.Click += label1_Click;
            // 
            // lblHarga
            // 
            lblHarga.BackColor = SystemColors.ButtonHighlight;
            lblHarga.Location = new Point(284, 14);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(76, 40);
            lblHarga.TabIndex = 2;
            lblHarga.Text = "Rp.16.000";
            lblHarga.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnUbah
            // 
            btnUbah.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUbah.Location = new Point(642, 2);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(70, 27);
            btnUbah.TabIndex = 3;
            btnUbah.Text = "Edit";
            btnUbah.UseVisualStyleBackColor = true;
            btnUbah.Click += btnUbah_Click_1;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(642, 28);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(82, 30);
            btnHapus.TabIndex = 4;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click_1;
            // 
            // lblJenis
            // 
            lblJenis.AutoSize = true;
            lblJenis.BackColor = SystemColors.ButtonHighlight;
            lblJenis.Location = new Point(207, 23);
            lblJenis.Name = "lblJenis";
            lblJenis.Size = new Size(51, 20);
            lblJenis.TabIndex = 5;
            lblJenis.Text = "Bunga";
            // 
            // lblKuantitas
            // 
            lblKuantitas.AutoSize = true;
            lblKuantitas.BackColor = SystemColors.ButtonHighlight;
            lblKuantitas.Location = new Point(366, 24);
            lblKuantitas.Name = "lblKuantitas";
            lblKuantitas.Size = new Size(25, 20);
            lblKuantitas.TabIndex = 6;
            lblKuantitas.Text = "50";
            // 
            // lblTersedia
            // 
            lblTersedia.Image = Properties.Resources.Screenshot_2026_06_08_011353;
            lblTersedia.Location = new Point(546, 17);
            lblTersedia.Name = "lblTersedia";
            lblTersedia.Size = new Size(76, 30);
            lblTersedia.TabIndex = 7;
            // 
            // lblHabis
            // 
            lblHabis.Image = Properties.Resources.Screenshot_2026_06_08_011407;
            lblHabis.Location = new Point(546, 17);
            lblHabis.Name = "lblHabis";
            lblHabis.Size = new Size(76, 30);
            lblHabis.TabIndex = 8;
            // 
            // ProdukCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_06_08_005622;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(lblHabis);
            Controls.Add(lblTersedia);
            Controls.Add(lblKuantitas);
            Controls.Add(lblJenis);
            Controls.Add(btnHapus);
            Controls.Add(btnUbah);
            Controls.Add(lblHarga);
            Controls.Add(lblNama);
            Controls.Add(pictureBoxGambar);
            DoubleBuffered = true;
            Name = "ProdukCard";
            Size = new Size(735, 71);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxGambar;
        private Label lblNama;
        private Label lblHarga;
        private Button btnUbah;
        private Button btnHapus;
        private Label lblJenis;
        private Label lblKuantitas;
        private Label lblTersedia;
        private Label lblHabis;
        private ToolTip toolTip1;
    }
}
