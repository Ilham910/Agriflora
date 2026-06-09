namespace Agriflora.Views
{
    partial class FormQris
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
            btnUpload = new Button();
            lblCountdown = new Label();
            countdownTimer = new System.Windows.Forms.Timer(components);
            pictureBoxGambar = new PictureBox();
            btnSelesai = new Button();
            lblInstruksi = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnUpload
            // 
            btnUpload.Image = Properties.Resources.Screenshot_2026_06_07_132820;
            btnUpload.Location = new Point(434, 332);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(203, 73);
            btnUpload.TabIndex = 0;
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // lblCountdown
            // 
            lblCountdown.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountdown.ForeColor = Color.MediumVioletRed;
            lblCountdown.Image = Properties.Resources.Screenshot_2026_06_07_140237;
            lblCountdown.Location = new Point(599, 242);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(138, 30);
            lblCountdown.TabIndex = 1;
            lblCountdown.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxGambar
            // 
            pictureBoxGambar.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxGambar.Location = new Point(643, 332);
            pictureBoxGambar.Name = "pictureBoxGambar";
            pictureBoxGambar.Size = new Size(327, 234);
            pictureBoxGambar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGambar.TabIndex = 2;
            pictureBoxGambar.TabStop = false;
            // 
            // btnSelesai
            // 
            btnSelesai.BackColor = Color.Lime;
            btnSelesai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelesai.Location = new Point(29, 527);
            btnSelesai.Name = "btnSelesai";
            btnSelesai.Size = new Size(362, 39);
            btnSelesai.TabIndex = 3;
            btnSelesai.Text = "Selesai";
            btnSelesai.UseVisualStyleBackColor = false;
            btnSelesai.Click += btnSelesai_Click;
            // 
            // lblInstruksi
            // 
            lblInstruksi.BackColor = Color.LavenderBlush;
            lblInstruksi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstruksi.Location = new Point(63, 460);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(302, 54);
            lblInstruksi.TabIndex = 4;
            lblInstruksi.Text = "Instruksi";
            lblInstruksi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormQris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bayar_Qris;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 578);
            Controls.Add(lblInstruksi);
            Controls.Add(btnSelesai);
            Controls.Add(pictureBoxGambar);
            Controls.Add(lblCountdown);
            Controls.Add(btnUpload);
            Name = "FormQris";
            Text = "FormQris";
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button btnUpload;
        private Label lblCountdown;
        private System.Windows.Forms.Timer countdownTimer;
        private PictureBox pictureBoxGambar;
        private Button btnSelesai;
        private Label lblInstruksi;
    }
}