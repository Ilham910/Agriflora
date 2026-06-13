namespace Agriflora.Views
{
    partial class PesananTerbaruCard
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
            lblId = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.BackColor = SystemColors.ButtonHighlight;
            lblId.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(59, 9);
            lblId.Name = "lblId";
            lblId.Size = new Size(128, 19);
            lblId.TabIndex = 0;
            lblId.Text = "ID : 15";
            // 
            // lblStatus
            // 
            lblStatus.BackColor = SystemColors.ButtonHighlight;
            lblStatus.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(59, 30);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(128, 19);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Menunggu Pembayaran";
            // 
            // PesananTerbaruCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_06_13_214658;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(lblStatus);
            Controls.Add(lblId);
            DoubleBuffered = true;
            Name = "PesananTerbaruCard";
            Size = new Size(289, 59);
            ResumeLayout(false);
        }

        #endregion

        private Label lblId;
        private Label lblStatus;
    }
}
