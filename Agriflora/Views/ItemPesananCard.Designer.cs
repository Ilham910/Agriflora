namespace Agriflora.Views
{
    partial class ItemPesananCard
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxGambar
            // 
            pictureBoxGambar.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxGambar.Location = new Point(17, 3);
            pictureBoxGambar.Name = "pictureBoxGambar";
            pictureBoxGambar.Size = new Size(67, 68);
            pictureBoxGambar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGambar.TabIndex = 10;
            pictureBoxGambar.TabStop = false;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.BackColor = SystemColors.ButtonHighlight;
            lblHarga.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHarga.Location = new Point(96, 42);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(69, 17);
            lblHarga.TabIndex = 9;
            lblHarga.Text = "Rp. 65.000";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.BackColor = SystemColors.ButtonHighlight;
            lblNama.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(95, 17);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(119, 20);
            lblNama.TabIndex = 8;
            lblNama.Text = "Bibit Mawar x 1";
            // 
            // ItemPesananCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_06_07_194144;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(pictureBoxGambar);
            Controls.Add(lblHarga);
            Controls.Add(lblNama);
            DoubleBuffered = true;
            Name = "ItemPesananCard";
            Size = new Size(718, 74);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxGambar;
        private Label lblHarga;
        private Label lblNama;
    }
}
