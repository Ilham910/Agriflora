namespace Agriflora.Views
{
    partial class ProdukTerlarisCard
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
            pnlBarBg = new Panel();
            pnlBar = new Panel();
            lblNama = new Label();
            pnlBarBg.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBarBg
            // 
            pnlBarBg.BackColor = SystemColors.ButtonHighlight;
            pnlBarBg.Controls.Add(pnlBar);
            pnlBarBg.Location = new Point(0, 0);
            pnlBarBg.Name = "pnlBarBg";
            pnlBarBg.Size = new Size(373, 26);
            pnlBarBg.TabIndex = 21;
            // 
            // pnlBar
            // 
            pnlBar.BackColor = SystemColors.ButtonHighlight;
            pnlBar.Location = new Point(99, 4);
            pnlBar.Name = "pnlBar";
            pnlBar.Size = new Size(271, 16);
            pnlBar.TabIndex = 22;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.BackColor = SystemColors.ButtonHighlight;
            lblNama.Location = new Point(1, 2);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(50, 20);
            lblNama.TabIndex = 22;
            lblNama.Text = "label1";
            // 
            // ProdukTerlarisCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblNama);
            Controls.Add(pnlBarBg);
            Name = "ProdukTerlarisCard";
            Size = new Size(373, 26);
            pnlBarBg.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBarBg;
        private Panel pnlBar;
        private Label lblNama;
    }
}
