namespace Agriflora.Views
{
    partial class FormStatusPesanan
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
            flowPesanan = new FlowLayoutPanel();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // flowPesanan
            // 
            flowPesanan.AutoScroll = true;
            flowPesanan.BackColor = Color.LavenderBlush;
            flowPesanan.Location = new Point(23, 76);
            flowPesanan.Name = "flowPesanan";
            flowPesanan.Size = new Size(936, 490);
            flowPesanan.TabIndex = 0;
            // 
            // btnKembali
            // 
            btnKembali.BackgroundImage = Properties.Resources.Screenshot_2026_06_07_211104;
            btnKembali.BackgroundImageLayout = ImageLayout.Zoom;
            btnKembali.Location = new Point(8, 8);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(175, 44);
            btnKembali.TabIndex = 1;
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormStatusPesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Status_Pesanan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 578);
            Controls.Add(btnKembali);
            Controls.Add(flowPesanan);
            Name = "FormStatusPesanan";
            Text = "FormStatusPesanan";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowPesanan;
        private Button btnKembali;
    }
}