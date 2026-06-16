namespace Agriflora.Views
{
    partial class FormCheckout
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
            lblTotalHarga = new Label();
            flowLayoutPanelCheckout = new FlowLayoutPanel();
            radioQris = new RadioButton();
            radioCash = new RadioButton();
            btnBayar = new Button();
            btnPakaiVoucher = new Button();
            lblDiskon = new Label();
            lblVoucherStatus = new Label();
            tbVoucher = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.BackColor = SystemColors.ButtonHighlight;
            lblTotalHarga.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalHarga.ForeColor = Color.PaleVioletRed;
            lblTotalHarga.Location = new Point(812, 477);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(90, 20);
            lblTotalHarga.TabIndex = 1;
            lblTotalHarga.Text = "Rp 177.000";
            lblTotalHarga.Click += lblTotalHarga_Click;
            // 
            // flowLayoutPanelCheckout
            // 
            flowLayoutPanelCheckout.AutoScroll = true;
            flowLayoutPanelCheckout.BackColor = SystemColors.ButtonHighlight;
            flowLayoutPanelCheckout.Location = new Point(17, 194);
            flowLayoutPanelCheckout.Name = "flowLayoutPanelCheckout";
            flowLayoutPanelCheckout.Size = new Size(947, 116);
            flowLayoutPanelCheckout.TabIndex = 2;
            // 
            // radioQris
            // 
            radioQris.BackColor = SystemColors.ControlLight;
            radioQris.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioQris.Location = new Point(40, 359);
            radioQris.Name = "radioQris";
            radioQris.Size = new Size(32, 27);
            radioQris.TabIndex = 3;
            radioQris.TabStop = true;
            radioQris.UseVisualStyleBackColor = false;
            radioQris.CheckedChanged += radioQris_CheckedChanged;
            // 
            // radioCash
            // 
            radioCash.BackColor = SystemColors.ControlLight;
            radioCash.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioCash.Location = new Point(40, 407);
            radioCash.Name = "radioCash";
            radioCash.Size = new Size(32, 27);
            radioCash.TabIndex = 4;
            radioCash.TabStop = true;
            radioCash.UseVisualStyleBackColor = false;
            // 
            // btnBayar
            // 
            btnBayar.BackColor = Color.PaleVioletRed;
            btnBayar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBayar.ForeColor = SystemColors.Control;
            btnBayar.Location = new Point(16, 515);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(953, 60);
            btnBayar.TabIndex = 2;
            btnBayar.Text = "Bayar Sekarang";
            btnBayar.UseVisualStyleBackColor = false;
            btnBayar.Click += btnBayar_Click;
            // 
            // btnPakaiVoucher
            // 
            btnPakaiVoucher.BackColor = Color.Green;
            btnPakaiVoucher.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPakaiVoucher.ForeColor = SystemColors.Control;
            btnPakaiVoucher.Location = new Point(812, 408);
            btnPakaiVoucher.Name = "btnPakaiVoucher";
            btnPakaiVoucher.Size = new Size(149, 29);
            btnPakaiVoucher.TabIndex = 9;
            btnPakaiVoucher.Text = "Pakai Voucher";
            btnPakaiVoucher.UseVisualStyleBackColor = false;
            btnPakaiVoucher.Click += btnPakaiVoucher_Click;
            // 
            // lblDiskon
            // 
            lblDiskon.BackColor = SystemColors.ButtonHighlight;
            lblDiskon.Location = new Point(600, 362);
            lblDiskon.Name = "lblDiskon";
            lblDiskon.Size = new Size(239, 20);
            lblDiskon.TabIndex = 8;
            lblDiskon.Text = "Diskon";
            lblDiskon.Visible = false;
            // 
            // lblVoucherStatus
            // 
            lblVoucherStatus.BackColor = SystemColors.ButtonHighlight;
            lblVoucherStatus.Location = new Point(600, 382);
            lblVoucherStatus.Name = "lblVoucherStatus";
            lblVoucherStatus.Size = new Size(343, 21);
            lblVoucherStatus.TabIndex = 7;
            lblVoucherStatus.Text = "StatusVoucher";
            lblVoucherStatus.Visible = false;
            // 
            // tbVoucher
            // 
            tbVoucher.Location = new Point(686, 330);
            tbVoucher.Name = "tbVoucher";
            tbVoucher.Size = new Size(257, 27);
            tbVoucher.TabIndex = 6;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(601, 403);
            label1.Name = "label1";
            label1.Size = new Size(201, 21);
            label1.TabIndex = 10;
            label1.Visible = false;
            // 
            // FormCheckout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Checkout1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 578);
            Controls.Add(label1);
            Controls.Add(btnPakaiVoucher);
            Controls.Add(lblVoucherStatus);
            Controls.Add(lblDiskon);
            Controls.Add(btnBayar);
            Controls.Add(radioCash);
            Controls.Add(tbVoucher);
            Controls.Add(radioQris);
            Controls.Add(flowLayoutPanelCheckout);
            Controls.Add(lblTotalHarga);
            Name = "FormCheckout";
            Text = "FormCheckout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalHarga;
        private FlowLayoutPanel flowLayoutPanelCheckout;
        private RadioButton radioQris;
        private RadioButton radioCash;
        private Button btnBayar;
        private Button btnPakaiVoucher;
        private Label lblDiskon;
        private Label lblVoucherStatus;
        private TextBox tbVoucher;
        private Label label1;
    }
}