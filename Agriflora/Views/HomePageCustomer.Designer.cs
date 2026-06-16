namespace Agriflora.Views
{
    partial class HomePageCustomer
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            tbSearch = new TextBox();
            btnSemua = new Button();
            btnBibit = new Button();
            btnBunga = new Button();
            btnMenu = new Button();
            panelMenu = new Panel();
            lblNoTelp = new Label();
            lblEmailUser = new Label();
            lblNamaUser = new Label();
            btnLogout = new Button();
            btnProfil = new Button();
            btnRiwayat = new Button();
            btnStatus = new Button();
            btnBeranda = new Button();
            btnKeranjang = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.LavenderBlush;
            flowLayoutPanel1.Location = new Point(3, 198);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(760, 379);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // tbSearch
            // 
            tbSearch.BackColor = Color.Pink;
            tbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(12, 91);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(958, 47);
            tbSearch.TabIndex = 3;
            tbSearch.KeyDown += tbSearch_KeyDown;
            // 
            // btnSemua
            // 
            btnSemua.BackColor = Color.PaleGreen;
            btnSemua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSemua.Location = new Point(105, 144);
            btnSemua.Name = "btnSemua";
            btnSemua.Size = new Size(96, 29);
            btnSemua.TabIndex = 8;
            btnSemua.Text = "Semua";
            btnSemua.UseVisualStyleBackColor = false;
            btnSemua.Click += btnSemua_Click;
            // 
            // btnBibit
            // 
            btnBibit.BackColor = Color.PaleGreen;
            btnBibit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBibit.Location = new Point(316, 144);
            btnBibit.Name = "btnBibit";
            btnBibit.Size = new Size(96, 29);
            btnBibit.TabIndex = 9;
            btnBibit.Text = "Bibit";
            btnBibit.UseVisualStyleBackColor = false;
            btnBibit.Click += btnBibit_Click;
            // 
            // btnBunga
            // 
            btnBunga.BackColor = Color.PaleGreen;
            btnBunga.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBunga.Location = new Point(210, 144);
            btnBunga.Name = "btnBunga";
            btnBunga.Size = new Size(96, 29);
            btnBunga.TabIndex = 10;
            btnBunga.Text = "Bunga";
            btnBunga.UseVisualStyleBackColor = false;
            btnBunga.Click += btnBunga_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.LavenderBlush;
            btnMenu.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(3, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(47, 49);
            btnMenu.TabIndex = 11;
            btnMenu.Text = "☰";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackgroundImage = Properties.Resources.side_panel_customer;
            panelMenu.BackgroundImageLayout = ImageLayout.Zoom;
            panelMenu.Controls.Add(lblNoTelp);
            panelMenu.Controls.Add(lblEmailUser);
            panelMenu.Controls.Add(lblNamaUser);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnProfil);
            panelMenu.Controls.Add(btnRiwayat);
            panelMenu.Controls.Add(btnStatus);
            panelMenu.Controls.Add(btnBeranda);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(272, 577);
            panelMenu.TabIndex = 12;
            panelMenu.Visible = false;
            // 
            // lblNoTelp
            // 
            lblNoTelp.AutoSize = true;
            lblNoTelp.BackColor = Color.Pink;
            lblNoTelp.Font = new Font("Segoe UI", 6F);
            lblNoTelp.ForeColor = SystemColors.ButtonHighlight;
            lblNoTelp.Location = new Point(53, 133);
            lblNoTelp.Name = "lblNoTelp";
            lblNoTelp.Size = new Size(65, 12);
            lblNoTelp.TabIndex = 19;
            lblNoTelp.Text = "628123456789";
            // 
            // lblEmailUser
            // 
            lblEmailUser.AutoSize = true;
            lblEmailUser.BackColor = Color.Pink;
            lblEmailUser.Font = new Font("Segoe UI", 6F);
            lblEmailUser.ForeColor = SystemColors.ButtonHighlight;
            lblEmailUser.Location = new Point(53, 121);
            lblEmailUser.Name = "lblEmailUser";
            lblEmailUser.Size = new Size(99, 12);
            lblEmailUser.TabIndex = 18;
            lblEmailUser.Text = "rabvinna@gmail.com";
            lblEmailUser.Click += label1_Click;
            // 
            // lblNamaUser
            // 
            lblNamaUser.AutoSize = true;
            lblNamaUser.BackColor = Color.Pink;
            lblNamaUser.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaUser.ForeColor = SystemColors.ButtonHighlight;
            lblNamaUser.Location = new Point(53, 104);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(116, 17);
            lblNamaUser.TabIndex = 14;
            lblNamaUser.Text = "Rabvinna Salsabila";
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
            btnLogout.Click += btnLogout_Click;
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
            btnProfil.Click += btnProfil_Click;
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
            btnRiwayat.Click += btnRiwayat_Click;
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
            // btnKeranjang
            // 
            btnKeranjang.BackgroundImage = Properties.Resources.Screenshot_2026_06_06_182345;
            btnKeranjang.Location = new Point(908, 9);
            btnKeranjang.Name = "btnKeranjang";
            btnKeranjang.Size = new Size(62, 57);
            btnKeranjang.TabIndex = 13;
            btnKeranjang.UseVisualStyleBackColor = true;
            btnKeranjang.Click += btnKeranjang_Click;
            // 
            // HomePageCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Homepage_Customer;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 578);
            Controls.Add(btnKeranjang);
            Controls.Add(panelMenu);
            Controls.Add(btnMenu);
            Controls.Add(btnBunga);
            Controls.Add(btnBibit);
            Controls.Add(btnSemua);
            Controls.Add(tbSearch);
            Controls.Add(flowLayoutPanel1);
            Name = "HomePageCustomer";
            Text = "HomePageCustomer";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox tbSearch;
        private Button btnSemua;
        private Button btnBibit;
        private Button btnBunga;
        private Button btnMenu;
        private Panel panelMenu;
        private Button btnBeranda;
        private Button btnLogout;
        private Button btnProfil;
        private Button btnRiwayat;
        private Button btnStatus;
        private Button btnKeranjang;
        private Label lblNamaUser;
        private Label lblNoTelp;
        private Label lblEmailUser;
    }
}