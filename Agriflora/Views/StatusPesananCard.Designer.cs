namespace Agriflora.Views
{
    partial class StatusPesananCard
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
            lblStatus = new Label();
            lblIdPesanan = new Label();
            lblTanggal = new Label();
            flowItemPesanan = new FlowLayoutPanel();
            panel1 = new Panel();
            btnBayar = new Button();
            lblTotal = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.BackColor = SystemColors.InactiveCaption;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.MidnightBlue;
            lblStatus.Location = new Point(682, 27);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(207, 36);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Diproses";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.Click += lblStatus_Click;
            // 
            // lblIdPesanan
            // 
            lblIdPesanan.BackColor = SystemColors.ButtonHighlight;
            lblIdPesanan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdPesanan.ForeColor = Color.Green;
            lblIdPesanan.Location = new Point(6, 7);
            lblIdPesanan.Name = "lblIdPesanan";
            lblIdPesanan.Size = new Size(133, 28);
            lblIdPesanan.TabIndex = 1;
            lblIdPesanan.Text = "label1";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.BackColor = SystemColors.ButtonHighlight;
            lblTanggal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTanggal.ForeColor = SystemColors.ButtonShadow;
            lblTanggal.Location = new Point(7, 35);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(172, 20);
            lblTanggal.TabIndex = 2;
            lblTanggal.Text = "24 Mei 2026 · 3 Produk";
            // 
            // flowItemPesanan
            // 
            flowItemPesanan.AutoScroll = true;
            flowItemPesanan.BackColor = SystemColors.ButtonHighlight;
            flowItemPesanan.Location = new Point(7, 83);
            flowItemPesanan.Name = "flowItemPesanan";
            flowItemPesanan.Size = new Size(902, 339);
            flowItemPesanan.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(btnBayar);
            panel1.Controls.Add(lblTotal);
            panel1.Location = new Point(7, 420);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 160);
            panel1.TabIndex = 0;
            // 
            // btnBayar
            // 
            btnBayar.BackColor = Color.LimeGreen;
            btnBayar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBayar.ForeColor = SystemColors.ButtonHighlight;
            btnBayar.Location = new Point(774, 37);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(124, 35);
            btnBayar.TabIndex = 4;
            btnBayar.Text = "BAYAR";
            btnBayar.UseVisualStyleBackColor = false;
            btnBayar.Visible = false;
            btnBayar.Click += btnBayar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = SystemColors.ButtonHighlight;
            lblTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(731, 9);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(167, 25);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total : Rp. 177.000";
            // 
            // StatusPesananCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_06_07_195002;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(panel1);
            Controls.Add(flowItemPesanan);
            Controls.Add(lblTanggal);
            Controls.Add(lblIdPesanan);
            Controls.Add(lblStatus);
            DoubleBuffered = true;
            Name = "StatusPesananCard";
            Size = new Size(918, 497);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Label lblIdPesanan;
        private Label lblTanggal;
        private FlowLayoutPanel flowItemPesanan;
        private Panel panel1;
        private Label lblTotal;
        private Button btnBayar;
    }
}
