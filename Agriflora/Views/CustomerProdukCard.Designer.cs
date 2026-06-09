namespace Agriflora.Views
{
    partial class CustomerProdukCard
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
            lblDesk = new Label();
            btnMasuk = new Button();
            pictureBoxGambar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).BeginInit();
            SuspendLayout();
            // 
            // lblDesk
            // 
            lblDesk.AutoSize = true;
            lblDesk.Location = new Point(3, 147);
            lblDesk.Name = "lblDesk";
            lblDesk.Size = new Size(50, 20);
            lblDesk.TabIndex = 1;
            lblDesk.Text = "label2";
            lblDesk.Click += lblNama_Click;
            // 
            // btnMasuk
            // 
            btnMasuk.BackColor = SystemColors.ControlText;
            btnMasuk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMasuk.ForeColor = SystemColors.ButtonHighlight;
            btnMasuk.Location = new Point(154, 203);
            btnMasuk.Name = "btnMasuk";
            btnMasuk.Size = new Size(39, 38);
            btnMasuk.TabIndex = 2;
            btnMasuk.Text = "+";
            btnMasuk.TextAlign = ContentAlignment.TopCenter;
            btnMasuk.UseVisualStyleBackColor = false;
            btnMasuk.Click += btnMasuk_Click;
            // 
            // pictureBoxGambar
            // 
            pictureBoxGambar.Location = new Point(3, 3);
            pictureBoxGambar.Name = "pictureBoxGambar";
            pictureBoxGambar.Size = new Size(190, 141);
            pictureBoxGambar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGambar.TabIndex = 3;
            pictureBoxGambar.TabStop = false;
            pictureBoxGambar.Click += pictureBoxGambar_Click;
            // 
            // CustomerProdukCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Screenshot_2026_06_08_154428;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pictureBoxGambar);
            Controls.Add(btnMasuk);
            Controls.Add(lblDesk);
            DoubleBuffered = true;
            Name = "CustomerProdukCard";
            Size = new Size(196, 244);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDesk;
        private Button btnMasuk;
        private PictureBox pictureBoxGambar;
    }
}
