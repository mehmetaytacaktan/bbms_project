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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(314, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 13);
            this.lblWelcome.TabIndex = 0;
            // 
            // btnARM
            // 
            this.btnARM.BackColor = System.Drawing.SystemColors.Control;
            this.btnARM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnARM.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnARM.ForeColor = System.Drawing.Color.Black;
            this.btnARM.Location = new System.Drawing.Point(15, 52);
            this.btnARM.Name = "btnARM";
            this.btnARM.Size = new System.Drawing.Size(332, 113);
            this.btnARM.TabIndex = 1;
            this.btnARM.Text = "Add/Remove/Modify Tour";
            this.btnARM.UseVisualStyleBackColor = false;
            this.btnARM.Click += new System.EventHandler(this.btnARM_Click);
            // 
            // btnIquiry
            // 
            this.btnIquiry.BackColor = System.Drawing.SystemColors.Control;
            this.btnIquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnIquiry.ForeColor = System.Drawing.Color.Black;
            this.btnIquiry.Location = new System.Drawing.Point(353, 54);
            this.btnIquiry.Name = "btnIquiry";
            this.btnIquiry.Size = new System.Drawing.Size(328, 111);
            this.btnIquiry.TabIndex = 2;
            this.btnIquiry.Text = "Customer Inquiry";
            this.btnIquiry.UseVisualStyleBackColor = false;
            this.btnIquiry.Click += new System.EventHandler(this.btnIquiry_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.SystemColors.Control;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnDiscount.ForeColor = System.Drawing.Color.Black;
            this.btnDiscount.Location = new System.Drawing.Point(15, 169);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(330, 113);
            this.btnDiscount.TabIndex = 3;
            this.btnDiscount.Text = "Discount";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnCampaign
            // 
            this.btnCampaign.BackColor = System.Drawing.SystemColors.Control;
            this.btnCampaign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCampaign.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnCampaign.ForeColor = System.Drawing.Color.Black;
            this.btnCampaign.Location = new System.Drawing.Point(351, 171);
            this.btnCampaign.Name = "btnCampaign";
            this.btnCampaign.Size = new System.Drawing.Size(330, 111);
            this.btnCampaign.TabIndex = 4;
            this.btnCampaign.Text = "Tickets";
            this.btnCampaign.UseVisualStyleBackColor = false;
            this.btnCampaign.Click += new System.EventHandler(this.btnCampaign_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCampaign);
            this.groupBox1.Controls.Add(this.btnARM);
            this.groupBox1.Controls.Add(this.btnDiscount);
            this.groupBox1.Controls.Add(this.btnIquiry);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(42, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 295);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin-Panel";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form7";
            this.Text = "Freedom Tourism";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form7_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnARM;
        private System.Windows.Forms.Button btnIquiry;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnCampaign;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

