namespace Agriflora.Views
{
    partial class ProdukHampirHabisCard
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
            lblNama = new Label();
            lblStok = new Label();
            lblStatusStok = new Label();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.BackColor = SystemColors.ButtonHighlight;
            lblNama.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(6, 4);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(104, 23);
            lblNama.TabIndex = 2;
            lblNama.Text = "Bougenville";
            // 
            // lblStok
            // 
            lblStok.BackColor = SystemColors.ButtonHighlight;
            lblStok.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStok.Location = new Point(181, 3);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(104, 23);
            lblStok.TabIndex = 3;
            lblStok.Text = "5 Item";
            // 
            // lblStatusStok
            // 
            lblStatusStok.BackColor = SystemColors.ButtonHighlight;
            lblStatusStok.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusStok.Location = new Point(514, 2);
            lblStatusStok.Name = "lblStatusStok";
            lblStatusStok.Size = new Size(101, 24);
            lblStatusStok.TabIndex = 5;
            lblStatusStok.Text = "Hampir Habis";
            lblStatusStok.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProdukHampirHabisCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_06_12_1333281;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(lblStatusStok);
            Controls.Add(lblStok);
            Controls.Add(lblNama);
            DoubleBuffered = true;
            Name = "ProdukHampirHabisCard";
            Size = new Size(704, 29);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNama;
        private Label lblStok;
        private Label lblStatusStok;
    }
}
