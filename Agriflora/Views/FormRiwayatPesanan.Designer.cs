namespace Agriflora.Views
{
    partial class FormRiwayatPesanan
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
            btnSemua = new Button();
            btnMenunggu = new Button();
            btnDiproses = new Button();
            btnSiap = new Button();
            btnDiambil = new Button();
            btnSelesai = new Button();
            lblKembali = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.LavenderBlush;
            flowLayoutPanel1.Location = new Point(12, 126);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(958, 440);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnSemua
            // 
            btnSemua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSemua.Location = new Point(26, 70);
            btnSemua.Name = "btnSemua";
            btnSemua.Size = new Size(119, 41);
            btnSemua.TabIndex = 1;
            btnSemua.Text = "Semua";
            btnSemua.UseVisualStyleBackColor = true;
            btnSemua.Click += btnSemua_Click;
            // 
            // btnMenunggu
            // 
            btnMenunggu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenunggu.Location = new Point(151, 70);
            btnMenunggu.Name = "btnMenunggu";
            btnMenunggu.Size = new Size(172, 41);
            btnMenunggu.TabIndex = 2;
            btnMenunggu.Text = "Menunggu Bayar";
            btnMenunggu.UseVisualStyleBackColor = true;
            btnMenunggu.Click += btnMenunggu_Click;
            // 
            // btnDiproses
            // 
            btnDiproses.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiproses.Location = new Point(329, 70);
            btnDiproses.Name = "btnDiproses";
            btnDiproses.Size = new Size(116, 41);
            btnDiproses.TabIndex = 3;
            btnDiproses.Text = "Diproses";
            btnDiproses.UseVisualStyleBackColor = true;
            btnDiproses.Click += btnDiproses_Click;
            // 
            // btnSiap
            // 
            btnSiap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiap.Location = new Point(451, 70);
            btnSiap.Name = "btnSiap";
            btnSiap.Size = new Size(184, 41);
            btnSiap.TabIndex = 4;
            btnSiap.Text = "Pesanan Siap Diambil";
            btnSiap.UseVisualStyleBackColor = true;
            btnSiap.Click += btnSiap_Click;
            // 
            // btnDiambil
            // 
            btnDiambil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiambil.Location = new Point(641, 70);
            btnDiambil.Name = "btnDiambil";
            btnDiambil.Size = new Size(110, 41);
            btnDiambil.TabIndex = 5;
            btnDiambil.Text = "Diambil";
            btnDiambil.UseVisualStyleBackColor = true;
            btnDiambil.Click += btnDiambil_Click;
            // 
            // btnSelesai
            // 
            btnSelesai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelesai.Location = new Point(757, 70);
            btnSelesai.Name = "btnSelesai";
            btnSelesai.Size = new Size(119, 41);
            btnSelesai.TabIndex = 6;
            btnSelesai.Text = "Selesai";
            btnSelesai.UseVisualStyleBackColor = true;
            btnSelesai.Click += btnSelesai_Click;
            // 
            // lblKembali
            // 
            lblKembali.BackColor = SystemColors.ButtonHighlight;
            lblKembali.Image = Properties.Resources.Screenshot_2026_06_11_215716;
            lblKembali.Location = new Point(12, 5);
            lblKembali.Name = "lblKembali";
            lblKembali.Size = new Size(200, 44);
            lblKembali.TabIndex = 7;
            lblKembali.Click += lblKembali_Click;
            // 
            // FormRiwayatPesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Riwayat_Pesanan__Customer_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 578);
            Controls.Add(lblKembali);
            Controls.Add(btnDiambil);
            Controls.Add(btnSelesai);
            Controls.Add(btnSiap);
            Controls.Add(btnDiproses);
            Controls.Add(btnMenunggu);
            Controls.Add(btnSemua);
            Controls.Add(flowLayoutPanel1);
            Name = "FormRiwayatPesanan";
            Text = "FormRiwayatPesanan";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSemua;
        private Button btnMenunggu;
        private Button btnDiproses;
        private Button btnSiap;
        private Button btnDiambil;
        private Button btnSelesai;
        private Label lblKembali;
    }
}