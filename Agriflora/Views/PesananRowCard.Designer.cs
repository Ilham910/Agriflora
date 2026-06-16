namespace Agriflora.Views
{
    partial class PesananRowCard
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
            lblCustomer = new Label();
            lblStatus = new Label();
            lblProduk = new Label();
            lblTotal = new Label();
            lblTanggal = new Label();
            btnAksi = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = SystemColors.ButtonHighlight;
            lblId.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.DeepPink;
            lblId.Location = new Point(7, 15);
            lblId.Name = "lblId";
            lblId.Size = new Size(103, 17);
            lblId.TabIndex = 0;
            lblId.Text = "ID Pesanan : 15";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.BackColor = SystemColors.ButtonHighlight;
            lblCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomer.Location = new Point(119, 13);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(90, 20);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "Rabvinna S.";
            // 
            // lblStatus
            // 
            lblStatus.BackColor = SystemColors.ButtonHighlight;
            lblStatus.Location = new Point(464, 10);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(100, 34);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Diproses";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProduk
            // 
            lblProduk.BackColor = SystemColors.ButtonHighlight;
            lblProduk.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProduk.Location = new Point(237, 9);
            lblProduk.Name = "lblProduk";
            lblProduk.Size = new Size(119, 58);
            lblProduk.TabIndex = 7;
            lblProduk.Text = "Rabvinna S.";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = SystemColors.ButtonHighlight;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(362, 17);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(94, 20);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Rp. 177.000";
            // 
            // lblTanggal
            // 
            lblTanggal.BackColor = SystemColors.ButtonHighlight;
            lblTanggal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTanggal.Location = new Point(563, 5);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(86, 57);
            lblTanggal.TabIndex = 9;
            lblTanggal.Text = "24 Juni \r\n2026";
            lblTanggal.TextAlign = ContentAlignment.MiddleCenter;
            lblTanggal.Click += label3_Click;
            // 
            // btnAksi
            // 
            btnAksi.BackColor = SystemColors.MenuHighlight;
            btnAksi.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAksi.Location = new Point(655, 12);
            btnAksi.Name = "btnAksi";
            btnAksi.Size = new Size(87, 34);
            btnAksi.TabIndex = 10;
            btnAksi.Text = "Siap Diambil";
            btnAksi.TextAlign = ContentAlignment.MiddleCenter;
            btnAksi.Click += btnAksi_Click_1;
            // 
            // PesananRowCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_06_12_133847;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(btnAksi);
            Controls.Add(lblTanggal);
            Controls.Add(lblTotal);
            Controls.Add(lblProduk);
            Controls.Add(lblStatus);
            Controls.Add(lblCustomer);
            Controls.Add(lblId);
            DoubleBuffered = true;
            Name = "PesananRowCard";
            Size = new Size(749, 73);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblCustomer;
        private Label lblStatus;
        private Label lblProduk;
        private Label lblTotal;
        private Label lblTanggal;
        private Label btnAksi;
    }
}
