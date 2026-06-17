namespace Agriflora.Views
{
    partial class HomePageFlorist
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
            tbSearch = new TextBox();
            TabSemua = new TabPage();
            dgvSemua = new DataGridView();
            tabBunga = new TabPage();
            dgvBunga = new DataGridView();
            tabBibit = new TabPage();
            dgvBibit = new DataGridView();
            btnSearch = new Button();
            flowLayoutPanelCard = new FlowLayoutPanel();
            btnTambah = new Button();
            menuStrip1 = new MenuStrip();
            kategoriToolStripMenuItem = new ToolStripMenuItem();
            semua = new ToolStripMenuItem();
            bunga = new ToolStripMenuItem();
            bibit = new ToolStripMenuItem();
            lblDashboard = new Label();
            lblPesanan = new Label();
            lblLaporan = new Label();
            btnLogout = new Button();
            lblNoTelp = new Label();
            lblEmailUser = new Label();
            lblNamaUser = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSemua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBunga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBibit).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbSearch
            // 
            tbSearch.BackColor = Color.Pink;
            tbSearch.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(201, 151);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(423, 43);
            tbSearch.TabIndex = 2;
            tbSearch.TextChanged += tbSearch_TextChanged;
            tbSearch.KeyDown += tbSearch_KeyDown;
            // 
            // TabSemua
            // 
            TabSemua.Location = new Point(0, 0);
            TabSemua.Name = "TabSemua";
            TabSemua.Size = new Size(200, 100);
            TabSemua.TabIndex = 0;
            // 
            // dgvSemua
            // 
            dgvSemua.ColumnHeadersHeight = 29;
            dgvSemua.Location = new Point(0, 0);
            dgvSemua.Name = "dgvSemua";
            dgvSemua.RowHeadersWidth = 51;
            dgvSemua.Size = new Size(240, 150);
            dgvSemua.TabIndex = 0;
            // 
            // tabBunga
            // 
            tabBunga.Location = new Point(0, 0);
            tabBunga.Name = "tabBunga";
            tabBunga.Size = new Size(200, 100);
            tabBunga.TabIndex = 0;
            // 
            // dgvBunga
            // 
            dgvBunga.ColumnHeadersHeight = 29;
            dgvBunga.Location = new Point(0, 0);
            dgvBunga.Name = "dgvBunga";
            dgvBunga.RowHeadersWidth = 51;
            dgvBunga.Size = new Size(240, 150);
            dgvBunga.TabIndex = 0;
            // 
            // tabBibit
            // 
            tabBibit.Location = new Point(0, 0);
            tabBibit.Name = "tabBibit";
            tabBibit.Size = new Size(200, 100);
            tabBibit.TabIndex = 0;
            // 
            // dgvBibit
            // 
            dgvBibit.ColumnHeadersHeight = 29;
            dgvBibit.Location = new Point(0, 0);
            dgvBibit.Name = "dgvBibit";
            dgvBibit.RowHeadersWidth = 51;
            dgvBibit.Size = new Size(240, 150);
            dgvBibit.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Pink;
            btnSearch.Location = new Point(574, 151);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(50, 43);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Cari";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // flowLayoutPanelCard
            // 
            flowLayoutPanelCard.AutoScroll = true;
            flowLayoutPanelCard.BackColor = SystemColors.ButtonHighlight;
            flowLayoutPanelCard.Location = new Point(207, 267);
            flowLayoutPanelCard.Name = "flowLayoutPanelCard";
            flowLayoutPanelCard.Size = new Size(748, 309);
            flowLayoutPanelCard.TabIndex = 5;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.PaleVioletRed;
            btnTambah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = SystemColors.ButtonHighlight;
            btnTambah.Location = new Point(782, 86);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(188, 46);
            btnTambah.TabIndex = 9;
            btnTambah.Text = "Tambah Produk";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kategoriToolStripMenuItem });
            menuStrip1.Location = new Point(632, 151);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(186, 43);
            menuStrip1.Stretch = false;
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // kategoriToolStripMenuItem
            // 
            kategoriToolStripMenuItem.AutoSize = false;
            kategoriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { semua, bunga, bibit });
            kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            kategoriToolStripMenuItem.Size = new Size(152, 39);
            kategoriToolStripMenuItem.Text = "Kategori";
            // 
            // semua
            // 
            semua.Name = "semua";
            semua.Size = new Size(137, 26);
            semua.Text = "Semua";
            semua.Click += semua_Click;
            // 
            // bunga
            // 
            bunga.Name = "bunga";
            bunga.Size = new Size(137, 26);
            bunga.Text = "Bunga";
            bunga.Click += bunga_Click;
            // 
            // bibit
            // 
            bibit.Name = "bibit";
            bibit.Size = new Size(137, 26);
            bibit.Text = "Bibit";
            bibit.Click += bibit_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboard.Image = Properties.Resources.Screenshot_2026_06_12_142250;
            lblDashboard.Location = new Point(5, 157);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(174, 40);
            lblDashboard.TabIndex = 11;
            lblDashboard.Click += lblDashboard_Click;
            // 
            // lblPesanan
            // 
            lblPesanan.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPesanan.Image = Properties.Resources.Screenshot_2026_06_12_142231;
            lblPesanan.Location = new Point(0, 245);
            lblPesanan.Name = "lblPesanan";
            lblPesanan.Size = new Size(163, 40);
            lblPesanan.TabIndex = 12;
            lblPesanan.Click += lblPesanan_Click;
            // 
            // lblLaporan
            // 
            lblLaporan.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLaporan.Image = Properties.Resources.Screenshot_2026_06_12_142239;
            lblLaporan.Location = new Point(0, 290);
            lblLaporan.Name = "lblLaporan";
            lblLaporan.Size = new Size(158, 40);
            lblLaporan.TabIndex = 13;
            lblLaporan.Click += lblLaporan_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LemonChiffon;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(34, 546);
            btnLogout.Name = "btnLogout";
            btnLogout.RightToLeft = RightToLeft.No;
            btnLogout.Size = new Size(78, 29);
            btnLogout.TabIndex = 18;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblNoTelp
            // 
            lblNoTelp.BackColor = Color.PaleVioletRed;
            lblNoTelp.Font = new Font("Segoe UI", 6F);
            lblNoTelp.ForeColor = SystemColors.ButtonHighlight;
            lblNoTelp.Location = new Point(69, 125);
            lblNoTelp.Name = "lblNoTelp";
            lblNoTelp.Size = new Size(110, 12);
            lblNoTelp.TabIndex = 22;
            lblNoTelp.Text = "628123456789";
            // 
            // lblEmailUser
            // 
            lblEmailUser.BackColor = Color.PaleVioletRed;
            lblEmailUser.Font = new Font("Segoe UI", 6F);
            lblEmailUser.ForeColor = SystemColors.ButtonHighlight;
            lblEmailUser.Location = new Point(69, 113);
            lblEmailUser.Name = "lblEmailUser";
            lblEmailUser.Size = new Size(110, 12);
            lblEmailUser.TabIndex = 21;
            lblEmailUser.Text = "rabvinna@gmail.com";
            // 
            // lblNamaUser
            // 
            lblNamaUser.BackColor = Color.PaleVioletRed;
            lblNamaUser.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaUser.ForeColor = SystemColors.ButtonHighlight;
            lblNamaUser.Location = new Point(69, 96);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(110, 17);
            lblNamaUser.TabIndex = 20;
            lblNamaUser.Text = "Rabvinna Salsabila";
            // 
            // HomePageFlorist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.HomepageFlorist;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 578);
            Controls.Add(lblNoTelp);
            Controls.Add(lblEmailUser);
            Controls.Add(lblNamaUser);
            Controls.Add(btnLogout);
            Controls.Add(lblLaporan);
            Controls.Add(lblPesanan);
            Controls.Add(lblDashboard);
            Controls.Add(btnSearch);
            Controls.Add(btnTambah);
            Controls.Add(flowLayoutPanelCard);
            Controls.Add(tbSearch);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "HomePageFlorist";
            Text = "HomePageFlorist";
            ((System.ComponentModel.ISupportInitialize)dgvSemua).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBunga).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBibit).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbSearch;
        private TabPage TabSemua;
        private TabPage tabBunga;
        private TabPage tabBibit;
        private DataGridView dgvSemua;
        private DataGridView dgvBunga;
        private DataGridView dgvBibit;
        private Button btnSearch;
        private FlowLayoutPanel flowLayoutPanelCard;
        private Button btnTambah;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem kategoriToolStripMenuItem;
        private ToolStripMenuItem semua;
        private ToolStripMenuItem bunga;
        private ToolStripMenuItem bibit;
        private Label lblDashboard;
        private Label lblPesanan;
        private Label lblLaporan;
        private Button btnLogout;
        private Label lblNoTelp;
        private Label lblEmailUser;
        private Label lblNamaUser;
    }
}