namespace BMSAdminPanel
{
    partial class Form7
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnARM = new System.Windows.Forms.Button();
            this.btnIquiry = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnCampaign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(158, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(152, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome To The Admin Panel";
            // 
            // btnARM
            // 
            this.btnARM.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnARM.Location = new System.Drawing.Point(37, 75);
            this.btnARM.Name = "btnARM";
            this.btnARM.Size = new System.Drawing.Size(149, 90);
            this.btnARM.TabIndex = 1;
            this.btnARM.Text = "Tour Add/ Remove/ Modify";
            this.btnARM.UseVisualStyleBackColor = false;
            this.btnARM.Click += new System.EventHandler(this.btnARM_Click);
            // 
            // btnIquiry
            // 
            this.btnIquiry.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnIquiry.Location = new System.Drawing.Point(285, 77);
            this.btnIquiry.Name = "btnIquiry";
            this.btnIquiry.Size = new System.Drawing.Size(147, 88);
            this.btnIquiry.TabIndex = 2;
            this.btnIquiry.Text = "Customer Inquiry";
            this.btnIquiry.UseVisualStyleBackColor = false;
            this.btnIquiry.Click += new System.EventHandler(this.btnIquiry_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDiscount.Location = new System.Drawing.Point(37, 195);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(149, 90);
            this.btnDiscount.TabIndex = 3;
            this.btnDiscount.Text = "Discount";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnCampaign
            // 
            this.btnCampaign.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCampaign.Location = new System.Drawing.Point(285, 197);
            this.btnCampaign.Name = "btnCampaign";
            this.btnCampaign.Size = new System.Drawing.Size(149, 88);
            this.btnCampaign.TabIndex = 4;
            this.btnCampaign.Text = "Campaign";
            this.btnCampaign.UseVisualStyleBackColor = false;
            this.btnCampaign.Click += new System.EventHandler(this.btnCampaign_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 415);
            this.Controls.Add(this.btnCampaign);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.btnIquiry);
            this.Controls.Add(this.btnARM);
            this.Controls.Add(this.lblWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(566, 454);
            this.MinimumSize = new System.Drawing.Size(566, 454);
            this.Name = "Form7";
            this.Text = "Freedom Tourism";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form7_FormClosing);
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnARM;
        private System.Windows.Forms.Button btnIquiry;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnCampaign;
    }
}

