namespace Agriflora.Views
{
    partial class FormKeranjang
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
            flowLayoutPanelKeranjang = new FlowLayoutPanel();
            lblTotalHarga = new Label();
            btnCheckout = new Button();
            btnMenu = new Button();
            btnBeranda = new Button();
            btnStatus = new Button();
            btnRiwayat = new Button();
            btnProfil = new Button();
            btnLogout = new Button();
            panelMenu = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelKeranjang
            // 
            flowLayoutPanelKeranjang.AutoScroll = true;
            flowLayoutPanelKeranjang.BackColor = SystemColors.ButtonHighlight;
            flowLayoutPanelKeranjang.Location = new Point(25, 149);
            flowLayoutPanelKeranjang.Name = "flowLayoutPanelKeranjang";
            flowLayoutPanelKeranjang.Size = new Size(934, 292);
            flowLayoutPanelKeranjang.TabIndex = 0;
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.BackColor = SystemColors.ButtonHighlight;
            lblTotalHarga.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalHarga.ForeColor = Color.PaleVioletRed;
            lblTotalHarga.Location = new Point(792, 467);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(90, 20);
            lblTotalHarga.TabIndex = 0;
            lblTotalHarga.Text = "Rp 177.000";
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.PaleVioletRed;
            btnCheckout.ForeColor = SystemColors.Control;
            btnCheckout.Location = new Point(27, 506);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(936, 60);
            btnCheckout.TabIndex = 1;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.LavenderBlush;
            btnMenu.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(0, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(47, 49);
            btnMenu.TabIndex = 12;
            btnMenu.Text = "☰";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnBeranda
            // 
            btnBeranda.BackColor = Color.LavenderBlush;
            btnBeranda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBeranda.Location = new Point(33, 168);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.RightToLeft = RightToLeft.No;
            btnBeranda.Size = new Size(78, 29);
            btnBeranda.TabIndex = 13;
            btnBeranda.Text = "Beranda";
            btnBeranda.UseVisualStyleBackColor = false;
            btnBeranda.Click += btnBeranda_Click;
            // 
            // btnStatus
            // 
            btnStatus.BackColor = Color.LavenderBlush;
            btnStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatus.Location = new Point(33, 209);
            btnStatus.Name = "btnStatus";
            btnStatus.RightToLeft = RightToLeft.No;
            btnStatus.Size = new Size(135, 29);
            btnStatus.TabIndex = 14;
            btnStatus.Text = "Status Pesanan";
            btnStatus.UseVisualStyleBackColor = false;
            btnStatus.Click += btnStatus_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.LavenderBlush;
            btnRiwayat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayat.Location = new Point(33, 253);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.RightToLeft = RightToLeft.No;
            btnRiwayat.Size = new Size(135, 29);
            btnRiwayat.TabIndex = 15;
            btnRiwayat.Text = "Riwayat Pesanan";
            btnRiwayat.UseVisualStyleBackColor = false;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.LavenderBlush;
            btnProfil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfil.Location = new Point(33, 296);
            btnProfil.Name = "btnProfil";
            btnProfil.RightToLeft = RightToLeft.No;
            btnProfil.Size = new Size(90, 29);
            btnProfil.TabIndex = 16;
            btnProfil.Text = "Edit Profil";
            btnProfil.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LavenderBlush;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(33, 544);
            btnLogout.Name = "btnLogout";
            btnLogout.RightToLeft = RightToLeft.No;
            btnLogout.Size = new Size(78, 29);
            btnLogout.TabIndex = 17;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // panelMenu
            // 
            panelMenu.BackgroundImage = Properties.Resources.side_panel_customer;
            panelMenu.BackgroundImageLayout = ImageLayout.Zoom;
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnProfil);
            panelMenu.Controls.Add(btnRiwayat);
            panelMenu.Controls.Add(btnStatus);
            panelMenu.Controls.Add(btnBeranda);
            panelMenu.Location = new Point(-1, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(272, 577);
            panelMenu.TabIndex = 13;
            panelMenu.Visible = false;
            // 
            // FormKeranjang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Keranjang;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 578);
            Controls.Add(panelMenu);
            Controls.Add(btnMenu);
            Controls.Add(btnCheckout);
            Controls.Add(lblTotalHarga);
            Controls.Add(flowLayoutPanelKeranjang);
            Name = "FormKeranjang";
            Text = "FormKeranjang";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelKeranjang;
        private Label lblTotalHarga;
        private Button btnCheckout;
        private Button btnMenu;
        private Button btnBeranda;
        private Button btnStatus;
        private Button btnRiwayat;
        private Button btnProfil;
        private Button btnLogout;
        private Panel panelMenu;
    }
}